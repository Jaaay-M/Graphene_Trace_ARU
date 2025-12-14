namespace Sensore_Database.Models
{
    public class PatientOverviewViewModel
    {
        public Patient Patient { get; set; }
        public List<int[,]> SensorFrames { get; set; }
    }
}