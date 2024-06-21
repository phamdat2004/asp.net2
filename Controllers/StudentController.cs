using Microsoft.AspNetCore.Mvc;

namespace Formthongtin.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult DangNhap() { return View(); }
    }
}
