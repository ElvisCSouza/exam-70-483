using Exam_70_483.Value_and_Reference_Type;

namespace Exam_70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            ValueAndReferenceType valueAndReferenceType = new ValueAndReferenceType();

            valueAndReferenceType.ReferenceType();

            valueAndReferenceType.ValueType_PrimitiveType();

            valueAndReferenceType.ValueType_Struct();

            valueAndReferenceType.ReferenceType_Example2();
        }
    }
}
