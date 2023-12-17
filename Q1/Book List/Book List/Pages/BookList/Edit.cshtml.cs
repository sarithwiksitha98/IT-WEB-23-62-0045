using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Q2.Pages.BookList
{
    public class EditModel : PageModel
    {

        private ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public student_info student_Info { get; set; }
        public async Task OnGet(int id)
        {
            student_Info = await _db.student_info.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var BookFromDb = await _db.student_info.FindAsync(student_Info.student_id);
                BookFromDb.name = student_Info.name;
                BookFromDb.city = student_Info.city;
                BookFromDb.course_id = student_Info.course_id;

                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return RedirectToPage();
        }
    }
}
