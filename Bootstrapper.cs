using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Bootstrapper
    {
        private AssemblyCatalog catalog;

        public Bootstrapper()
        {
            Compose();
        }

        private void Compose()
        {
            AssemblyCatalog catalog = new AssemblyCatalog(System.Reflection.Assembly.GetExecutingAssembly());
            CompositionContainer container = new CompositionContainer(catalog);
            //container.SatisfyImportsOnce(catalog.CreateCompositionService());
        }

    }
}
