using System;

namespace BFInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            MemoryCollection memoryCollection = new MemoryCollection();
            var input = Console.ReadLine();
            InputIterator inputIterator = new InputIterator(input);

            while (inputIterator.HasNext())
            {
                switch (inputIterator.Next())
                {
                    case '>': memoryCollection.MoveNext(); break;
                    case '<': memoryCollection.MovePrevious(); break;
                    case '+': memoryCollection.Increment(); break;
                    case '-': memoryCollection.Decrement(); break;
                    case '.': Console.WriteLine(Convert.ToChar(memoryCollection.GetCurrentCell())); break;
                    case '[':
                        if (memoryCollection.GetCurrentCell()==0)
                        inputIterator.GoToEndBFLoop(); break;
                    case ']': inputIterator.GoToStartBFLoop(); break;
                    default : Console.WriteLine("Wrong input"); break;
                }
            }
            Console.ReadLine();
        }        
    }
}