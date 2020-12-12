using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class Testandodor<T> where T : class, new()
    {
        public T MyProperty { get; set; }
        public Testandodor()
        {
            MyProperty = new T();
        }

    }

    public class TestandoAMamnha
    {
        public TestandoAMamnha()
        {

        }
    }



    /// <summary>
    /// Ocorre quando um método possui os mesmos tipos de retorno e mesmos parâmetros porém parâmetros diferentes.
    /// </summary>
    public class OverrideExample
    {
        public virtual void DoSomething(int a)
        {
            var testeeee = new Testandodor<TestandoAMamnha>();
        }
    }

    public class OverrideExampleChild : OverrideExample
    {
        public override void DoSomething(int a)
        {

        }
    }
    


}
