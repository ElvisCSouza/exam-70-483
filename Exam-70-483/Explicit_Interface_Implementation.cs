using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public interface IFirst
    {
        void DoSomething();
    }

    public interface ISecond
    {
        int DoSomething();
    }

    public class Explicit_Interface_Implementation : IFirst, ISecond
    {
        public void IFirst.DoSomething()
        {
            throw new NotImplementedException();
        }

        public int ISecond.DoSomething()
        {
            throw new NotImplementedException();
        }
    }

    public class Use_Explicit_Interface_Implementation 
    {
       public void Test()
        {
            var test = new Explicit_Interface_Implementation();
            test.DoSomething();

        }

    }

}
