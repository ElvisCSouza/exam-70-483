using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Order;
using Bogus;
using System.Collections;
using System.Collections.Generic;

namespace Exam70_483.Benchmark
{
    [MemoryDiagnoser]
    [Orderer(SummaryOrderPolicy.FastestToSlowest)]
    [RankColumn]
    public class ListsVSArrayList
    {
        public List<string> nList { get; set; }
        public ArrayList ArrayList { get; set; }

        [GlobalSetup]
        public void Setup()
        {
            nList = new List<string>();
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");
            nList.Add("aieuhaiuehiuaheiuaehiua");

            ArrayList = new ArrayList();
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
            ArrayList.Add("aieuhaiuehiuaheiuaehiua");
        }

        [Benchmark]
        public ArrayList Arraylist()
        {
            var novaList = new ArrayList();
            foreach (var list in ArrayList)
                novaList.Add(list);

            return novaList;
        }

        [Benchmark]
        public List<string> List()
        {
            var nList = new List<string>();
            foreach (var list in nList)
                nList.Add(list);

            return nList;
        }

    }
}
