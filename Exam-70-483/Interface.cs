using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public interface InterfaceContrato
    {
        string DoSomething(int a);
    }

    public class ClasseConcreta : InterfaceContrato
    {
        public string DoSomething(int a)
        {
            return "";
        }
    }

    public struct StructConcreta : InterfaceContrato
    {
        public string DoSomething(int a)
        {
            return "";
        }
    }

}
