using EFMVC.Context;
using EFMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace EFMVC.Controllers
{
    public class SubjectController : Controller
    {
        MVCContext db;

        public SubjectController(MVCContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            IEnumerable<Subject> subjects = db.Subjects.Select(s => s).ToList();
            return View(subjects);
        }
    }
}
