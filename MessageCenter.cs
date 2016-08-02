using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;


namespace Demo
{

    [Export(typeof(Demo.Common.IMessageCenter))]
    public class MessageCenter : Demo.Common.IMessageCenter
    {

        public string SendMessage()
        {
            return "This is an awesome default message.";
        }
    }
}
