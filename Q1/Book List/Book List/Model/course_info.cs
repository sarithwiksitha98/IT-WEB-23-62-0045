using System.ComponentModel.DataAnnotations;

namespace Book_List.Model
{
    public class course_info
    {
        [Key]
        public int course_Id {  get; set; }

        public string name { get; set; }

        public string lecturer_name { get; set; }
    }
}
