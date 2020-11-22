using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class DisposableClassTest : IDisposable
    {
        public string MyProperty { get; set; }

        public DisposableClassTest(string dx)
        {
            MyProperty = dx;
        }

        public void T(string a)
        {
            MyProperty = a;
        }

        public void Dispose()
        {

        }

        ~DisposableClassTest()
        {

        }
    }
}
