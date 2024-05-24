using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Student_Manageament_System_WebDev.Data;
using Student_Manageament_System_WebDev.Models;

namespace Student_Manageament_System_WebDev.Pages.Courses
{
    public class CreateModel : PageModel
    {
        private readonly Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext _context;

        public CreateModel(Student_Manageament_System_WebDev.Data.Student_Manageament_System_WebDevContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Course.Add(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
