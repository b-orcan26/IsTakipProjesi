using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class MessageAddDTO
    {

        public string Icerik { get; set; }

        public DateTime Tarih { get; set; }

        public int GonderenUserId { get; set; }

        public int AlanUserId { get; set; }

    }
}
