using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pull_Model_
{
    class ConcreteObserver : Observer
    {
        string observerState;
        ConcreteSubject subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this.subject = subject;
        }

        public override void Update()
        {
            observerState = subject.State;
            Console.WriteLine(observerState);
        }
    }
}
