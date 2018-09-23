using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFInterpreter
{
    public class MemoryCollection
    {
        private readonly int SIZE = 30000;
        private int pointer;
        private byte[] memory;

        public MemoryCollection() {
            memory = new byte[SIZE];
            pointer = 0;
        }

        public void MoveNext() {
            pointer++;
        }

        public void MovePrevious() {
            pointer = (pointer > 0) ? pointer-1 : 0;
         }

        public byte GetCurrentCell() {
            return memory[pointer];
        }

        public void Increment() {
            memory[pointer]++;
        }

        public void Decrement()
        {
            memory[pointer] = (memory[pointer] > 0)? memory[pointer]-- : (Byte)0;
        }

        public void WriteInCell(byte input)
        {
            memory[pointer] = input;
        }      
    }
}
