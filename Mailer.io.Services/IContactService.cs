using System.Collections.Generic;
using Mailer.io.Models;

namespace Mailer.io.Services
{
    public interface IContactService
    {
        IEnumerable<Person> GetPersons();
        Person GetPerson(int id);
    }
}