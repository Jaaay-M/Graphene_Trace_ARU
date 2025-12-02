using Microsoft.AspNetCore.Mvc;

namespace Graphene_Trace.Controllers
{
    public class PatientController : Controller
    {
        public ActionResult DoctorNotes()
        {
            return View("Doctor-Notes");
        }

        public ActionResult PatientOverview()
        {
            return View("Patient-Overview");
        }
    }
}
