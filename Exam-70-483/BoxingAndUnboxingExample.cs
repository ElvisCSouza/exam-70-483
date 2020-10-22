using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class BoxingAndUnboxingExample
    {
        public void Test()
        {
            int inteiro = 1;
            var objeto = (object)inteiro;//Boxing
            inteiro = (int)objeto;//Unboxing
        }
    }
}
