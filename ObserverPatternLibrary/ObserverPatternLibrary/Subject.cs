using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternLibrary
{
    public interface Subject
    {
       void Attach(Observer o);
       void Detach(Observer o);
       void NotifyUpdate(Message m);

        void ChangeState(object state);

    }
}
