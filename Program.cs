using System;

namespace Exercicio3_Fixacao_Repeticao
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[10];
            string nome;
            
            

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine("Digite um nome: ");
                nomes[i] = Console.ReadLine();
            }

           Console.WriteLine("Digite um nome a ser pesquisado: ");
           nome = Console.ReadLine();

            for (var i = 0; i < nomes.Length; i++)
            {
                
                if(nome == nomes[i])
                {
                    Console.WriteLine("Nome encontrado !");   
                }
                
               

                if(nome != nomes[i]) 
                {
                    Console.WriteLine("Nome não encontrado !");
                    Console.ReadLine();
                }
                          
            
            }

                    
        }
    }
}

// Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas e armazene os nomes
// lidos em um vetor. Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de
// pessoa (para efetuar uma busca) e depois escrever a mensagem ACHEI, se o nome estiver
// entre os 10 nomes lidos anteriormente (guardados no vetor), ou NÃO ACHEI caso contrário.

