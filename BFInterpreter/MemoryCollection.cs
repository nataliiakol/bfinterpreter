using System;

namespace BFInterpreter
{
    public class MemoryCollection
    {
        private readonly int SIZE = 30000;
        private int pointer;
        private byte[] memory;

        public MemoryCollection()
        {
            memory = new byte[SIZE];
            pointer = 0;
        }

        public void MoveNext()
        {
            pointer++;
        }

        public void MovePrevious()
        {
            pointer = (pointer > 0) ? pointer-1 : 0;
         }

        public byte GetCurrentCell()
        {
            return memory[pointer];
        }

        public void Increment()
        {
            memory[pointer]=(Byte)(memory[pointer]+1);
        }

        public void Decrement()
        {
            memory[pointer] = (memory[pointer] > 0)? (Byte)(memory[pointer]-1) : (Byte)0;
        }

        public void WriteInCell(byte input)
        {
            memory[pointer] = input;
        }      
    }
}
