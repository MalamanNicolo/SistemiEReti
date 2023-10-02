using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversioneInBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] b = new bool[32]; 
            int[]numDecPunt = new int[4];
            double numero = Convert_Binario_To_Intero(b);
            Console.WriteLine(numero);
            double numero1 = Convert_Decimale_Puntato_To_Intero(numDecPunt);
            Console.WriteLine(numero1);
            Console.ReadLine();
        }
        static double Convert_Binario_To_Intero(bool[] b)
        {
            double num;
            double numeroDecimale = 0;
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"Inserire il {i + 1} bit");
                num = Convert.ToInt32(Console.ReadLine());
                b[i] = Convert.ToBoolean(num);
            }
            for (int i = 0; i < b.Length; i++)
            {
                if (b[i])
                {
                    num = Convert.ToInt32(b[i]);
                    num = num * Math.Pow(2, i);
                    numeroDecimale = numeroDecimale + num;
                }
            }
            return numeroDecimale;
        }
        static double Convert_Decimale_Puntato_To_Intero(int[] numDecPunt)
        {
            double numeroDecimale = 0;
            double num;
            double cont = 0;
            for (int i = 0; i < numDecPunt.Length; i++)
            {
                Console.WriteLine($"Inserire il {i + 1} byte");
                numDecPunt[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = numDecPunt.Length - 1; i >= 0; i--)
            {                
                num = Convert.ToInt32(numDecPunt[i]);
                num = num * Math.Pow(256, cont);
                numeroDecimale = numeroDecimale + num;
                cont++;
            }
            return numeroDecimale;

        }
    }
}
