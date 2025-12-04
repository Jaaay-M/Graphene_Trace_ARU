using Sensore_Database.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sensore_Database.Models;

namespace Sensore_Database.Controllers
{
    public class PatientsController : Controller
    {
        private readonly AppDBContext appDBContext; 
        public PatientsController(AppDBContext context)
        {
            appDBContext = context;
        }
        public async Task<IActionResult> Index()
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
        }

        /* public IActionResult Index()
         {
             return View();
         }*/
    }
}
