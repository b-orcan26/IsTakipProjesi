using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UserListWithRolesDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public List<Role> Roles { get; set; }
    }
}
