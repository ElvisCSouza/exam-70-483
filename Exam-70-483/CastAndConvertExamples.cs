using System;
using System.Collections.Generic;
using System.Text;

namespace Exam_70_483
{
    public class CastAndConvertExamples
    {
        public void Test()
        {
            int inteiro = 1;
            decimal dinheiro = 5.5M;

            dinheiro = inteiro;//Conversão implícita
            inteiro = (int)dinheiro; //Conversão (cast) explícita

        }
    }
}
