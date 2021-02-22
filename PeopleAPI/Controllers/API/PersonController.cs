using PeopleAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PeopleAPI.Controllers.API
{
    public class PersonController : ApiController
    {
        private ApplicationDbContext _context;
        public PersonController()
        {
            _context = new ApplicationDbContext();
        }
        public List<Person> Get()
        {
            var people = _context.People.ToList();
            return people;
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}