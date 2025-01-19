namespace HospitalQueue.Models
{
    public class ER_Registration
    {
        public string Key { get; set; } //private field
        public string FullNames { get; set; }    
        public string LastName { get; set; }
        public int ID { get; set; }
        public int PhoneNumber { get; set; } 
        public DateTime DateTime { get; set; } //Will be auto-populated 
        public Dictionary<int, string> ProblemPriority { get; set; }
        public string Description { get; set; }
    }
}
