using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8
{
    public class Purple_2 : Purple
    {
        private string _output;
        public Purple_2(string input) : base(input)
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

            var b = _input.Split(' ');
            var str = new StringBuilder();
            var answer = new StringBuilder();
           // var answers = new StringBuilder();
            while (b.Length > 0)
            {
                int k = 0;
                int z = 0;
                for (int i = 0; i < b.Length; i++) 
                {
                    var c = b[i];
                    if (z + c.Length + 1 <= 50)
                    {
                        if (z != 0)
                        {
                            z++;
                            str.Append(" ");
                        }
                        z += c.Length;
                        str.Append(c);
                        k++;
                    }
                    else
                    {
                        var strstr = str.ToString();
                        var words = strstr.Split(' ');

                        if (k == 1)
                        {
                            //answer.AppendLine(strstr);
                            answer.Append($"{strstr}{Environment.NewLine}");
                        }

                        else
                        {

                            int p = 50 - strstr.Length + (k - 1);
                            int cel = p / (k - 1);
                            int ost = p % (k - 1);


                            for (int j = 0; j < k; j++)
                            {
                                answer.Append(words[j]);
                                if (j < k - 1)
                                {
                                    answer.Append(new string(' ', cel));
                                    if (j < ost)
                                    {
                                        answer.Append(" ");
                                    }
                                }
                            }
                            answer.Append($"{Environment.NewLine}");
                        }

                        
                        str = new StringBuilder();
                       // str.Append(b);
                        z = 0; 
                        k = 0;
                        i--;
                    }

                }
                if (str.Length > 0)
                {
                    var strstr = str.ToString();
                    var words = strstr.Split(' ');
                    if (k == 1)
                    {
                        //answer.AppendLine(strstr);
                        answer.Append($"{strstr}");
                    }
                    else
                    {
                       
                        int p = 50 - strstr.Length + (k - 1);
                        int cel = p / (k - 1);
                        int ost = p % (k - 1);
                        for (int j = 0; j < words.Length; j++)
                        {
                            answer.Append(words[j]); 
                            if (j < k - 1)
                            {
                                answer.Append(new string(' ', cel));
                                if (j < ost)
                                {
                                    answer.Append(" ");
                                }
                            }
                        }
                        //answer.Append($"{Environment.NewLine}");
                    }
                }
                b = new string[0];
            }
            _output = answer.ToString();
        }

        public override string ToString()
        {
            return _output;
        }
    }
}
