using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class EventDTO : EventArgs
    {
        public decimal Price { get; set; }
        public bool Available { get; set; }
    }
    public class Event2Publisher
    {
        public EventHandler eventoSemParametro;
        public EventHandler<EventDTO> eventoComParametro;

        public void CheckSomething(bool valid)
        {
            if (!valid)
            {
                eventoSemParametro(this, EventArgs.Empty);
                eventoComParametro(this, new EventDTO()
                {
                    Available= true, 
                    Price = 1M
                });
            }
        }
    }

    public class Event2Subscriber
    {
        //A assinatura do Handle deve bater com o delegate EventHandler (aperta F12 na classe EventHandler)
        public void HandleTheEvent(object sender, EventArgs e)
        {
            Console.WriteLine(sender + " is invalid");
        }

        public void HandleTheEventWithParameters(object sender, EventDTO dto)
        {
            Console.WriteLine(sender + " is invalid. The price is " + dto.Price);
        }
    }

    public class Event2Test
    {
        public void Test()
        {
            Event2Publisher publisher = new Event2Publisher();

            Event2Subscriber subscriber = new Event2Subscriber();

            publisher.eventoSemParametro += subscriber.HandleTheEvent;
            publisher.eventoComParametro += subscriber.HandleTheEventWithParameters;

            //O Handle será executado
            publisher.CheckSomething(false);

            //O Handle não será executado
            publisher.CheckSomething(true);
        }
    }
}
