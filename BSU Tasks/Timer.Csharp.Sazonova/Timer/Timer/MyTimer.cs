using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TimerLib
{
    public class MyTimer
    {
        #region fields
        private int timeOut;
        private string message;
        private static int remainingTime; 
        #endregion

        #region constructors
        public MyTimer(int Seconds, string Message)
        {
            if (Seconds <= 0 || Seconds.ToString() == "")
                throw new ArgumentException("Time must be greater than zero.");
            if (Message == null)
                throw new ArgumentException("Message is null.");
            this.timeOut = Seconds;
            this.message = Message;
            remainingTime = timeOut;
        }
        public MyTimer(MyTimer timer)
        {
            if (timer.TimeOut <= 0)
                throw new ArgumentException();
            if (timer.Message == null)
                throw new ArgumentException();
            this.timeOut = timer.TimeOut;
            this.message = timer.Message;
            remainingTime = timeOut;
        }       
        #endregion

        #region properties
        public string Message { get { return this.message; } }
        public int TimeOut { get { return this.timeOut; } }
        #endregion

        #region methods
        public void SetTimer(int Seconds, string Message)
        {
            if (Seconds <= 0)
                throw new ArgumentException("Time must be greater than zero.");
            if (Message == null)
                throw new ArgumentException("Message is null.");
            this.timeOut = Seconds;
            this.message = Message;
            remainingTime = timeOut;
            Start();
        }

        public void Start()
        {
            TimeCounting();
            SendingMessage(this.message);
        }

        private void TimeCounting()
        {
            while (remainingTime > 0)
            {
                MinusOne();
            }
        }

        private void MinusOne()
        {
            Thread.Sleep(1000);
            remainingTime -= 1000;
        }

        private void SendingMessage(string Message)
        {
            var mail = MailEventManager.GetInstance();
            mail.SendMsg(Message);
        }

        public override string ToString()
        {
            return string.Format("Remaining time: {0}", remainingTime / 1000);
        } 
        #endregion

    }
} 
