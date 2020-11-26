using System;
using System.Collections.Generic;

namespace teste
{
    class Program
    {
        //Console desenvolvido para restagar os fatores primos de um numero inteiro.
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um numero para receber seus fatores primos:");
            var num = Console.ReadLine();

            var list = GetPrimeFactors(Convert.ToInt32(num));
            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadLine();
        }

        private static List<int> GetPrimeFactors(int num)
        {
            int count = 0;
            var list = new List<int>();
            var resultList = new List<int>();
            int i = 0;
            for (i = 2; i <= num; i++)
            {
                if (IsPrime(i) == true)
                {
                    list.Add(i);
                    count++;
                }
            }

            while (true)
            {
                if (IsPrime(num) == true)
                {
                    resultList.Add(num);
                    break;
                }
                for (i = count - 1; i >= 0; i--)
                {
                    if ((num % list[i]) == 0)
                    {
                        resultList.Add(list[i]);
                        num = num / list[i];
                        break;
                    }
                }
            }

            return OrderList(resultList);
        }

        private static bool IsPrime(int num)
        {
            if (num == 2)
                return true;

            var x = num / 2;

            for (int i = 2; i <= x; i++)
            {
                var rest = num % i;
                if (rest == 0)
                {
                    return false;
                }
            }
            return true;
        }

        private static List<int> OrderList(List<int> list)
        {
            list.Sort();
            return list;
        }
    }
}
