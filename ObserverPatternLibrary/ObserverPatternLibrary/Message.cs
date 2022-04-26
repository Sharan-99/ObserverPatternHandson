using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLibrary
{
    public class Message
    {
        string messageContent;
     
        public Message(string m)
        {
            this.messageContent = m;
        }

        public string GetMessageContent()
        {
            return messageContent;
        }

    }
}
