using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula20241804
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int quantidadeFilho = 3;
            double saldo = 15000;
            double divisao;
            bool vivo = false;

            try
            {
                divisao = saldo / quantidadeFilho;

                if(vivo == false)
                {
                    throw new Exception();
                }

                else
                {
                    Console.WriteLine("Dividido!");
                    Console.WriteLine("O saldo de "+saldo+" foi dividido entre o(s) "+quantidadeFilho+" filhos.");
                    Console.WriteLine($"Parcela de cada um: R$ {divisao:F2}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("°~°~°~°~°~° ERRO °~°~°~°~°~°");
                Console.WriteLine("Proprietário da conta foi de arrasta. Disque 190.");
            }
            finally
            {
                Console.WriteLine("Finalizando...");
            }
        }
    }
}
