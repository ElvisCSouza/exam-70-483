using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exam_70_483
{
    public class MultiThreadingExample
    {

    }

    public class MultiThreadingExampleTest
    {
        public void Test()
        {
            //WriteDot executará em uma Thread separada de WriteO, portanto, paralelamente.
            Thread thread1 = new Thread(WriteRedDot)
            {
                Name = "WriteRedDot",
                Priority = ThreadPriority.Lowest
            };
            Thread thread2 = new Thread(WriteBlueO)
            {
                Name = "WriteBlueO",
                Priority = ThreadPriority.Highest
            };

            Console.WriteLine($"Thread {thread1.Name} iniciando");
            Console.WriteLine($"Prioridade {thread1.Priority}");
            thread1.Start();
            Console.WriteLine($"Thread {thread2.Name} iniciando");
            Console.WriteLine($"Prioridade {thread2.Priority}");
            thread2.Start();

            Console.ReadKey();
        }

        public void WriteRedDot()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(".");
            }
        }

        public void WriteBlueO()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("O");
            }
        }
    }
}
