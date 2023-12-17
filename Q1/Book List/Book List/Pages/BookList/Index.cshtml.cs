using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Book_List.Pages.BookList
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public IndexModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<student_info> student_Infos { get; set; }

        public async Task OnGet()
        {
            student_Infos = await _db.student_info.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var student_Info = await _db.student_info.FindAsync(id);
            if (student_Info == null)
            {
                return NotFound();
            }
            _db.student_info.Remove(student_Info);
            await _db.SaveChangesAsync();

            return RedirectToAction("Index"); 
        }
    }
}
