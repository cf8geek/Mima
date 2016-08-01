using Prism.Commands;
using Prism.Modularity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ShellViewModel
    {

        const string APPLICATION = "This is the PRISM/MEF project demonstration.";

        public ShellViewModel(IModuleManager moduleManager)
        {
            ModuleCommand = new DelegateCommand<object>(o =>
            {
                moduleManager.LoadModule("Module");
            });
        }

        public ShellViewModel()
        {
        }

        public string Title
        {
            get { return APPLICATION; }
        }

        public DelegateCommand<object> ModuleCommand { get; set; }  
    }
}
