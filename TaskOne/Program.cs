using System;
using System.Formats.Asn1;
using System.Linq.Expressions;

namespace TaskOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write line, please");
            string str = Console.ReadLine();
            char[] ar = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                ar[i] = str[i];
            }
            int count = 0;

            for (int i = 0; i < ar.Length - 1; i++)
            {
                var newAr = new List<char>();

                for (int j = i; j < ar.Length; j++)
                {
                    if (Check(newAr, ar[j]))
                    {
                        newAr.Add(ar[j]);
                    }
                    else
                    {
                        break;
                    }

                }
                if (count < newAr.Count)
                {
                    count = newAr.Count;
                }

            }
            Console.WriteLine(count);
        }

        static bool Check(List<char> list, char el)
        {
            foreach (char item in list)
            {
                if (item == el) return false;
            }
            return true;
        }
    }
}



