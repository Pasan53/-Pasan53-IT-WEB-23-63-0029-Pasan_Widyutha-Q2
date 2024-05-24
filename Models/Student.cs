using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Student_Manageament_System_WebDev.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; } // This is the primary key for students.
                                           // This will not be displayed in the wesite as it is
                                           // automatically generated.

        public string? Name { get; set; }

        public string? City { get; set; }

        // Setting the Foreign key Course for students
        public int CourseId { get; set; }


        [ForeignKey("CourseId")]
        public Course? Course { get; set; }
    }
}
