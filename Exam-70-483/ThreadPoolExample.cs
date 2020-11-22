using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_70_483
{
    public class ThreadPoolExample
    {
        public void Test()
        {
            Thread thread1 = new Thread(Count);
            thread1.Start();

            //Pela task, por padrão, ser uma Background Thread, quando a Thread1 (que é uma Foreground thread) terminar, a task será finalida.
            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(500);
                    Console.Write("T ");
                }
            });
        }

        public void Count()
        {
            for (int i = 0; i < 4; i++)
            {
                Thread.Sleep(500);
                Console.Write("FG ");
            }
        }

    }
}
