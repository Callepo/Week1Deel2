using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome bij the Quiz");
            
            IEnumerable<IQuestions> Selectedquestions = null;
            Dummy dummy = new Dummy();
           
            var cat = dummy.GetList().GroupBy(o => new { o.Category })
                                       .Select(o => o.FirstOrDefault());
            Console.WriteLine("Er zijn in totaal " + cat.Count() + " Categorien" );
            foreach (var i  in cat)
            {
                Console.Write("{0}\t", i.Category);
            }
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Kies uw Category of type all voor alles");
            var selectCategory = Console.ReadLine();


            if (dummy.GetList().Where(item => item.Category == selectCategory) != null)
            {
                Selectedquestions = dummy.GetList().Where( q => q.Category.Equals(selectCategory));
            }
            if (selectCategory.Equals("all"))
            {
                Console.WriteLine("Wilt u vragen van makkelijk naar moeilijk of gesorteerd op category ?");
                Console.WriteLine("Type 1 voor moeilijkheidswaard of 2 voor category");

                var selectorder = Console.ReadLine();

                while (true) { 
                if (selectorder.Equals("1"))
                {
                    var orderlist = dummy.GetList().OrderBy(o => o.Moeilijkheidsgraad);
                    Selectedquestions = orderlist;
                        Console.WriteLine("moeilijkheidswaard");
                        Console.WriteLine();
                        break;
                    }


                if (selectorder.Equals("2"))
                {
                    var orderlist = dummy.GetList().OrderBy(o => o.Moeilijkheidsgraad);
                    Selectedquestions = orderlist;
                        Console.WriteLine("Category");
                        Console.WriteLine();
                        break;
                    }
                    selectorder = Console.ReadLine();
                }

            }

            foreach (var i in Selectedquestions)
            {
                Console.WriteLine(i.GetQuestion);

                var answer = Console.ReadLine();

                if (answer.Equals(i.GetAnswer))
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect");
                    Console.WriteLine(i.GetAnswer);
                }
                Console.WriteLine();
            }
           
        }
    }
}
