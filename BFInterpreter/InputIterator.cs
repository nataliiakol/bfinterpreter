namespace BFInterpreter
{
    public class InputIterator
    {
        private string input;
        private int pointer;
        public InputIterator(string input)
        {
            this.input = input;
            pointer = 0;
        }

        public char Next()
        {
            return input[pointer++];
        }

        public bool HasNext()
        {
           
            return pointer < input.Length;
        }

        public void GoToEndBFLoop()
        {
            int loop = 1;
            while (loop > 0)
            {
                pointer++;
                if (input[pointer] == '[')
                {
                    loop++;
                }
                else if (input[pointer] == ']')
                {
                    loop--;
                }
            }
            pointer++;
        }

        public void GoToStartBFLoop()
        {
            pointer--;
            int loop = 1;
            while (loop > 0)
            {
                pointer--;
                if (input[pointer] == '[')
                {
                    loop--;
                }
                else if (input[pointer] == ']')
                {
                    loop++;
                }
            }
        }
        
    }
}
