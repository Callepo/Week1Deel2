﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class OpenQuestion : IQuestions
    {
        public int Moeilijkheidsgraad { get; set; }
        public string Category { get; set; }
        public string GetQuestion { get; set; }
        public string GetAnswer { get; set; }

        public String SetAnswer(String getal)
        {
            throw new NotImplementedException();
        }

        public void SetQuestion()
        {
            throw new NotImplementedException();
        }
    }
}
