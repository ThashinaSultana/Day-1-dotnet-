using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class ToggleChar
    {
        public static void Toggle()
        {
            string s;
            Console.WriteLine(" Enter string");
            s = Console.ReadLine();
           char[] str = s.ToCharArray();
            toggleChars(str);
            Console.WriteLine("String after toggle ");
            Console.WriteLine(String.Join("", str));
        }

            static void toggleChars(char[] str)
            {
                for (int i = 0; i < str.Length; i++)
                {
                if (str[i] >= 65 && str[i] <= 90)
                    //str[i] = (char)(str[i] + 'a' - 'A');
                    str[i] = (char)(str[i] + 32);
                else if (str[i] >= 97 && str[i] <= 122)
                    str[i] = (char)(str[i]-32);
                }
            }

            // Driver code  
           
                
          
        }
    }
    
