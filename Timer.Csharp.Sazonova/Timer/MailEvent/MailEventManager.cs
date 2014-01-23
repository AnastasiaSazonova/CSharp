using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TimerLib
{
    public class MailEventManager
    {
        #region fields
        private static MailEventManager MailManagerInstance; 
        #endregion

        #region constructor and instance method

        private MailEventManager() { }

        public static MailEventManager GetInstance()
        {
            if (MailManagerInstance == null)
                MailManagerInstance = new MailEventManager();
            return MailManagerInstance;
        }
        
        #endregion

        #region event
        public delegate void MailEventHandler(object sender, MailEventArgs mailArgs);
        public event MailEventHandler MailEvent; 
        #endregion

        #region methods
        public void Register(Observer observer)
        {
            this.MailEvent += delegate(object sender, MailEventArgs mailArgs)
            {
                observer.SetMessage(mailArgs.message);
            };
        }

        public void SendMsg(string mail)
        {
            NotifyObservers(this, new MailEventArgs(mail));
        }

        protected virtual void NotifyObservers(object sender, MailEventArgs mailArgs)
        {
            if (MailEvent != null)
            {
                MailEvent(sender, mailArgs);
            }
        } 
        #endregion
      
    }
}
