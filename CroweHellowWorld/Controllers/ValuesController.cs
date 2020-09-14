using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HWDomain;

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
        public IEnumerable<string> Get(int id)
        {
            List<string> hwList = new List<string>();
            //use this one to interact with the database, and create a POCO class that can be used for EF
            if (id.Equals(0))
            {
                using (CroweHellowWorldDBEntities entities = new CroweHellowWorldDBEntities())
                {
                    var slist = entities.HWs.ToList();

                    foreach(var item in slist)
                    {
                        hwList.Add(item.Name);

                    }

                    return hwList;
                } 
            }
            else
            {
                using (CroweHellowWorldDBEntities entities = new CroweHellowWorldDBEntities())
                {
                    var chw= entities.HWs.FirstOrDefault(p=>p.ID==id);
                    hwList.Add(chw.Name);
                }
                return hwList;
            }
                
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
