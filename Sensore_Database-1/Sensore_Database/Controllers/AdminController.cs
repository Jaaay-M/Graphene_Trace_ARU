 using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sensore_Database.Data;
using Sensore_Database.Models;

namespace Sensore_Database.Controllers
{
    public class AdminController : Controller
    {
        private readonly AppDBContext appDBContext;
        public AdminController(AppDBContext context)
        {
            appDBContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var Doctor = await appDBContext.Doctors.ToListAsync();
            return View(Doctor);
        }
        [HttpPost]
        public async Task<IActionResult> CreateDoctor(Doctor doctor)
        {
            appDBContext.Add(doctor);
            await appDBContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult CreateDoctor()
        {
            return View();
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
