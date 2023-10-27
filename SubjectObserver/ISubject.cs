using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverDesignPattern.SubjectClass.Subject
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);

        // Remove or unregister an observer from the subject.
        void RemoveObserver(IObserver observer);

        // Notify all registered observers when the state of the subject is changed.
        void NotifyObservers();
    }
}
