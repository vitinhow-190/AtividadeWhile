using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace AtividadeWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resp = "s";
            double valor;
            do
            {
                Console.WriteLine("Digite a despesa: ");
                string des = Console.ReadLine();
                Console.WriteLine("Digite o valor da despesa: ");
                valor = double.Parse(Console.ReadLine());

                valor += valor;

                Console.WriteLine("Deseja continuar? ");
                resp = Console.ReadLine();
            }while (resp == "s");
            Console.WriteLine("Quantas pessoas moram na residencia? ");
            int quant = int.Parse(Console.ReadLine());

            valor = valor / quant;

            Console.WriteLine("Cada morador deverá pagar" + valor);
            Console.ReadLine();
        }
    }
}
