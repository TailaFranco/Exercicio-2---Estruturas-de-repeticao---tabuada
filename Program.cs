using System;

namespace Exercício_2___Escreva_a_tabuada_de_1_a_10
{
    // Escreva um algoritmo que imprima a tabuada (de 1 a 10) para os números de 1 a 10.
    // Exemplo: tabuada do 1, tabuada do 2, etc... Dica: utilize um laço dentro do outro.
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            Console.WriteLine("Visualização da tabuada.");

                for (var x = 1; x <= 10; x++)
                {
                   Console.WriteLine($"Tabuada do {x}");
                for (var i = 0; i <= 10; i++)
                {
                tabuada = x * i;
                Console.WriteLine($"{x} * {i} = {tabuada}");
                } 
                }
        }
    }
}
