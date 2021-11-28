using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Task6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string startString = Console.ReadLine();
            string[] stringArray = startString.Split();
            string strokaBesProbelov = "";
            string strokaBesProbelovRe = "";
            int l = 0;
           
                  

            foreach (string s in stringArray)
            {
                strokaBesProbelov += s.Substring(0, 1).ToLower() + s.Substring(1).ToLower();
            }

            l = strokaBesProbelov.Length;

            for (int i = l-1; i >= 0; i--)
            {
                strokaBesProbelovRe += strokaBesProbelov[i];
            }
            if (strokaBesProbelov == strokaBesProbelovRe)
                Console.WriteLine("Введенная строка является палиндромом.");
            else
                Console.WriteLine("Введенная строка не является палиндромом.");
            Console.ReadKey();
            
        }
    }
}
