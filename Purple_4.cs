﻿using System;
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
                int j = 0;
                bool isCode = false;
                for (; j<_code.Length; j++)
                {
                    if (_input[i] == _code[j].Item2)
                    {
                        isCode = true;
                        break;
                    }
                }
                if (!isCode)
                {
                    answer.Append(_input[i]);
                }
                else
                {
                    answer.Append(_code[j].Item1);
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
