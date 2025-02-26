using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace HospitalQueue.Models
{
    public class ErRegistration
    {
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        public string FullNames { get; set; } = string.Empty;

        [RegularExpression(@"^\d{1,13}$", ErrorMessage = "Identity Number must be between 1 and 13 digits.")]
        public string IdentityNum { get; set; } = string.Empty;
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        public string LastName { get; set; } = string.Empty;
        [RegularExpression(@"^\d{1,10}$", ErrorMessage = "Phone Number must be between 1 and 10 digits.")]
        public string PhoneNumber { get; set; } = string.Empty;
        public DateTime DateTime { get; set; }

        public List<KeyValuePair<int, string>>? ProblemPriority { get; set; }
        public int SelectedPriority { get; set; }
        public string? Description { get; set; } = string.Empty;
    }
}
