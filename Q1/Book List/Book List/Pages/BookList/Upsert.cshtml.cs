using Q2.Model;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Book_List.Model;

namespace Q2.Pages.BookList
{
    public class Q2Model : PageModel
    {
        private readonly ApplicationDbContext _db;

        public Q2Model(ApplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public course_info course_Info { get; set; }

        public void OnGet()
        {
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.course_info.AddAsync(course_Info);
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
