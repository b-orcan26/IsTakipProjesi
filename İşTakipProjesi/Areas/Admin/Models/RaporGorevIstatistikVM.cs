using Entities;
using System.Collections.Generic;


namespace İşTakipProjesi.Areas.Admin.Models
{
    public class RaporGorevIstatistikVM
    {
        public List<Rapor> rapors { get; set; }
        public List<Gorev> gorevs { get; set; }
    }
}
