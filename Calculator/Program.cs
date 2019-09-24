using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string firstName;
            string lastName;
            int userAge;
            double userWeight;
            double userHeight;
            double userHeightR;
            double userHeightS;
            double KMI;  //kasutan double tüüpi, et saaks hiljem ümardada
            double kmiR;

            Console.WriteLine("What is your first name?");
            firstName = Console.ReadLine();
            Console.WriteLine("What is your last name?");
            lastName = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {firstName} {lastName} !");
            Console.WriteLine("Enter your age, please: ");
            userAge = Int32.Parse(Console.ReadLine());

            if (userAge >= 20 && userAge <= 65) //kui vanus jääb vahemikusse 20-65
            {
                Console.WriteLine("What is your weight in kg?"); //küsib kaalu
                userWeight = Int32.Parse(Console.ReadLine());
                Console.WriteLine("What is your height in cm?"); //küsib pikkust
                userHeight = Convert.ToDouble(Console.ReadLine());

                userHeightR = userHeight / 100; //pikkus jagatud 100, et saada meetridesse
                userHeightS = userHeightR * userHeightR; //pikkus ruudus
                KMI = userWeight / userHeightS;//KMI ei ole ümardatud
                kmiR = Math.Round(KMI, 2);// KMI koos round funktsiooniga

                if (kmiR < 16) //tervisele ohtlik alakaal
                {
                    Console.WriteLine($"Thank You! Be careful! Your KMI is {kmiR} ! You are morbidly underweight!");
                }

                else if (kmiR >= 16 && kmiR <= 18.5) //alakaal
                {

                    Console.WriteLine($"Thank You! Ohhh! Your KMI is {kmiR} ! You are underweight!");
                }

                else if (kmiR >= 18.6 && kmiR <= 25) //normaalkaal

                {

                    Console.WriteLine($"Thank You! Your KMI is {kmiR} ! Great! You are at normal weight!");
                }

                else if (kmiR >= 25.1 && kmiR <= 30) //ülekaal

                {

                    Console.WriteLine($"Thank You! Ohh! Your KMI is {kmiR} ! You are overweight!");
                }

                else if (kmiR >= 30.1 && kmiR <= 35) //rasvumine

                {

                    Console.WriteLine($"Thank You! Ohhh! Your KMI is {kmiR} ! You are severely overweight!");
                }

                else if (kmiR >= 35.1 && kmiR <= 40) //tugev rasvumine

                {
                    Console.WriteLine($"Thank You! Ohhh! Your KMI is {kmiR} ! You are morbidly overweight!");
                }

                else  // tervisele ohtlik rasvumine
                {

                    Console.WriteLine($"Thank You! Be careful! Your KMI is {kmiR} ! You are morbidly underweight!");
                }
            }

            else
            {

                Console.WriteLine("Sorry, your age should be between 20-60.");// kui vanus ei jää vahemikusse
            }




            Console.ReadLine();



        }
    }
}
