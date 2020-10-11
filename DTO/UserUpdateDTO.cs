using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class UserUpdateDTO
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string ResimUrl { get; set; }
        public string KullaniciAdi { get; set; }
    }
}
