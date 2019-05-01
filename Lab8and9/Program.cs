 using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8and9
{
   


    class Program
    {
        static void Main(string[] args)
        {
            string userContinue;
            Console.WriteLine("Welcome to our C# Class.");
            do
            {

                Console.WriteLine("Would you like to add another student? y/n");
                var addStudent = Console.ReadLine();
                if (addStudent == "y" || addStudent == "Y")
                {
                    goto AddStudentInfo;
                }


                Console.Write("Which student would you like to learn more about? \n (Enter a number between 1-5):  ");
                var studentSelection = Console.ReadLine();

                var studentSelectionValidate = 0;
                while (!int.TryParse(studentSelection, out studentSelectionValidate) || studentSelectionValidate < 1 || studentSelectionValidate > 5)
                {
                    Console.WriteLine("Invalid Selection. Please choose a number between 1 thru 5");
                    studentSelection = Console.ReadLine();
                }

                List<string> studentNumber = new List<string> { };
                studentNumber.Add("Mike");
                studentNumber.Add("Renee");
                studentNumber.Add("Tom");
                studentNumber.Add("Stacie");
                studentNumber.Add("Jen");

                Console.Write($"Student {studentSelection} is { studentNumber[studentSelectionValidate - 1]}.");
                Console.WriteLine($" What would you like to know about {studentNumber[studentSelectionValidate - 1]}?");

            GoAgain:
                Console.Write($"Please enter 'hometown' or 'favorite food' or 'pet': ");
                var moreInfo = Console.ReadLine();
                var h = "hometown";
                var f = "favorite food";
                var p = "pet";


                List<string> studentHomeTown = new List<string> { };
                studentHomeTown.Add("Grand Rapids");
                studentHomeTown.Add("Brighton");
                studentHomeTown.Add("Washington");
                studentHomeTown.Add("Westland");
                studentHomeTown.Add("Alaska");

                var studentFavoriteFood = new List<string> { };
                studentFavoriteFood.Add("Pizza");
                studentFavoriteFood.Add("Chicken");
                studentFavoriteFood.Add("Cheeseburgers");
                studentFavoriteFood.Add("Halibut");
                studentFavoriteFood.Add("Tacos");

                var studentPet = new List<string> { };
                studentPet.Add("Cat");
                studentPet.Add("Dog");
                studentPet.Add("Frog");
                studentPet.Add("Bird");
                studentPet.Add("Snake");

                if (string.Equals(moreInfo, h, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{studentNumber[studentSelectionValidate - 1]} is from  { studentHomeTown[studentSelectionValidate - 1]}.");
                    Console.WriteLine($"Would you like to know more about {studentNumber[studentSelectionValidate - 1]}?  y/n");
                    var knowMore = Console.ReadLine();
                    if (knowMore == "Y" || knowMore == "y")
                    {
                        goto GoAgain;
                    }
                }

                else if (string.Equals(moreInfo, f, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{studentNumber[studentSelectionValidate - 1]}'s favorite food is {studentFavoriteFood[studentSelectionValidate - 1]}.");
                    Console.WriteLine($"Would you like to know more about {studentNumber[studentSelectionValidate - 1]}?  y/n");
                    var knowMore = Console.ReadLine();
                    if (knowMore == "Y" || knowMore == "y")
                    {
                        goto GoAgain;
                    }
                }

                else if (string.Equals(moreInfo, p, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{studentNumber[studentSelectionValidate - 1]} has a {studentPet[studentSelectionValidate - 1]}.");
                    Console.WriteLine($"Would you like to know more about {studentNumber[studentSelectionValidate - 1]}?  y/n");
                    var knowMore = Console.ReadLine();
                    if (knowMore == "Y" || knowMore == "y")
                    {
                        goto GoAgain;
                    }
                }

                else
                {
                    Console.WriteLine("That data does not exist.");
                    goto GoAgain;
                }
                



                Console.WriteLine("Would you like to look up another student? y/n");
                userContinue = Console.ReadLine();

            } while (userContinue == "y" || userContinue == "Y");

            Console.WriteLine("Thank you");
        }

      
          

    }
}
