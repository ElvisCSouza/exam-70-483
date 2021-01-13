using System;

namespace Exam_70_483
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ExampleAttribute : System.Attribute
    {
        public string VariavelPublica1;
        public string VariavelPublica2;

        private string VariavelPrivada1;
        private string VariavelPrivada2;

        public ExampleAttribute(string variavelPrivada1, string variavelPrivada2, string variavelPublica1)
        {
            VariavelPrivada1 = variavelPrivada1;
            VariavelPrivada2 = variavelPrivada2;
            VariavelPublica1 = variavelPublica1;
        }

        public ExampleAttribute(string variavelPrivada1, string variavelPrivada2)
        {
            VariavelPrivada1 = variavelPrivada1;
            VariavelPrivada2 = variavelPrivada2;
        }


        public ExampleAttribute(string variavelPrivada1)
        {
            VariavelPrivada1 = variavelPrivada1;
        }
    }

    [AttributeUsage(AttributeTargets.Property)]
    public class ExamplePropertyAttribute : System.Attribute
    {
        public string VariavelPublica1;
        public string VariavelPublica2;

        private string VariavelPrivada1;
        private string VariavelPrivada2;

        public ExamplePropertyAttribute(string variavelPrivada1, string variavelPrivada2)
        {
            checked
            {
                
                VariavelPrivada1 = variavelPrivada1;
            }
            VariavelPrivada2 = variavelPrivada2;
        }

        public ExamplePropertyAttribute(string variavelPrivada1)
        {
            VariavelPrivada1 = variavelPrivada1;
        }

        public ExamplePropertyAttribute(string variavelPublica1, string variavelPrivada1, string variavelPublica2)
        {
            VariavelPublica1 = variavelPublica1;
            VariavelPrivada1 = variavelPrivada1;
            VariavelPublica2 = variavelPublica2;
        }
    }

    [Example("1", VariavelPublica1 = "p1")]
    public class UsoDoAtributo
    {
        [ExampleProperty("1", "2", VariavelPublica1 = "a", VariavelPublica2 = "ab")]
        public int MyProperty { get; set; }
        //[ExampleProperty("1", "3", "3")]
        public string Teste;
    }

    [Example("1", "2", VariavelPublica2 = "ab")]
    public class Uso2DoAtributo
    {

    }

    [Example("1", VariavelPublica2 = "1", VariavelPublica1 = "2")]
    public class Uso3DoAtributo
    {

    }
}
