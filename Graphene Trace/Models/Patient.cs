namespace Graphene_Trace.Models
{
    public class Patient
    {
        public int PatientId { get; set; }
        public string doctor_id { get; set; }
        public string carer_id { get; set; }
        public enum title { Mr, Mrs, Miss, Ms, Dr, Prof }
        public string first_name { get; set; } 
        public string last_name { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }

    }
}
