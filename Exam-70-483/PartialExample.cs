using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_70_483
{
    public class Cell
    {
        public string Nome { get; set; }
    }

    public class AcessarCell
    {
        public void Teste()
        {
            var a = new Cell();
            a.Nome = "albin";

            dynamic b = a;
            b.Nome = "outra coisa";

            Object c = a;
            ((Cell)c).Nome = "daiego";

            Console.WriteLine(a.Nome);
            Console.WriteLine(((Cell)c).Nome);
            Console.ReadKey();


            var lista = new List<string>().AsParallel();
        }
    }

}
