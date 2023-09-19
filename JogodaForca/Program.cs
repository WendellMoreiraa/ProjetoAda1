using System;
using System.Linq;

class Program
{
    static void Main()
    {
        string [] palavras = {"banana","maca","arvore", "casa", "leao", "cavalo", "jumento" };
        Random random = new Random();
        string palavraSelecionada = palavras[random.Next(0, palavras.Length)];
        string palavraRevelada = new string('_', palavraSelecionada.Length); 
        int tentativasRestantes = 6; 

        Console.WriteLine("Bem-vindo ao Jogo da Forca!");

        while (tentativasRestantes > 0)
        {
            Console.WriteLine("\nPalavra: " + palavraRevelada);
            Console.WriteLine("Tentativas restantes: " + tentativasRestantes);

            Console.Write("Digite uma letra: ");
            char letra = Console.ReadKey().KeyChar;

            if (palavraSelecionada.Contains(letra))
            {
                

                for (int i = 0; i < palavraSelecionada.Length; i++)
                {
                    if (palavraSelecionada[i] == letra)
                    {
                        palavraRevelada = palavraRevelada.Remove(i, 1).Insert(i, letra.ToString());
                    }
                }
            }
            else
            {
                
                Console.WriteLine("\nA letra não está na palavra.");
                tentativasRestantes--;
            }

           
            if (palavraRevelada == palavraSelecionada)
            {
                Console.WriteLine("\nParabéns! Você adivinhou a palavra: " + palavraSelecionada);
                break;
            }
        }

        if (tentativasRestantes == 0)
        {
            Console.WriteLine("\nVocê perdeu! A palavra era: " + palavraSelecionada);
        }
    }
}
