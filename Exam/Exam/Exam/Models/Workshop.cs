using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Exam.Models
{
    [Table("workshop")]
    public class Workshop
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Topic { get; set; }
        public string Topics_brief_desciption { get; set; }
        public string Presenters_name { get; set; }
        public string Location { get; set; }
    }
}