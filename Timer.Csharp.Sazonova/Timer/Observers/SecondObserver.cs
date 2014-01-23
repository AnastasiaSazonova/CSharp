using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerLib
{
    public class SecondObserver : Observer
    {
        private string message;

        public void SetMessage(string Message)
        {
            this.message = Message;
        }

        public string DisplayMessage()
        {
            if (this.message != null)
                return string.Format("Second observer's message: {0}", this.message);
            else
                return null;
        }
    }
}
