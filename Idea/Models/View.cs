using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea_System.Models
{
    public class View
    {
        public int ViewId { get; set; }
        public DateTime Visittime { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }

        // Khóa ngoại tới bảng Idea
        public int IdeaId { get; set; }
        public virtual Idea Idea { get; set; }
    }
}