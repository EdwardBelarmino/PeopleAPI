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
        public Person Get(int id)
        {
            var person = _context.People.Where(a => a.Id == id).SingleOrDefault();
            return person;
        }

        // POST api/<controller>
        public void Post([FromBody] Person personToAdd)
        {
            _context.People.Add(personToAdd);
            _context.SaveChanges();

        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] Person person)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
            var person = _context.People.Where(a => a.Id == id).SingleOrDefault();
            _context.People.Remove(person);
            _context.SaveChanges();
        }
    }
}