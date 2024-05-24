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
    public class IndexModel : PageModel
    {
        private readonly Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext _context;

        public IndexModel(Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Student
                .Include(s => s.Course).ToListAsync();
        }
    }
}
