using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] memoryArray = new byte[30000];
            var input = Console.ReadLine();
            int pointer = 0;
            Parse(input, pointer, memoryArray);
            Console.ReadLine();
        }
        public static void Parse(string input, int pointer, byte[] memoryArray)
        {
            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '>': pointer++; break;
                    case '<':
                        if (pointer > 0)
                        {
                            pointer--;
                        }
                        break;
                    case '+': memoryArray[pointer]++; break;
                    case '-':
                        if (memoryArray[pointer] > 0)
                        {
                            memoryArray[pointer]--;
                        }
                        break;
                    case '.': Console.WriteLine(Convert.ToChar(memoryArray[pointer])); break;

                    case '[':
                        if (memoryArray[pointer] == 0)
                        {
                            int loop1 = 1;
                            while (loop1 > 0)
                            {
                                i++;
                                if (input[i] == '[')
                                {
                                    loop1++;
                                }
                                else if (input[i] == ']')
                                {
                                    loop1--;
                                }
                            }  
                        }
                        break;
                    case ']':
                        int loop = 1;
                        while (loop > 0)
                        {
                            i--;
                            if (input[i] == '[')
                            {
                                loop--;
                            }
                            else if (input[i] == ']')
                            {
                                loop++;
                            }                
                        }
                        i--;
                        break; 
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }
        }
    }
}
