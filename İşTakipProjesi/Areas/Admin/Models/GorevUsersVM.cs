using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace İşTakipProjesi.Areas.Admin.Models
{
    public class GorevUsersVM
    {
        public Gorev gorev { get; set; }
        public List<User> users { get; set; }
    }
}
