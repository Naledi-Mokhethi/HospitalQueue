using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace HospitalQueue.Models
{
    public class ErRegistration
    {
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        public string? FullNames { get; set; }
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        public  string? LastName { get; set; }
        public  int? ID { get; set; }
        public  int? PhoneNumber { get; set; }
        public DateTime DateTime { get; set; }

        public List<KeyValuePair<int, string>>? ProblemPriority { get; set; }
        public int SelectedPriority { get; set; }
        public string? Description { get; set; }
    }
}
