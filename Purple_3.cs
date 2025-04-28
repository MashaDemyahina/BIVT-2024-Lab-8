using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_3 : Purple
    {
        private string _output;
        
        public string Output
        {
            get
            {
                return _output;
            }
        }
        public (string, char)[] Codes
        { 
            get; private set; 
        }
        private char[] Code;
        public Purple_3(string input) : base(input)
        {
            Codes = new (string, char)[5];
            Code = new char[0];
            for (char c = ' '; Code.Length<5 && c<= 126; c++)
            {
                if (!input.Contains(c)) Code = Code.Append(c).ToArray();
            }
            
        }

        
        public override void Review()
        {
            if (_input == null) return;
            var answer = new StringBuilder();
            string[] pair = new string[0];
            for (int i = 0; i < _input.Length - 1; i++)
            {
                if (Char.IsLetter(_input[i]) && Char.IsLetter(_input[i + 1]))
                    pair = pair.Append($"{_input[i]}{_input[i + 1]}").ToArray();
            }
            
            var A = pair.GroupBy((x) => (x))
                .Select(x => (x.Key.ToString(), x.Count()))
                .OrderByDescending(x => x.Item2)
                .Select(x => x.Item1)
                .Take(5).ToArray();
            for (int i = 0; i < Math.Min(5, A.Length); i++)
            {
                //Codes = Codes.Append((A[i], Code[i])).ToArray();
                Codes[i] = (A[i], Code[i]);
            }
            var tmp = _input;
            for (int i = 0; i <A.Length; i++)
            {
                int z=0;
                for (int j = 0; j < tmp.Length - 1; j++)
                {

                    if ($"{tmp[j]}{tmp[j + 1]}" == A[i])
                    {
                        answer.Append(Code[i]);
                        j++;
                        z++;
                    }
                    else { answer.Append(tmp[j]); }
                    z++;
                }
                if (z == tmp.Length - 1)
                { 
                    answer.Append(tmp[z]);
                }
                tmp = answer.ToString();
                answer = new StringBuilder();
            }
            _output = tmp.ToString();
           // answer = new StringBuilder();





            // for (int i=0; i<5; i++) { }
            //int[,] pairCounts = new int[95, 95];
            // for (int i = 0; i < _input.Length - 1; i++)
            // {
            //    char firstChar = _input[i];
            //     char secondChar = _input[i + 1];
            //     pairCounts[firstChar - 32, secondChar - 32]++;
            //  }

        }
        public override string ToString()
        {
            return _output;
        }
    }
}