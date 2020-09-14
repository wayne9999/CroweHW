using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHellowWorld.Infrastructure
{
    public interface IHelloWorld
    {
        IEnumerable<string> GetByID(string ID);


    }
}
