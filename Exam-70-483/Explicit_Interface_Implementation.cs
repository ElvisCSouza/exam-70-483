using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public interface IFirst
    {
        void DoSomething();
        void DoThat();
    }

    public interface ISecond
    {
        void DoSomething();
        void DoThat();
    }

    public class Explicit_Interface_Implementation : IFirst, ISecond
    {
        void IFirst.DoSomething() { }
        void ISecond.DoSomething() { }
        public void DoThat() { }
        void ISecond.DoThat() { }
    }

    public class Use_Explicit_Interface_Implementation 
    {
       public void Test()
        {
            var test = new Explicit_Interface_Implementation();
            test.DoThat(); //chamada do método publico
            ((ISecond)test).DoSomething(); //chamada do método explicitamente implementado
        }
    }
}
