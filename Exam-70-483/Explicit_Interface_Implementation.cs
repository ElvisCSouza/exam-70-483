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
        void DoSomething();
    }

    public class Explicit_Interface_Implementation : IFirst, ISecond
    {
        public void DoSomething()
        {
            throw new NotImplementedException();
        }

        void ISecond.DoSomething()
        {
            throw new NotImplementedException();
        }

        
    }

    public class Use_Explicit_Interface_Implementation 
    {
       public void Test()
        {
            var test = new Explicit_Interface_Implementation();
            test.DoSomething(); //chamada do método publico
            ((ISecond)test).DoSomething(); //chamada do método privado explicitamente implementado
        }
    }
}
