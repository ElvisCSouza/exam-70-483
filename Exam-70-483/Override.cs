using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    /// <summary>
    /// Ocorre quando um método possui os mesmos tipos de retorno e mesmos parâmetros porém parâmetros diferentes.
    /// </summary>
    public class OverrideExample
    {
        public virtual void FazAlgo(int a)
        {

        }
    }

    public class OverrideExampleChild : OverrideExample
    {
        public override void FazAlgo(int a)
        {

        }
    }
}
