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
            var Patient = await appDBContext.Patients.ToListAsync();
            return View(Patient);
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
        /*public async Task<IActionResult> PatientsList()
        {
            var patients = await appDBContext.Patients.ToListAsync();
            return View(patients);
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
        }*/
        /*public IActionResult Index()
        {
            return View();
        }*/
    }
}
