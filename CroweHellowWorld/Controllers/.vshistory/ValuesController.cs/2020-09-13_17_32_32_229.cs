using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CroweHellowWorld.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        //public IEnumerable<string> Get()
        public IEnumerable<string> Get()
        {
            return new string[] { "Hello", "World" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            //use this one to interact with the database, and create a POCO class that can be used for EF
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
