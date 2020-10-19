using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class MulticastDelegatesExample
    {
        public int Contador = 0;
        public int DoSomething(int x, int y)
        {
            Contador++;
            return 10;
        }

        public int DoAnotherThing(int a, int b)
        {
            Contador++;
            return 1;
        }

        public int DoThat(int a, int b)
        {
            Contador++;
            return 1;
        }
    }

    public class MulticastDelegatesExample_Use
    {
        public delegate int TipoDelegate(int var1, int var2);
        public void TestMethod()
        {
            var example = new MulticastDelegatesExample();
            TipoDelegate del = example.DoSomething;
            //adicionando uma chamada de método ao delegate
            del += example.DoAnotherThing;
            //um método pode ser adicionado mais de uma vez
            del += example.DoAnotherThing;
            del += example.DoSomething;
            del += example.DoSomething;
            del += example.DoThat;
            //removendo uma chamada de método do delegate
            del -= example.DoThat;
            del -= example.DoSomething;

            //resultado será do último método executado (DoAnotherThing)
            int resultado = del(3, 4);
            //Contador será igual a 4, pois:
            //- "DoSomething" foi executado 2 vezes
            //- "DoAnotherThing" foi executado 2 vezes
            //- "DoThat" não foi executado nenhuma vez
        }
    }
}
