using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Mailer.io.Services;

namespace Mailer.io.Api.Controllers
{
    public class ContactController : ApiController
    {
        private readonly IContactService contactService;

        public ContactController(IContactService contactService)
        {
            this.contactService = contactService;
        }

        public IHttpActionResult Get()
        {
            var persons = contactService.GetPersons();
            return Ok(persons);
        }

        public IHttpActionResult Get(int id)
        {
            var person = contactService.GetPerson(id);
            return Ok(person);
        }
    }
}
