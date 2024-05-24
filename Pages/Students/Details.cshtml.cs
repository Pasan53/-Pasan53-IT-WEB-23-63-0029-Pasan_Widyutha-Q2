using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Manageament_System_WebDev.Data;
using Student_Manageament_System_WebDev.Models;

namespace Student_Manageament_System_WebDev.Pages.Students
{
    public class DetailsModel : PageModel
    {
        private readonly Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext _context;

        public DetailsModel(Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext context)
        {
            _context = context;
        }

        public Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var student = await _context.Student.FirstOrDefaultAsync(m => m.StudentId == id);
            if (student == null)
            {
                return NotFound();
            }
            else
            {
                Student = student;
            }
            return Page();
        }
    }
}
