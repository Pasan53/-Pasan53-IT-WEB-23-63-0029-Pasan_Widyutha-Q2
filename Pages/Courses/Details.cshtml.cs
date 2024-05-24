using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Manageament_System_WebDev.Data;
using Student_Manageament_System_WebDev.Models;

namespace Student_Manageament_System_WebDev.Pages.Courses
{
    public class DetailsModel : PageModel
    {
        private readonly Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext _context;

        public DetailsModel(Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext context)
        {
            _context = context;
        }

        public Course Course { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Course.FirstOrDefaultAsync(m => m.CourseId == id);
            if (course == null)
            {
                return NotFound();
            }
            else
            {
                Course = course;
            }
            return Page();
        }
    }
}
