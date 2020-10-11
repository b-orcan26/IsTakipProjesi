using System;

namespace Entities
{
    public class Rapor
    {
        //public int Id { get; set; }
        //public string Icerik { get; set; }
        //public DateTime? YazilmaTarihi { get; set; } = null;
        //public Gorev Gorev { get; set; }
        //public int? GorevId { get; set; } = null;
        //public bool Okundumu { get; set; } = false;

        public int Id { get; set; }
        public string Icerik { get; set; }
        public DateTime? YazilmaTarihi { get; set; } 
        public Gorev Gorev { get; set; }
        public int? GorevId { get; set; } 
        public bool Okundumu { get; set; } = false;
    }
}
