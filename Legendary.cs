//Essas são as bibliotecas padrões, que já veem declaradas.
using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Text;
 using System.Threading.Tasks;
   
 using System.IO; //declarando a biblioteca de entrada e saída de arquivos
                  //a biblioteca IO

namespace Senai.Teste.ArquivoTesto
{
    class Program
    {
        static void Main(string[] args)
        {

    string[] linha = new string[1];
            int cont = 0;
            int menu;

            //toda vez que terminar uma fala ele pergunta se você quer criar outras
            do {
            Console.WriteLine("Deseja adicionar uma legenda? (1 = sim / 0 = não)");
            menu = int.Parse(Console.ReadLine());
;

                if (menu == 1) {
                    Array.Resize(ref linha, linha.Length + 2);

                    Console.WriteLine("Digite o tempo inicial");
                    DateTime tempoInicial = DateTime.Parse(Console.ReadLine());
                    //Console.WriteLine(tempoInicial.ToString("HH:mm:ss"));
                    string tempoI = tempoInicial.ToString("HH:mm:ss.fff");

                    Console.WriteLine("Digite o tempo final");
                    DateTime tempoFinal = DateTime.Parse(Console.ReadLine());
                    //Console.WriteLine(tempoFinal.ToString("HH:mm:ss"));
                    string tempoF = tempoFinal.ToString("HH:mm:ss.fff");

                    //cria e armazena as falas em um arquivo vtt
                    Console.WriteLine("Digite a fala");
                    string legenda = Console.ReadLine();

                    linha[cont] = ($"{tempoI} --> {tempoF}");
                    cont++;
                    linha[cont] = legenda;
                    cont += 2;

                    System.IO.File.WriteAllLines("C:\\Users\\FIC\\Documents\\Projetos_SENAI\\Senai.Teste.ArquivoTesto\\teste.vtt", linha );
                }
                
            } while (menu != 0);
        }
    }
}
