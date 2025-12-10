using Sensore_Database.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sensore_Database.Models;
using Sensore_Database.Services;

namespace Sensore_Database.Controllers
{
    public class PatientsController : Controller
    {
        private readonly AppDBContext appDBContext; 
        private readonly SensorCsvParser _parser;
        
        public PatientsController(AppDBContext context, SensorCsvParser parser)
        {
            appDBContext = context;
            _parser = parser;
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

        public async Task<IActionResult> PatientOverview(int id)
        {
            var patient = await appDBContext.Patients.FirstOrDefaultAsync(p => p.Id == id);
            if (patient == null)
                return NotFound();

            // Expected CSV path — adjust if needed
            string csvPath = Path.Combine("wwwroot/sensor_data", $"{id}.csv");

            List<int[,]> frames = System.IO.File.Exists(csvPath)
            ? _parser.ParseFrames(csvPath)
            : new List<int[,]>();

            var vm = new PatientOverviewViewModel
            {
                Patient = patient,
                SensorFrames = frames
            };

            return View("PatientOverview", vm);
        }
    }
}
