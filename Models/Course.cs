using System.ComponentModel.DataAnnotations;

namespace Student_Manageament_System_WebDev.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; } // This is the primary key for course
                                          // This will not be displayed in the wesite as it is
                                          // automatically generated.

        public string? Name { get; set; }

        public string? Lecturer_Name { get; set; }

        // Since student use the course Id as a foreign key, setting navigation property
        // for related students
        public ICollection<Student>? Students { get; set; }
    }
}
