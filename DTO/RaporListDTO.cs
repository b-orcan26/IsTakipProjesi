using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class RaporListDTO
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public DateTime YazilmaTarihi { get; set; }
        public bool Okundumu { get; set; }
    }
}
