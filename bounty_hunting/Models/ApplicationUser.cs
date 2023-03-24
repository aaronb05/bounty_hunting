using Microsoft.AspNetCore.Identity;


namespace bounty_hunting.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Status { get; set; }


        public virtual ICollection<IdentityRole> Roles { get; set; }
    }
}
