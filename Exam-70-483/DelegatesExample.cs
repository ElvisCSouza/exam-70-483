using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public static class DelegatesExample
    {
        public static int DoSomething(int x, string y)
        {
            return 0;
        }

        public static int DoAnotherThing(int a, string b)
        {
            return 1;
        }

        public static bool DoIt(int a, string b)
        {
            return true;
        }

        public static int DoThat(int a)
        {
            return 2;
        }
    }

    public class DelegatesExemplo_Use
    {
        public delegate int TipoDelegate(int var1, string var2);
        public void Test()
        {
            TipoDelegate del;
            del = DelegatesExample.DoSomething;
            int resultado = del(1, "2");
            //um delegate pode ser usado para executar mais de um método
            del = DelegatesExample.DoAnotherThing;
            int resultado2 = del(3, "4");
        }
    }
}
