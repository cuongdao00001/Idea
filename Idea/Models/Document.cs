using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Idea_System.Models
{
    public class Document
    {
        public int DocumentId { get; set; }
        public string FileName { get; set; }
        public byte[] FileData { get; set; }
        public int IdeaId { get; set; }
        [ForeignKey("IdeaId")]
        public virtual Idea Idea { get; set; }
    }
}