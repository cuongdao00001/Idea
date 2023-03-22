using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea_System.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }

        // Navigation properties
        public virtual ICollection<User> Users { get; set; }
    }
}