using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TimerLib;

namespace Events.Csharp.Sazonova
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var first = new FirstObserver();
                var second = new SecondObserver();
                var mail = MailEventManager.GetInstance();
                mail.Register(first);
                mail.Register(second);

                Console.WriteLine("Enter timeout: ");
                int timeOut = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter message: ");
                string message = Console.ReadLine();
                timeOut *= 1000;

                var timer = new MyTimer(timeOut, message);
                timer.Start();

                Console.WriteLine(first.DisplayMessage());
                Console.WriteLine(second.DisplayMessage());
                //timer.SetTimer(timeOut, "hello");
                //Console.WriteLine(first.DisplayMessage());
                //Console.WriteLine(second.DisplayMessage());
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}
