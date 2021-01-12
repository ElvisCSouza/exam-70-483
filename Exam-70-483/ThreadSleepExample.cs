using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exam_70_483
{

    public class ThreadSleepExample
    {
        public void Teste()
        {
            var thread1 = new Thread(Executar);
            var thread2 = new Thread(Executar);



            thread1.Start("1");
            thread2.Start("2");

            Console.ReadKey();
        }

        public void Executar(object a)
        {
            int i = 0;
            while (true)
            {
                if (a == "1")
                    Thread.Sleep(0);

                Console.WriteLine(a + ": " + i);
                Thread.Sleep(100);
                i++;
            }
        }
    }
}
