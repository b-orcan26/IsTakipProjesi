using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class RaporAddDTO
    {
        public string Icerik { get; set; }
        public DateTime? YazilmaTarihi { get; set; } = DateTime.Now;
        public int? GorevId { get; set; }
        public bool Okundumu { get; set; } = false;
    }
}
