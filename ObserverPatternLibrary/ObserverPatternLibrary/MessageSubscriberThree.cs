using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLibrary
{
    public class MessageSubscriberThree : Observer
    {
        public void Update(Message m)
        {
            Console.WriteLine("MessageSubscriberThree :: " + m.GetMessageContent());
        }
     }
}
