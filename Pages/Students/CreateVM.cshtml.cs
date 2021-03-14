using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading.Tasks;

namespace ContosoUniversity.Pages.Students
{
    public class CreateVMModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public CreateVMModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            StudentVM = new StudentVM
            {
                EnrollmentDate = DateTime.Now,
                FirstMidName = "Joe",
                LastName = "Smith"
            };
            return Page();
        }
        #region snippet
        [BindProperty]
        public StudentVM StudentVM { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var student = new Student(lastName: StudentVM.LastName, firstMidName: StudentVM.FirstMidName, enrollmentDate: StudentVM.EnrollmentDate);
            var entry = _context.Add(student);
            await _context.SaveChangesAsync();
            return RedirectToPage("./Index");
        }
        #endregion
    }
}
