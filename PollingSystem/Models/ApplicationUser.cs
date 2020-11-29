using Microsoft.AspNetCore.Identity;

namespace PollingSystem.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
        public bool Sex { get; set; }
        public int Age { get; set; }
    }
}
