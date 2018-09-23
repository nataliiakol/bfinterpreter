using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BFInterpreter
{
    public class InterpreterDictionary
    {
        public Dictionary<char, Action> Rules = new Dictionary<char, Action>();

    }
}
