using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea_System.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public int RoleId { get; set; }
        public int DepartmentId { get; set; }

        // Navigation properties
        public virtual Role Role { get; set; }
        public virtual Department Department { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<React> Reacts { get; internal set; }
    }
}