using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Idea_System.Models
{
    public class Topic
    {
        public int TopicId { get; set; }
        public string Title { get; set; }
        public DateTime Deadline1 { get; set; }
        public DateTime Deadline2 { get; set; }
    }
}