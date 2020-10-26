using BenchmarkDotNet.Running;
using System;

namespace Exam70_483.Benchmark
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListsVSArrayList>();
            Console.Read();
        }
    }
}
