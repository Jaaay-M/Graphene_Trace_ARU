namespace Sensore_Database.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string MedicalHistory { get; set; }
        public int? DoctorId { get; set; }
        public Doctor PrimaryDoctor { get; set; }

        public List<Feedback> Feedbacks { get; set; } = new List<Feedback>();


    }
}
