using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz
{
    class ChoiceQuestion : IQuestions
    {
        public int Moeilijkheidsgraad { get; set; }
        public string Category { get; set; }
        public string GetQuestion { get; set; }
        public string GetAnswer { get; set; }
        public List<AddChoice> addChoice = new List<AddChoice>();

        public void AddChoice(String answer)
        {

            AddChoice choice = new AddChoice(answer);
            addChoice.Add(choice);
        }

        public void SetQuestion()
        {
            Console.WriteLine(GetQuestion);
            int count = 1;
            foreach (var i in addChoice)
            {
                Console.WriteLine(count + ": "+ i.Answer);
                count++;
                
            }
            Console.WriteLine("Type in uw antwoord 1, 2, 3 of 4");
        }

        public String SetAnswer(string getal)
        {
            int m = Int32.Parse(getal);
            var answer = addChoice[m-1].Answer;
            return answer;
        }
    }


}
