using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }

        public string ResimUrl { get; set; }

        public string Parola { get; set; }

        public virtual ICollection<UsersRole> UsersRoles { get; set; }
        public virtual ICollection<Gorev> Gorevs { get; set; }
    }
}
