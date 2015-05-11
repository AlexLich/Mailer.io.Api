using System.Collections.Generic;
using Mailer.io.Data.Repositories;
using Mailer.io.Models;

namespace Mailer.io.Services
{
    public class ContactService : IContactService
    {
        private readonly IPersonRepository personRepository;
        public ContactService(IPersonRepository personRepository)
        {
            this.personRepository = personRepository;
        }

        public IEnumerable<Person> GetPersons()
        {
            return personRepository.GetPersons();
        } 
    }
}