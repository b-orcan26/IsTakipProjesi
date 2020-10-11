using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Gorev
    {
        public int Id { get; set; }
        public string Tanim { get; set; }
        public string Aciklama { get; set; }
        public bool Durum { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public List<Rapor> Rapors { get; set; }
    }
}
