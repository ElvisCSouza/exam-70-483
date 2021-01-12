using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Exam_70_483
{
    public class ClasseX
    {
        public Guid Valor { get; set; }
        public ClasseX()
        {
            Valor = Guid.NewGuid();
        }
    }

    public class ClasseY
    {
        public static ThreadLocal<ClasseX> nome { get; set; }
        public Guid Valor { get; set; }
        public ClasseY()
        {
            nome = new ThreadLocal<ClasseX>(() => new ClasseX());
        }

        public Guid Acessar()
        {
            return nome.Value.Valor;
        }
    }

    public class ThreadLocalExample
    {
        public void Teste()
        {
            var a = new ClasseY();
            var b = new ClasseY();

            Console.WriteLine(a.Acessar());
            Console.WriteLine(b.Acessar());

            var thread1 = new Thread(Executar);
            thread1.Start(a);
            var thread2 = new Thread(Executar);
            thread2.Start(a);

            Console.ReadKey();
        }

        public void Executar(object a)
        {
            Console.WriteLine(((ClasseY)a).Acessar());
        }
    }
}
