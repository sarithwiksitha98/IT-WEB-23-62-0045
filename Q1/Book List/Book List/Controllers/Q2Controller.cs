using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Q2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Q2.Controllers
{
    [Route("api/student_info")]
    [ApiController]
    public class Q2Controller : Controller
    {
        private readonly ApplicationDbContext _db;

        public Q2Controller(ApplicationDbContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Json(new { data =await _db.student_info.ToListAsync() });
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var student_infoFromDb = await _db.student_info.FirstOrDefaultAsync(u => u.student_id == id);
            if (student_infoFromDb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });
            }
            _db.student_info.Remove(student_infoFromDb);
            await _db.SaveChangesAsync();
            return Json(new { success = true, message = "Delete successful" });
        }
    }
}