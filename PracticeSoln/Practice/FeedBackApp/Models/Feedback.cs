using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace FeedBackApp.Models
{
    [Table("feedback")]
    public class Feedback
    {
        public int Id { get; set; }
        public string Faculty { get; set; }
        public string Module { get; set; }
        public int Rating { get; set; }
    }
}