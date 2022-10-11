using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace QuizShow_with_Csharp
{
    public class Program
    {
        private string answer;
        public string answers { get { return answer; } set { answer = value.ToUpper(); } }
       
        static void Main(string[] args)
        {


            Console.WriteLine("------------------------");
            Console.WriteLine("Welcome to Quiz Showww!");
            Console.WriteLine("------------------------");

            Console.Title = "Quiz Show";
            string name, surname;

            Console.Write("Name: ");
            name=Convert.ToString(Console.ReadLine());

            Console.Write("Surname: ");
            surname=Convert.ToString(Console.ReadLine());

            
            Console.WriteLine("After all of your answer, don't forget to press the Enter!");

            Console.WriteLine("We are starting. Please press the Enter!");

            Console.ReadLine();

            int answeristrue, answerisfalse, money;

            answeristrue = 0;
            answerisfalse = 0;
            money = 0;


            Console.WriteLine(" Question-1: How many people live in Turkey?");

            Program a1 = new Program();
            Program a2 = new Program();
            Program a3 = new Program();
            Program a4 = new Program();
            Program a5 = new Program();


            Console.Write(" \n A)50 million\n B)60 million\n C)70 million\n D)More than 80 million\n\nYour Answer: ");
            a1.answers = Convert.ToString(Console.ReadLine());

            if(a1.answers=="D")
            {
                answeristrue = answeristrue + 1;
                money = money + 1000;
                Console.WriteLine("\nCongratulations, your answer is true :)");
                Console.WriteLine("Please press the Enter button in order to see the other questions :)");
                Console.ReadLine();
            }
            else
            {
                answerisfalse = answerisfalse + 1;
                Console.WriteLine("\nOpss! Your answer is false :(");
                Console.WriteLine("Please press the Enter button in order to see the other questions :)");
                Console.ReadLine();
            }

            Console.WriteLine(" Question-2: What is the Capital city of Turkey?");
            

            Console.Write(" \n A)Ankara\n B)Istanbul\n C)Trabzon\n D)Antalya\n\nYour Answer: ");
            a2.answers = Convert.ToString(Console.ReadLine());

            if(a2.answers=="A")
            {
                answeristrue = answeristrue + 1;
                money= money + 2000;
                Console.WriteLine("\nCongratulations, your answer is true :)");
                Console.WriteLine("Please press the Enter button in order to see the other questions :)");
                Console.ReadLine();
            }
            else
            {
                answerisfalse = answerisfalse + 1;
                Console.WriteLine("\nOpss! Your answer is false :(");
                Console.WriteLine("Please press the Enter button in order to see the other questions :)");
                Console.ReadLine();
            }

            Console.WriteLine(" Question-3: Where is the biggest city in Turkey?");
            

            Console.Write(" \n A)Ankara\n B)Istanbul\n C)Konya\n D)Rize\n\nYour Answer: ");
            a3.answers=Convert.ToString(Console.ReadLine());

            if(a3.answers=="C")
            {
                answeristrue = answeristrue + 1;
                money = money + 3000;
                Console.WriteLine("\nCongratulations, your answer is true :)");
                Console.WriteLine("Please press the Enter button in order to see the other questions :)");
                Console.ReadLine();

            }
            else
            {
                answerisfalse = answerisfalse + 1;
                Console.WriteLine("\nOpss! Your answer is false :(");
                Console.WriteLine("Please press the Enter button in order to see the other questions :)");
                Console.ReadLine();
            }

            Console.WriteLine(" Question-4: Where is the Galata Tower?");

            Console.Write(" \n A)Bursa\n B)Istanbul\n C)Konya\n D)Hakkari\n\nYour Answer: ");
            a4.answers = Convert.ToString(Console.ReadLine());

            if (a4.answers == "B")
            {
                answeristrue = answeristrue + 1;
                money = money + 5000;
                Console.WriteLine("\nCongratulations, your answer is true :)");
                Console.WriteLine("Please press the Enter button in order to see the other question :)");
                Console.ReadLine();

            }
            else
            {
                answerisfalse = answerisfalse + 1;
                Console.WriteLine("\nOpss! Your answer is false :(");
                Console.WriteLine("Please press the Enter button in order to see the other question :)");
                Console.ReadLine();
            }

            Console.WriteLine(" Question-5: Where is the Anıtkabir?");

            Console.Write(" \n A)Antalya\n B)Istanbul\n C)Ankara\n D)Hakkari\n\nYour Answer: ");
            a5.answers = Convert.ToString(Console.ReadLine());

            if (a5.answers == "C")
            {
                answeristrue = answeristrue + 1;
                money = money + 10000;
                Console.WriteLine("\nCongratulations, your answer is true :)");
                Console.WriteLine("Please press the Enter button in order to see your results :)");
                Console.ReadLine();

            }
            else
            {
                answerisfalse = answerisfalse + 1;
                Console.WriteLine("\nOpss! Your answer is false :(");
                Console.WriteLine("Please press the Enter button in order to see your results :)");
                Console.ReadLine();
            }

            Console.WriteLine("------------------------");
            Console.WriteLine(" Your Results ");
            Console.WriteLine("------------------------");

            Console.WriteLine(" Name: " + name);
            Console.WriteLine(" Surname: " + surname);
            Console.WriteLine(" True Answers: " + answeristrue);
            Console.WriteLine(" False Answers: " + answerisfalse);
            Console.WriteLine(" Total Money: " + money);



            Console.ReadLine();
        }
    }
}
