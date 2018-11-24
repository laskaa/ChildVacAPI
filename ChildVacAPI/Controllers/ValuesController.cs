using System;
using System.Collections.Generic;
using System.Linq;
using ChildVacAPI.Services;
using ChildVacAPI.Repositories;
using ChildVacAPI.Models;
using ChildVacAPI.Context; 
using Microsoft.AspNetCore.Mvc;

namespace ChildVacAPI.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        List<string> values = new List<string>() { "value1", "value2", "213" };
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return values;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value" + id;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]string value)
        {
            values.Add(value);
            int a = values.Count();
            a = 0; 
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
