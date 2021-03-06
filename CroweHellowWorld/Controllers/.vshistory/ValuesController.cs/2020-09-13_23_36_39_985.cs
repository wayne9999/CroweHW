﻿using System;
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
        public IEnumerable<HW> Get(int id)
        {
            //use this one to interact with the database, and create a POCO class that can be used for EF
            if (id.Equals(0))
            {
                using (CroweHellowWorldDBEntities entities = new CroweHellowWorldDBEntities())
                {
                    return entities.HWs.ToList();
                } 
            }
            else
            {
                List<HW> hwList = new List<HW>();
                using (CroweHellowWorldDBEntities entities = new CroweHellowWorldDBEntities())
                {
                    var chw= entities.HWs.FirstOrDefault(p=>p.ID==id);
                    hwList.Add(chw);
                    //var chwlist = entities.HWs.ToList(); ;
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
