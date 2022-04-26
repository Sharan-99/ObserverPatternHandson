using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLibrary
{
    public class MessagePublisher:Subject
    {
        private List<Observer> observers = new List<Observer>();
        public void Attach(Observer o)
        {
            observers.Add(o);
            ChangeState(o);
        }
        public void Detach(Observer o)
        {
            observers.Remove(o);
            ChangeState(o);
        }
        public void NotifyUpdate(Message m)
        {
            foreach(Observer o in observers)
            {
                o.Update(m);
            }
        }
        public void ChangeState(object state)
        {
            NotifyUpdate(new Message("Change in state is done"));
        }

    }
}
