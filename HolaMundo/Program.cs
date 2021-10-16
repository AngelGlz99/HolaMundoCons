using System;

namespace HolaMundo
{
    class Program
    {
        public void ____()
        {

        }
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World! for Sonarqube");
            Console.WriteLine("Programa Fibonacci");
            Console.WriteLine("Escriba un limite de la secuencia");
            int limite = int.Parse(Console.ReadLine());
            Console.WriteLine($"El limite es: {limite}");

            int d, e, f, g, h, _, __, ___, variable;

            for (int a = 0, b = 1, c = 0; c < limite;)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
        }
    }
}
