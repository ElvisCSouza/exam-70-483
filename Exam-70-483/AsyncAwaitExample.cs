using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Exam_70_483
{
    public class AsyncAwaitExample
    {
        public void Test()
        {
            Thread.CurrentThread.Name = "MT";
            //DoStuff();
            DoStuff().Wait();

            for (int i = 0; i < 5001; i++)
            {
                Console.WriteLine($"MT { i } - { Thread.CurrentThread.Name }");
            }

        }

        public async Task DoStuff()
        {
            //CountTo(5000);

            await Task.Run(() =>
            {
                Thread.CurrentThread.Name = "BG";
                CountTo(5000).Wait();
            });

            //Task.Run(() =>
            //{
            //    Thread.CurrentThread.Name = "BG";
            //    CountTo(5000);
            //});

            //await CountTo(5000);

            //Isso não será executado até o CountTo finalizar
            Console.WriteLine("Counting to is completed");
        }

        public async Task<string> CountTo(int number)
        {
            for (int i = 0; i <= number; i++)
            {
                Console.WriteLine($"BG: { i } - { Thread.CurrentThread.Name }");
            }

            return number.ToString();
        }
        
    }
}
