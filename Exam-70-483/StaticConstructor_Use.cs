using System;

namespace Exam_70_483
{
    public class StaticConstructor_Use
    {
        public Onibus Bus1 { get; set; }
        public Onibus Bus2 { get; set; }

        public StaticConstructor_Use()
        {
            Bus1 = new Onibus(71);
            Bus2 = new Onibus(72);

            Bus1.Dirigir();

            System.Threading.Thread.Sleep(250);

            Bus2.Dirigir();

            Console.ReadKey();
        }
    }

    /// <summary>
    /// Fonte do exemplo: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/static-constructors
    /// </summary>
    public class Onibus
    {
        // Variavel estática usada por todas instâncias da classe Onibus
        protected static readonly DateTime Inicio;

        protected int NumeroDoOnibus { get; set; }

        // Construtor estático que inicializa a variável estático.
        // Ele é chamado antes que o construtor da primeira instância seja executado.
        static Onibus()
        {
            Inicio = DateTime.UtcNow;

            // The following statement produces the first line of output, and the line occurs only once.
            // A instrução a seguir produz a primeira linha de saída e a linha ocorre apenas uma vez.
            Console.WriteLine($"Construtor estático define o tempo de início global para {Inicio.ToLongTimeString()}");
        }

        public Onibus(int numeroOnibus)
        {
            NumeroDoOnibus = numeroOnibus;
            Console.WriteLine($"Ônibus #{NumeroDoOnibus} foi criado.");
        }

        public void Dirigir()
        {
            TimeSpan elapsedTime = DateTime.Now - Inicio;

            // For demonstration purposes we treat milliseconds as minutes to simulate
            // actual bus times. Do not do this in your actual bus schedule program!
            Console.WriteLine($"{NumeroDoOnibus} está iniciando sua rota {elapsedTime.Milliseconds:N2} minutos após o horário de início global {Inicio.ToShortTimeString()}.");
        }
    }
}
