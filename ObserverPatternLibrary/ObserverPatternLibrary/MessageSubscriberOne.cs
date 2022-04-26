using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLibrary
{
    public class MessageSubscriberOne:Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberOne :: " + m.GetMessageContent());
        }

    }
}
