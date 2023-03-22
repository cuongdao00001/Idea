using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea_System.Models
{
    public class React
    {
        public int ReactId { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int IdeaId { get; set; }
        public virtual Idea Idea { get; set; }
    }
}