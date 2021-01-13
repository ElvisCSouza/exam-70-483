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



    class Program
    {
        public static int a = 0;

        static void MetodoDaThread(CancellationToken token)
        {
            
        }

        static void Main(string[] args)
        {

            new AcessarCell().Teste();

            var assembly1 = Assembly.GetAssembly(typeof(ExternalClass));
            var assembly2 = Assembly.GetEntryAssembly();
            var assembly3 = Assembly.GetExecutingAssembly();
            new
                ExternalClass().Teste();

            //checked
            //{
            //    uint b = uint.MaxValue;
            //    uint c = uint.MaxValue;

            //    uint a = b + 1;
            //}


            var test = new HashingExample();
            //Monitor.Enter(test);
            //var tasks = new List<Task>();
            //tasks.Add(Task.Run(() => test.Test())
            //          .ContinueWith(t => t.Result,
            //          TaskContinuationOptions.OnlyOnRanToCompletion));

            lock (test)
            {
                test.Test();
            }

            //NoBreakpoint();
            StringCollection listaString = new StringCollection();
            listaString.Add("Matrix");
            listaString.Add("Senhor dos anéis");

            try
            {

                try
                {
                    throw new AggregateException(new Exception("Erro 1"), new Exception("Erro 2"));
                }
                catch (AggregateException ex)
                {
                    throw ex;
                    ex.Handle((ex2) => VerificarExcecao(ex2));
                }
            }
            catch(AggregateException ex)
            {
                
            }

            HashSet<string> lista = new HashSet<string>();
            lista.Add("diego");
            lista.Add("elvis");
            lista.Add("diego");

            var alinhadoADireita = $"{DateTime.Now, 30:d}";
            var alinhadoAEsquerda = $"{DateTime.Now, -30:d}";

            switch ("1")
            {
                case "1":
                    goto case "2";
                case "2":
                    goto default;
                    break;
                case "3":
                    break;
                default:
                    break;
            }
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
