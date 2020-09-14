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
        public string Get()
        {
            //. {"name":"value"}) 
            //            var userlist = [{ "user":{ "name":"Manas","gender":"Male","birthday":"1987-8-8"} },    
            //{ "user":{ "name":"Mohapatra","Male":"Female","birthday":"1987-7-7"} }]   
            string json = @"{  
            'name': 'Hello'},{'name':'World'}";
            return json;
            //return new string[] { "Hello", "World" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            
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
