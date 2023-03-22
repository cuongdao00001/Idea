using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea_System.Models
{
    public class Role
    {
        public int RoleId { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public virtual ICollection<User> Users { get; set; }
    }
}