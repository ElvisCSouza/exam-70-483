using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exam70_483.Benchmark
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class SingleLineJoin
    {
        public string string1 = "a";
        public string string2 = "b";
        public string string3 = "c";
        public string string4 = "d";
        public string string5 = "e";

        public List<string> stringList;


        [GlobalSetup]
        public void Setup()
        {
            stringList = new List<string> { string1, string2, string3, string4, string5 };
        }

        [Benchmark]
        public string Interpolation()
        {
            return $"{string1} {string2} {string3} {string4} {string5}";
        }

        [Benchmark]
        public string PlusOperator()
        {
            return string1 + " " + string2 + " " + string3 + " " + string4 + " " + string5;
        }

        [Benchmark]
        public string StringConcatenate()
        {
            return string.Concat(string1, " ", string2, " ", string3, " ", string4, " ", string5);
        }

        [Benchmark]
        public string StringJoin()
        {
            return string.Join(" ", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringFormat()
        {
            return string.Format("{0} {1} {2} {3} {4}", string1, string2, string3, string4, string5);
        }

        [Benchmark]
        public string StringBuilderAppend()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(string1);
            builder.Append(" ");
            builder.Append(string2);
            builder.Append(" ");
            builder.Append(string3);
            builder.Append(" ");
            builder.Append(string4);
            builder.Append(" ");
            builder.Append(string5);
            return builder.ToString();
        }

        [Benchmark]
        public string PlusOperatorWithResult()
        {
            var result = string1 + " ";
            result += string2 + " ";
            result += string3 + " ";
            result += string4 + " ";
            result += string5 + " ";
            return result;
        }

        [Benchmark]
        public string StringJoinList()
        {
            return string.Join(" ", stringList);
        }

        private void teste()
        {
            var a = "";
            a = "Diego";
            a += "Galante";
            var b = a;

            //Memória
            //var lixo = "";
            //lixo = "Diego";
            //"Diego Galante";
            //"Diego Galante";

            StringBuilder strbA = new StringBuilder();
            strbA.Append("Diego");
            strbA.Append("Galante");
            StringBuilder strbB = strbA;

            var c = $"{ a } { b }";




        }
    }
}
