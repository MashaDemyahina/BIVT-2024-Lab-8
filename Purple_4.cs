using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_4 : Purple
    {
        private string _output;
        private (string, char)[] _code;
        public string Output 
        { 
            get
            {
                return _output;
            }
        }
        public Purple_4(string input, (string, char)[] codes) : base(input)
        {
            _code = codes;
            
        }

        public override void Review()
        {
            if (_input == null || _code == null) return;
            var answer = new StringBuilder();
            for (int i=0; i<_input.Length; i++)
            {
                int k = 0;
                for (int j =0; j<_code.Length; j++)
                {
                    if (_input[i]== _code[j].Item2)
                    {
                        k++;
                        continue;
                    }
                }
                if (k==0)
                {
                    answer.Append(_input[i]);
                }
                else
                {
                    answer.Append(_code[k].Item1);
                }
            }
            _output = answer.ToString();

        }
        public override string ToString()
        {
            return _output;
        }
    }
}
