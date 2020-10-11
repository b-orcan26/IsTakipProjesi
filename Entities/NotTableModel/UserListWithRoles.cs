using System.Collections.Generic;
namespace Entities
{
    public class UserListWithRoles
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public List<Role> Roles { get; set; }
    }
}
