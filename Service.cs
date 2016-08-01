using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
        [Export(typeof(IService))]
        public class Service : Demo.Common.IService
        {
            public void GetStuff(Action<List<string>> action)
            {
                action(new List<string> { "One", "One", "Two", "Three", "Five", "Eight", "Thirteen" });
            }

             public void GetMoreStuff(Action<List<string>> action)
            {
                action(new List<string> { "Uno", "Uno", "Dos", "Tres", "Cinco", "Ocho", "Trece" }); 
            }

        }
            }
}
