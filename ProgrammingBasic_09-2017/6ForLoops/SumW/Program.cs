﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumW
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            var sum = 0;
            for (int i = 0; i < word.Length; i++)
                
                switch (word[i])
            {
                    case 'a': sum += 1; break;
                    case 'e': sum += 2; break;
                    case 'i': sum += 3; break;
                    case 'o': sum += 4; break;
                    case 'u': sum += 5; break;
                default:
                    break;
            }
            Console.WriteLine(sum);
            
            /*
            {
               if (word[i] == 'a') sum = +1;
               else if (word[i] == 'e') sum += 2;
               else if (word[i] == 'i') sum += 3;
               else if (word[i] == 'o') sum += 4;
               else if (word[i] == 'u') sum += 5;
            }
            
            Console.WriteLine(sum);
            */

        }
    }
}
