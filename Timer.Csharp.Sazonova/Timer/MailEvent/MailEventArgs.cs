using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerLib
{
    public sealed class MailEventArgs:EventArgs
    {
        public readonly string message;

        public MailEventArgs(string Message) 
        {
            this.message = Message;
        }

        public string Message 
        { 
            get
            { 
                return message;
            } 
        }
    }
}
