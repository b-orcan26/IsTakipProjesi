using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string RolAdi { get; set; }
        public virtual ICollection<UsersRole> UsersRoles { get; set; }
    }
}
