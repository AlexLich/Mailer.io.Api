using System.Data.Entity;
using Mailer.io.Models;

namespace Mailer.io.Data.Contexts
{
    public class MailerContext
    {
        public DbSet<Person> Persons { get; set; } 
    }
}