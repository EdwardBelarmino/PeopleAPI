using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PeopleAPI.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }
        public int? Number { get; set; }
        public int? Temperature { get; set; }
        public DateTime TodayDate { get; set; }
        public string Visited { get; set; }



    }
}