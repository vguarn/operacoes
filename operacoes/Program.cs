using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double r;
            //Entrada
            Console.WriteLine("Digite o primeiro número ");
            double n1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo número ");
            double n2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Escolha a operação: + para adição, - pra subtração, * para multiplicação e / para divisão ");
            string operacao = Console.ReadLine();
            //processamento e saída
            if (operacao == "+")
            {
                r = n1 + n2;
                Console.WriteLine("O resultado da operação é " + r);
            }
            else if (operacao == "-")
            {
                r = n1 - n2;
                Console.WriteLine("O resultado da operação é " + r);
            }
            else if (operacao == "*")
            {
                r = n1 * n2;
                Console.WriteLine("O resultado da operação é " + r);
            }
            else if (operacao == "/")
            { 
                r = n1 / n2;
            Console.WriteLine("O resultado da operação é " + r);
            }
            else
                Console.WriteLine("Algo deu errado, tente novamente. ");

           
           Console.ReadKey();

        }
    }
}
