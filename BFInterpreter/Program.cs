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
            MemoryCollection memoryCollection = new MemoryCollection();
            var input = Console.ReadLine();


            for (int i = 0; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case '>': memoryCollection.MoveNext(); break;
                    case '<': memoryCollection.MovePrevious(); break;
                    case '+': memoryCollection.Increment(); break;
                    case '-': memoryCollection.Decrement();  break;
                    case '.': Console.WriteLine(Convert.ToChar(memoryCollection.GetCurrentCell())); break;
                    case '[': i = StartWhile(memoryCollection.GetCurrentCell(), input, i);
                        break;
                    case ']': i = EndWhile(input, i);
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;                    
                }
            }
            Console.ReadLine();
        }
        private static int EndWhile(string input, int i)
        {
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
            return i;
        }

        private static int StartWhile(byte currentCell, string input, int i)
        {
            if (currentCell == 0)
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
            return i;
        }
    }
}