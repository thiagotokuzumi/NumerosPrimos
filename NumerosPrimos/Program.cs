using System;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número que deseja verificar se é primo ou não, caso não seja," +
                "retornará seu divisor maior que 1: ");
            long n = Convert.ToInt64(Console.ReadLine());

            Console.Clear();

            int resultado = PrimoOuNao(n);
            Console.Write(resultado);
        }

        static int PrimoOuNao(long n)
        {
            int flag = 0, result = 1;
            long divider = n / 2;

            /* Number Prime Check */
            for (int i = 2; i <= divider; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                }
            }


            /* not prime */
            if (flag == 1)
            {
                /* Retornar divisor do número não primo > 1 */
                if (n % 2 == 0)
                {
                    result = 2;
                }
                else
                {
                    result = 3;
                }
            }

            return result;

        }
    }

}