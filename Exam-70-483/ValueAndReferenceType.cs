using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exam_70_483.Value_and_Reference_Type
{
    public class ValueAndReferenceType
    {
        public class Pessoa //O tipo Pessoa é um Reference Type
        {
            public string Nome { get; set; }
        }

        public struct Carro //O tipo Carro é um Value Type pois é uma struct
        {
            public string Nome { get; set; }
        }

        /// <summary>
        /// Exemplo de mudança da valor dentro de uma lista através da atribuição em outra variável.
        /// </summary>
        public void ReferenceType()
        {
            List<Pessoa> lista = new List<Pessoa>() { new Pessoa() { Nome = "a" }, new Pessoa() { Nome = "b" } };
            Console.WriteLine("Pessoa[0] " + lista[0].Nome + " (antes da mudança)");
            var item1 = lista.First();
            item1.Nome = "c";
            Console.WriteLine("Pessoa[0] " + lista[0].Nome + " (depois da mudança)");
        }

        /// <summary>
        /// Exemplo da permanencia de um valor dentro de uma lista mesmo tendo a atribuição em outra variável.
        /// </summary>
        public void ValueType_Struct()
        {
            List<Carro> lista = new List<Carro>() { new Carro() { Nome = "a" }, new Carro() { Nome = "b" } };
            Console.WriteLine("struct Carro[0] " + lista[0].Nome + " (antes da mudança)");
            var item1 = lista.First();
            item1.Nome = "c";
            Console.WriteLine("struct Carro[0] " + lista[0].Nome + " (depois da mudança)");
        }

        /// <summary>
        /// Tipos primitivos permanecem com seu valor mesmo após serem atribuídos em outra variável.
        /// </summary>
        public void ValueType_PrimitiveType()
        {
            List<string> lista = new List<string>() { "a", "b" };
            Console.WriteLine("lista[0] " + lista[0] + " (antes da mudança)");
            var item1 = lista.First();
            item1 = "c";
            Console.WriteLine("lista[0] " + lista[0] + " (depois da mudança)");
        }

        /// <summary>
        /// Por 'a' se tratar de um ReferenceType, o mesmo se comporta apenas como um ponteiro que é 
        /// armazenado na Stack, ao qual tem o endereço de memória na Heap ao qual o valor do dado está gravado
        /// Então, se 'b' é igual a 'a', logo ambos apontam ao mesmo valor na Heap.
        /// Por isso ao se alterar 'b', altera-se ao mesmo tempo 'a'
        /// </summary>
        public void ReferenceType_Example2()
        {
            Pessoa a = new Pessoa();
            a.Nome = "José";
            Pessoa b = a;
            b.Nome = "Maria";
            Console.WriteLine("Nome: " + a.Nome);
        }
    }
}
