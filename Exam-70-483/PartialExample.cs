using System;
using System.Collections.Generic;
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


 
}
