using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Student_Manageament_System_WebDev.Data;
using Student_Manageament_System_WebDev.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SLIIT_Student_Management_System_P.Pages
{
    public class StudentDetailsModel : PageModel
    {
        private readonly Student_Manageament_System_WebDevContext _context;

        public StudentDetailsModel(Student_Manageament_System_WebDevContext context)
        {
            _context = context;
        }

        public IList<Student> Students { get; set; }

        public async Task OnGetAsync()
        {
            Students = await _context.Student.Include(s => s.Course).ToListAsync();
        }
    }
}
