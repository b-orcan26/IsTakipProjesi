using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using Business.Interfaces;
using DTO;
using Entities;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace İşTakipProjesi.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAuthService authManager;
        private readonly IMapper mapper;

        public IActionResult Index()
        {
            return View();
        }

        public HomeController(IAuthService _authManager , IMapper _mapper)
        {
            authManager = _authManager;
            mapper = _mapper;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO model)
        {
            if (ModelState.IsValid)
            {
                var user = mapper.Map<User>(model);
                var connectedUser = await authManager.Login(user);
                if (connectedUser != null)
                {
                    var roles = await authManager.GetRolesByUserId(connectedUser.Id);

                    if (roles != null)
                    {
                        var userClaims = new List<Claim>() { new Claim(ClaimTypes.Name, connectedUser.KullaniciAdi) };

                        if (roles.Any(i => i.RolAdi == "Admin"))
                        {

                            await CreateClaimsForUser(userClaims, "Admin");
                            return RedirectToAction("Index", "Home", new { area = "Admin" });
                        }
                        if (roles.Any(i => i.RolAdi == "Member"))
                        {
                            await CreateClaimsForUser(userClaims, "Member");
                            return RedirectToAction("Gorevler", "Gorev", new { area = "Personel" });
                          
                        }
                    }                                                                         
                }
                ModelState.AddModelError("", "Kullanıcı Adı veya Şifre Hatalı");
            }
            return View(model);
        }
        
        public async Task CreateClaimsForUser(List<Claim> userClaims , string RoleName)
        {
            var roleClaims = new List<Claim>() { new Claim(ClaimTypes.Role, RoleName) };
            ClaimsIdentity grandmaIdentity = new ClaimsIdentity(userClaims, "User Identity");
            grandmaIdentity.AddClaims(roleClaims);

            var userPrincipal = new ClaimsPrincipal(new[] { grandmaIdentity });
            await HttpContext.SignInAsync(userPrincipal);
        }

        [Authorize]
        public async Task<IActionResult> LogOut()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }


    }
}
