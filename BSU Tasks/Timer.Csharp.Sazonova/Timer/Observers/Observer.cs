using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimerLib
{
    public interface Observer
    {
        void SetMessage(string message);
        string DisplayMessage();
    }
}
