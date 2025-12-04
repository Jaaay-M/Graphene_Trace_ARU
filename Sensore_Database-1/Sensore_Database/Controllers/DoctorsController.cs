using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sensore_Database.Data;
using Sensore_Database.Models;

namespace Sensore_Database.Controllers
{
    public class DoctorsController : Controller
    {
        private readonly AppDBContext appDBContext;
        public DoctorsController(AppDBContext context)
        {
            appDBContext = context;
        }
        public async Task<IActionResult> Index()
        {
            var Doctor = await appDBContext.Doctors.ToListAsync();
            return View(Doctor);
        }
        [HttpPost]
        public async Task<IActionResult> AddDoctor(Doctor Doctor)
        {
            appDBContext.Add(Doctor);
            await appDBContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult AddDoctor()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreatePatient(Patient patient)
        {
            appDBContext.Add(patient);
            await appDBContext.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public IActionResult CreatePatient()
        {
            return View();
        }
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
