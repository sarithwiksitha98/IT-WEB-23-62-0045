using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Q2.Model
{
    public class student_info
    {
        [Key]
        public int student_id { get; set; }

        public string name { get; set; }

        public string city { get; set; }

        [ForeignKey("course_Id")]
        public int course_id { get; set; }
    }
}
