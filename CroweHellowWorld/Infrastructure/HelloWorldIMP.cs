using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CroweHellowWorld.Infrastructure
{
    public class HelloWorldIMP : IHelloWorld
    {
        public IEnumerable<string> GetByID(string ID)
        {
            throw new NotImplementedException();
        }
    }
}