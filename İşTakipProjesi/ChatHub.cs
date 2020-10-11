using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace İşTakipProjesi
{
    [Authorize]
    public class ChatHub : Hub 
    {
        private readonly IUserService userManager;
        private readonly IMapper mapper;
        private readonly IMessageService messageManager;

        public struct UserInfo
        {
            public string UserName { get; set; }
        }

        public ChatHub(IUserService _userManager , IMapper _mapper, IMessageService _messageManager)
        {
            userManager = _userManager;
            mapper = _mapper;
            messageManager = _messageManager;
            
        }

        static Dictionary<string, string> ActiveUser = new Dictionary<string, string>();

        public override async Task OnConnectedAsync()
        {
            // bir kullanıcı bağlandığında conId si ile Username'ini Dictionary'de tutalım
            //var username = Context.User.Identity.Name;
            var username = Context.User.Identity.Name;
            var connectionId = Context.ConnectionId;
            if (ActiveUser.ContainsValue(username))
            {
                var key = (from p in ActiveUser where p.Value == username select p.Key).FirstOrDefault();
                ActiveUser.Remove(key);
                ActiveUser.Add(connectionId, username);
            }
            else
            {
                ActiveUser.Add(connectionId, username);
            }
            

            //kullanıcıya id sini gönderelim
            var connectedUser = await userManager.GetUserByUsername(username);
            await SendId(connectedUser.Id, connectionId);

            // yeni baglanan kullanıcıya tüm userları gönder

            List<UserListDTO> users = new List<UserListDTO>();
            var allUserList = await userManager.GetAllAsync();
            users = mapper.Map<List<UserListDTO>>(allUserList);
            await SendAllUsers(users, connectionId);

            // sonra aktif userları gönder
            List<UserInfo> liste = new List<UserInfo>();
            foreach(var item in ActiveUser)
            {
                UserInfo info = new UserInfo()
                {
                    UserName = item.Value
                };
                liste.Add(info);
            }

            await SendActiveUsers(liste, connectionId);

            //diğer bağlanmış userlara ise kullanıcının bağlandığı bilgisini gönder
            await Clients.All.SendAsync("UserConnected", connectedUser.Id);


            // kullanıcıya mesajları gönder
            var messages = await messageManager.GetAllWithIncludedElementsAsync(connectedUser.Id);
            await SendAllMessages(messages, connectionId);

            await base.OnConnectedAsync();
        }
        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var id = Context.ConnectionId;
            var username = ActiveUser[id];
            var user = await userManager.GetUserByUsername(username);
            var userId = user.Id;
            bool isRemoved = ActiveUser.Remove(id);

            if (isRemoved)
            {
                await Clients.All.SendAsync("UserDisconnected", userId);
            }

            await base.OnDisconnectedAsync(exception);
        }


        /*                           Functions That Clients Calls                                        */
        public async Task SendMessageToUser(int alanUserId, int gonderenUserId, string Icerik)
        {

            var alanUser = await userManager.Get(Convert.ToInt32(alanUserId));

            if (alanUser != null)
            {
                MessageAddDTO dto = new MessageAddDTO()
                {
                    AlanUserId = Convert.ToInt32(alanUserId),
                    GonderenUserId = Convert.ToInt32(gonderenUserId),
                    Icerik = Icerik,
                    Tarih = DateTime.Now
                };


                var message = mapper.Map<Message>(dto);
                await messageManager.Add(message);
                                               
                // Mesajı veritabanına kaydettikten sonra , mesaj gonderilen user aktifse ona mesajı iletiyoruz
                if (ActiveUser.ContainsValue(alanUser.KullaniciAdi))
                {
                    message.AlanUser = alanUser;
                    message.GonderenUser = await userManager.Get(Convert.ToInt32(gonderenUserId));
                    var alanUserConnectionId = ActiveUser.FirstOrDefault(x => x.Value == alanUser.KullaniciAdi).Key;

                    await Clients.Client(alanUserConnectionId).SendAsync("ReceiveNewMessage", message);                    
                    
                }
            }
        }


        /*                           Functions Used in Server                                            */

        private async Task SendAllUsers(List<UserListDTO> userList,string connectionId)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveAllUsers", userList);
        }     
        private async Task SendActiveUsers(List<UserInfo> userNames,string connectionId)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveActiveUsers",userNames);
        }
        private async Task SendAllMessages(List<Message> messages ,string connectionId)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveMessages", messages);
        }
        private async Task SendId(int Id, string connectionId)
        {
            await Clients.Client(connectionId).SendAsync("ReceiveId", Id);
        }




    }
}
