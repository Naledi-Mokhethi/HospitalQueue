namespace HospitalQueue.Models
{
    public class ER_Registration
    {
     //   private int Key { get; set; } //private field
        public string? FullNames { get; set; }    
        public string? LastName { get; set; }
        public int? ID { get; set; }
        public int? PhoneNumber { get; set; } 
        public DateTime DateTime
        { 
            get { return DateTime; } 
            set { DateTime = DateTime.Now; }
        }   
        public List<KeyValuePair<int, string>> ProblemPriority { get; set; }
        public int SelectedPriority { get; set; }
        public string? Description { get; set; }
    }
}
