using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_70_483
{
    partial class Partial1
    {
        partial void Teste1();
        partial void Teste2(string a);
    }


    partial class Partial1
    {
        partial void Teste1()
        {
            Console.WriteLine("1");
        }
    }

    partial class Partial1
    {
        partial void Teste2(string a)
        {
            Console.WriteLine("1");
        }
    }


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
