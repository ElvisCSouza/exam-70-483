using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class DelegatesExample
    {
        public int DoSomething(int x, int y)
        {
            return 0;
        }

        public int DoAnotherThing(int a, int b)
        {
            return 1;
        }
    }

    public class DelegatesExemplo_Use
    {
        public delegate int TipoDelegate(int var1, int var2);
        public void TestMethod()
        {
            var example = new DelegatesExample();
            TipoDelegate del = example.DoSomething;
            int resultado = del(1, 2);
            //um delegate pode ser usado para executar mais de um método
            del = example.DoAnotherThing;
            int resultado2 = del(3, 4);
        }
    }
}
