using System.Collections.Generic;
using Mailer.io.Models;

namespace Mailer.io.Data.Repositories
{
    public interface IPersonRepository
    {
        IEnumerable<Person> GetPersons();
        Person GetPerson(int id);
    }
}