using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Idea_System.Models
{
    public class Idea
    {
        public int IdeaId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }
        public int TopicId { get; set; }
        [ForeignKey("TopicId")]
        public virtual Topic Topic { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsEnabled { get; set; }
        public virtual ICollection<Document> Documents { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
        public ICollection<React> Reacts { get; internal set; }
    }

}