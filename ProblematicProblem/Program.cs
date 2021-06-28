using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
namespace ProblematicProblem
{
    public class Program 
    {
        System.Random rnd;        
        static bool cont = true;
        static List<string> activities = new List<string>() { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            string answer = Console.ReadLine();
            string upperAnswer;

            upperAnswer = answer.ToUpper();

            while (upperAnswer != "YES" && upperAnswer != "NO")
            {
                Console.WriteLine("Answer needs to be yes or no, please try again!");
                Console.WriteLine("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
                upperAnswer = Console.ReadLine().ToUpper();
            }

            if (upperAnswer == "YES")
            {

                Console.WriteLine();

                Console.Write("We are going to need your information first! What is your name? ");
                string userName = Console.ReadLine();

                Console.WriteLine();

                Console.Write("What is your age? ");
                int userAge = Int32.Parse(Console.ReadLine());

                Console.WriteLine();

                Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
                // bool seeList = bool.Parse(Console.ReadLine());
                string answer2 = Console.ReadLine();
                string upperAnswer2;

                upperAnswer2 = answer2.ToUpper();

                if (upperAnswer2 == "SURE")
                {
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                    Console.WriteLine();
                    Console.Write("Would you like to add any activities before we generate one? yes/no: ");
                    
                    string answer3 = Console.ReadLine().ToUpper();

                    bool addToList;
                    //addToList = bool.TryParse(answer3, out true);
                    

                   
                    
                    Console.WriteLine();

                    while (addToList = "YES".Equals(answer3))
                    {
                        Console.Write("What would you like to add? ");
                        string userAddition = Console.ReadLine();

                        activities.Add(userAddition);

                        Console.WriteLine();
                        Console.WriteLine("Would you like to add more? yes/no: ");
                        answer3 = Console.ReadLine().ToUpper();

                        //bool addToList = "YES".Equals(answer4);

                        //bool addToList2 = bool.Parse(Console.ReadLine());
                    }

                    Console.WriteLine("Your full list of activities are:");
                    foreach (string activity in activities)
                    {
                        Console.Write($"{activity} ");
                        Thread.Sleep(250);
                    }

                }

                while (cont)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Connecting to the database");

                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.Write("Choosing your random activity");

                    for (int i = 0; i < 9; i++)
                    {
                        Console.Write(". ");
                        Thread.Sleep(500);
                    }

                    Console.WriteLine();

                    Random rnd = new Random();

                    int randomNumber = rnd.Next(activities.Count);

                    string randomActivity = activities[randomNumber];

                    //List<string> randomActivity = new List<string> { activities[randomNumber] };
                    //List<string> randomActivity = new List<string> { };

                    foreach (string activity in activities.ToList())
                    {
                        if (userAge < 21 && activity == "Wine Tasting")
                        {


                            Console.WriteLine($"Oh no! Looks like you are too young to do {activity}");
                            Console.WriteLine("We need to pick something else!");

                            activities.Remove(activity);

                            //Random rng2 = new Random();

                            randomNumber = rnd.Next(activities.Count);

                            randomActivity = activities[randomNumber];

                            //activity = activities[randomNumber2];
                        }

                    }

                   

                    Console.WriteLine();
                    Console.Write($"Ah got it {userName}!  Your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
                    Console.WriteLine();
                    string answer4 = Console.ReadLine().ToUpper();

                    if (answer4 == "KEEP")
                    {
                        Console.WriteLine("Thank you for playing!");
                        cont = false;
                    }
                    else if (answer4 == "REDO")
                    {
                        Console.WriteLine("Restarting program");
                        for (int i = 0; i < 9; i++)
                        {
                            Console.Write(". ");
                            Thread.Sleep(500);
                        }
                        cont = true;
                        
                    }
                    //cont = bool.Parse(Console.ReadLine());
                }
            }
            else if (upperAnswer == "NO")
            {
                Console.WriteLine("Oh well, maybe next time!");
                
            }
            

            //bool cont = bool.Parse(Console.ReadLine());

        }
    }
}
