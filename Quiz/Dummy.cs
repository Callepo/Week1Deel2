using System.Collections.Generic;

namespace Quiz
{
    class Dummy
    {
        List<IQuestions> questions = new List<IQuestions>();

        public Dummy()
        {

            OpenQuestion first = new OpenQuestion()
            {
                Moeilijkheidsgraad = 1,
                Category = "mensen",
                GetQuestion = "Hoe heet je ?",
                GetAnswer = "cliff"
            };
            OpenQuestion tweede = new OpenQuestion()
            {
                Moeilijkheidsgraad = 2,
                Category = "dieren",
                GetQuestion = "hoe heet je hond?",
                GetAnswer = "jego"
            };
            OpenQuestion derde = new OpenQuestion()
            {
                Moeilijkheidsgraad = 3,
                Category = "mensen",
                GetQuestion = "hoe oud ben je?",
                GetAnswer = "24"
            };
            OpenQuestion vierde = new OpenQuestion()
            {
                Moeilijkheidsgraad = 1,
                Category = "dingen",
                GetQuestion = "Op welke locatie zit je op school?",
                GetAnswer = "den haag"
            };
            OpenQuestion vijfde = new OpenQuestion()
            {
                Moeilijkheidsgraad = 2,
                Category = "dieren",
                GetQuestion = "Hoeveel poten heeft een hond?",
                GetAnswer = "4"
            };
            OpenQuestion zesde = new OpenQuestion()
            {
                Moeilijkheidsgraad = 3,
                Category = "dingen",
                GetQuestion = "Hoeveel meters is 1 km?",
                GetAnswer = "1000"
            };
            questions.Add(first);
            questions.Add(tweede);
            questions.Add(derde);
            questions.Add(vierde);
            questions.Add(vijfde);
            questions.Add(zesde);
        }

        public List<IQuestions> GetList()
        {
            return questions;
        }

    }
}
