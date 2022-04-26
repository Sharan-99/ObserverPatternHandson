using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternLibrary;

namespace ObserverClient
{
    class Program
    {
        static void Main(string[] args)
        {
            MessageSubscriberOne s1 = new MessageSubscriberOne();
            MessageSubscriberTwo s2 = new MessageSubscriberTwo();
            MessageSubscriberThree s3 = new MessageSubscriberThree();

            MessagePublisher p = new MessagePublisher();

            p.Attach(s1);
            p.Attach(s2);

            p.Attach(s3);

            p.NotifyUpdate(new Message("Message...Hi!!"));   //s1 and s2 will receive the update

            p.Detach(s2);
            p.NotifyUpdate(new Message("Message...Hello!"));
            p.Detach(s3);
            p.Attach(s2);
            p.NotifyUpdate(new Message("Message...Welcome!")); //s2 and s3 will receive the update

            Console.ReadKey();
        }

    }
}

