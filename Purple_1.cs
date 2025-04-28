using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_1 : Purple
    {
        private string _output;
        public Purple_1(string input) : base (input)
        { }

        public string Output
        {
            get
            {
                return _output;
            }
        }
        
        public override void Review()
        {
            if (_input == null) return;
            var a = _input.Split(' ');
            string[] answer = new string[0];
            foreach (var ar in a)
            {
                if (ar == null) return;
                string copy = "";
                string nado = "";
                for (int i=0; i<ar.Length; i++)
                {
                    if (Char.IsDigit(ar[i]))
                    {
                        //answer.Append(ar);
                        Array.Resize(ref answer, answer.Length + 1);
                        answer[answer.Length - 1] = ar;
                        break;
                    }
                    if (separators.Contains(ar[i]))
                    {
                        for (int j = copy.Length - 1; j >= 0; j--)
                        {
                            if (copy != "")
                            { 
                            nado += copy[j];
                             }
                        }
                        nado += ar[i];
                        copy = "";
                    }
                    else
                    {
                        copy += ar[i];
                    }
                }
                if (!(separators.Contains(ar[ar.Length-1])))
                {
                    for (int j= copy.Length-1; j>=0; j--)
                    {
                        if (copy != "")
                        {
                            nado += copy[j];
                        }
                    }
                }
                //answer.Append(nado);
                if (nado!="")
                { 
                    Array.Resize(ref answer, answer.Length + 1);
                answer[answer.Length - 1] = nado;
                }
                
            }
            _output = String.Join(" ", answer);
        }

        public override string ToString()
        {
            return _output;
        }

    }
}
