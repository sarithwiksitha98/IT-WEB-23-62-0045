using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Q2.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public student_info student_info { get; set; }

        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.student_info.AddAsync(student_info);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
