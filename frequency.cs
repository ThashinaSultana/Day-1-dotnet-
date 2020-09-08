using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Frequency
    {
        public static void Freq()
        {
            int[] c = new int[(int)char.MaxValue];
            string s;
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
            foreach (char t in s)
            {
                c[(int)t]++;
            }
            for (int i = 0; i < (int)char.MaxValue; i++)
            {
                if (c[i] > 0 && char.IsLetterOrDigit((char)i))
                    
        
                {
                    Console.WriteLine("Letter: {0}  Frequency: {1}", (char)i,c[i]);


                }



            }
        }
    }
}
