using Microsoft.AspNet.Identity.EntityFramework;

namespace Mailer.io.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
//        public string Email { get; set; }
    }
}