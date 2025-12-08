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

        public ActionResult DoctorNotes()
        {
            return View("Doctor-Notes");
        }

        public IActionResult PatientOverview(int id)
        {
            var patient = appDBContext.Patients.FirstOrDefault(p => p.Id == id);

        if (patient == null)
            return NotFound();

            return View("Patient-Overview");
        }
    }
}
