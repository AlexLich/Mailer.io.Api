using System.Collections.Generic;
using System.Linq;
using Mailer.io.Data.Contexts;
using Mailer.io.Models;

namespace Mailer.io.Data.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly ApplicationContext context;

        public PersonRepository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<Person> GetPersons()
        {
            return context.Persons.ToList();
        }

        public Person GetPerson(int id)
        {
            return context.Persons.FirstOrDefault(x => x.PersonId == id);
        }
    }
}