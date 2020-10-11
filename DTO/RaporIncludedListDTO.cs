using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class RaporIncludedListDTO
    {
        public int Id { get; set; }
        public string Icerik { get; set; }
        public DateTime? YazilmaTarihi { get; set; } = null;
        public Gorev Gorev { get; set; }
        public int? GorevId { get; set; } = null;
        public bool Okundumu { get; set; } = false;

        public string CreatedName { get; set; }
    }
}
