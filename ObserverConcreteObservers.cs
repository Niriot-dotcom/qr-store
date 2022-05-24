using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3P_PatyLopez
{
    // Concrete Observers react to the updates issued by the Subject they had
    // been attached to.
    class ConcreteObserverA : IObserver
    {
        public void Update(ISubject subject)
        {            
            if ((subject as Subject).Checkbox == "A")
            {
                if ((subject as Subject).CheckState)
                {
                    Console.WriteLine("adding to txt file...");
                }
                else
                {
                    Console.WriteLine("no more to txt file...");
                }
            }
        }
    }

    class ConcreteObserverB : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).Checkbox == "B")
            {
                if ((subject as Subject).CheckState)
                {
                    Console.WriteLine("adding to text box...");
                }
                else
                {
                    Console.WriteLine("no more to text box...");
                }
            }
        }
    }

    class ConcreteObserverC : IObserver
    {
        public void Update(ISubject subject)
        {
            if ((subject as Subject).Checkbox == "C")
            {
                if ((subject as Subject).CheckState)
                {
                    Console.WriteLine("adding to grid...");
                }
                else
                {
                    Console.WriteLine("no more to grid...");
                }
            }
        }
    }
}
