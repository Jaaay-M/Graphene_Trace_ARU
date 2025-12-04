namespace Sensore_Database.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Patient> Patients { get; set; } = new List<Patient>();

        public List<Feedback> FeedbacksGiven { get; set; } = new List<Feedback>();
    }
    

}
