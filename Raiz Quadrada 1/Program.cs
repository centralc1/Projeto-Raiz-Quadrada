using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Diagnostics.Eventing.Reader;
using System.Runtime.Remoting.Messaging;

namespace Raiz_Quadrada_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            double numero = 0;
            double resultado;
            string opcaodefinalizacao1;
            string opcaodefinalizacao2;

        Inicio:
            Console.Write("Digite o Número a ser calculado: ");
            numero = double.Parse(Console.ReadLine());
            resultado = Math.Sqrt(numero);
            Console.WriteLine("A raiz quadrada de " + numero + " é : " + resultado);

            switch (numero)
            {
                default:
                case 1:
                    Console.Write("Deseja continuar calculando ? (s / n) ");
                    opcaodefinalizacao1 = Console.ReadLine();
                    if (opcaodefinalizacao1 == "s" || opcaodefinalizacao1 == "S") ;
                    else return;
                    {
                        goto Inicio;                   
                    }
                    break;
                    

            }
            Console.ReadKey();

        }
    }
}