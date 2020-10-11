using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Message
    {
        public int Id { get; set; }

        public string Icerik { get; set; }

        public DateTime Tarih { get; set; }

        public User GonderenUser { get; set; }

        public int GonderenUserId { get; set; }

        public User AlanUser { get; set; }

        public int AlanUserId { get; set; }
    }
}
