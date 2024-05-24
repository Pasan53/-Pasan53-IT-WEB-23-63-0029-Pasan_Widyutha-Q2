using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Student_Manageament_System_WebDev.Models;

namespace Student_Manageament_System_WebDev.Data
{
    public class Student_Manageament_System_WebDevContext : DbContext
    {
        public Student_Manageament_System_WebDevContext (DbContextOptions<Student_Manageament_System_WebDevContext> options)
            : base(options)
        {
        }

        public DbSet<Student_Manageament_System_WebDev.Models.Course> Course { get; set; } = default!;
        public DbSet<Student_Manageament_System_WebDev.Models.Student> Student { get; set; } = default!;
    }
}
