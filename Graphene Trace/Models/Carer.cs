namespace Graphene_Trace.Models
{
    public class Carer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Relationship { get; set; }
        public string ContactNumber { get; set; }
        public string Assignedpatient { get; set; } = string.Empty;
}
}
