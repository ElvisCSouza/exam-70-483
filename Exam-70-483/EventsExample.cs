using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class EventPublisher
    {
        public delegate void someDelegate(string test);
        public event someDelegate evento;

        public void CheckSomething(bool valid)
        {
            if(!valid)
                evento("Something is invalid!");
        }
    }

    public class EventSubscriber
    {
        public void HandleTheEvent(string textMessage)
        {
            Console.WriteLine(textMessage);
        }
    }

    public class EventTest
    {
        public void Test()
        {
            EventPublisher publisher = new EventPublisher();

            EventSubscriber subscriber = new EventSubscriber();

            publisher.evento += subscriber.HandleTheEvent;

            //O Handle será executado
            publisher.CheckSomething(false);

            //O Handle não será executado
            publisher.CheckSomething(true);
        }
    }
}
