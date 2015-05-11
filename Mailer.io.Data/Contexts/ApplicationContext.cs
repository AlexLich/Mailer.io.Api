using System.Data.Entity;
using Mailer.io.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Mailer.io.Data.Contexts
{
    public class ApplicationContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationContext()
            : base("ApplicationContext")
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}