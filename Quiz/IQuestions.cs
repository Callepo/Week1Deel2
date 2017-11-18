using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
   public interface IQuestions
    {
        int Moeilijkheidsgraad { get; set; }
        String Category { get; set; }
        String GetQuestion { get; set; }
        String GetAnswer { get; set; }
        void SetQuestion();
        String SetAnswer(string getal);



    }
}
