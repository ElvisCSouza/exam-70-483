//#if (DEBUG)
//    #define DIEGO
//#endif
using Exam_70_483.Value_and_Reference_Type;
using ExternalClassLibrary;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam_70_483
{
    //Recomendação da Microsoft sobre criar uma classe de exceção
    public class MinhaExcecao : Exception
    {
        public MinhaExcecao() : base()
        {

        }

        public MinhaExcecao(string a) : base(a)
        {

        }

        public MinhaExcecao(string a, Exception exception) : base(a, exception)
        {

        }
    }

    class MeuFormato : IFormatProvider, ICustomFormatter
    {
        public int MyProperty { get; set; }

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            return $"MinhaFormatacao: {format}";
        }

        public object GetFormat(Type formatType)
        {
            return "";
        }
    }


    public class ErrorEventArgs : EventArgs
    {
        public int MyProperty { get; set; }

        public ErrorEventArgs(int myProperty)
        {
            MyProperty = myProperty;
        }
    }

    class Program
    {
        public static int a = 0;

        static void MetodoDaThread(CancellationToken token)
        {

        }

        enum Categories
        {
            a = -1,
            B,
            C,
            D,
            E
        }

        class Mess
        {
            public void Log()
            {
                Console.WriteLine("hhhh");
            }
        }

        class teste
        {
            public void Log(dynamic log)
            {
                log.Log();
            }
        }

        void Executar()
        {

        }

        public delegate string Combine(string s1, string s2);
        

        static void Main(string[] args)
        {


            var tasks = new Task((a) => { return a.a; }, new Mess() { a = "1" });
            for (int i = 0; i < 10; i++)
            {

            }
            
            Action<int> func = (int a) => { return; };
            Combine combine = delegate(string a, string b) { return a; };
            Combine combinea = (a, b) => { return a; };


            var mes = new Mess();
            new teste().Log(mes);

               var lista = new List<string>() { "1", "2", "3", "4" };

            try
            {
                lista
                            .AsParallel()
                            .ForAll((x) =>
                            {
                                throw new Exception(x);
                            });
            }
            catch (AggregateException ex)
            {
            }

            for (int i = 0; i < 100; i++)
            {
                var thread = new Thread(() =>
                {
                    Console.WriteLine(Thread.CurrentThread.Name);
                });
                thread.Name = i.ToString();
                thread.Start();
            }

//#if (ELVIS)
//            Console.WriteLine("ELVIS");
//#endif
//#if (ALO)
//            Console.WriteLine("ALO");
//#endif
//#if (DIEGO)
//            Console.WriteLine("DIEGO");
//#endif
//#if (TRACE)
//            Console.WriteLine("TRACE");
//            #endif
//            #if (RELEASE)
//                        Console.WriteLine("RELEASE");
//            #endif
//            #if (DEBUG)
//                Console.WriteLine("DEBUG");
//            #endif


            Console.ReadLine();

            //var a = new ThreadSleepExample();
            ////a.Teste();
            ////var assembly1 = Assembly.GetAssembly(typeof(ExternalClass));
            ////var assembly2 = Assembly.GetEntryAssembly();
            ////var assembly3 = Assembly.GetExecutingAssembly();
            ////new
            ////    ExternalClass().Teste();

            ////checked
            ////{
            ////    uint b = uint.MaxValue;
            ////    uint c = uint.MaxValue;

            ////    uint a = b + 1;
            ////}


            //var test = new HashingExample();
            ////Monitor.Enter(test);
            ////var tasks = new List<Task>();
            ////tasks.Add(Task.Run(() => test.Test())
            ////          .ContinueWith(t => t.Result,
            ////          TaskContinuationOptions.OnlyOnRanToCompletion));

            //lock (test)
            //{
            //    test.Test();
            //}

            ////NoBreakpoint();
            //StringCollection listaString = new StringCollection();
            //listaString.Add("Matrix");
            //listaString.Add("Senhor dos anéis");

            //try
            //{

            //    try
            //    {
            //        throw new AggregateException(new Exception("Erro 1"), new Exception("Erro 2"));
            //    }
            //    catch (AggregateException ex)
            //    {
            //        throw ex;
            //        ex.Handle((ex2) => VerificarExcecao(ex2));
            //    }
            //}
            //catch (AggregateException ex)
            //{

            //}

            //HashSet<string> lista = new HashSet<string>();
            //lista.Add("diego");
            //lista.Add("elvis");
            //lista.Add("diego");

            //var alinhadoADireita = $"{DateTime.Now,30:d}";
            //var alinhadoAEsquerda = $"{DateTime.Now,-30:d}";

            //switch ("1")
            //{
            //    case "1":
            //        goto case "2";
            //    case "2":
            //        goto default;
            //        break;
            //    case "3":
            //        break;
            //    default:
            //        break;
            //}
        }

        [DebuggerHidden]
        static void NoBreakpoint()
        {

        }

        static bool VerificarExcecao(Exception ex)
        {
            return false;
        }

    }
    public class Solar
    {
        public static IEnumerable<string> Pah
        {
            get
            {
                yield return "1";
                yield return "2";
                yield return "3";
                yield return "4";
            }
        }
    }
}
