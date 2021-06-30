using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float[]notas = new float[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a " + (i + 1) + "nota:");
                notas[i] = float.Parse(Console.ReadLine());
            }

            Console.WriteLine("Notas: ");
            foreach (float nota in notas)
            {
                Console.Write(nota + " ");
            }
            
        }
    }
}
