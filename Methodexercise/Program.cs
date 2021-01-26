using System;

namespace Methodexercise
{
    class Program
    {
        public static int Addition(int x, int Y)
        {
            var answer = x + Y;
            return answer;
        }
            public static int multiply(int x, int Y)
            {
                var answer = x * Y;
                return answer;


            }
        static void Main(string[] args)
        {
            var dvds = Addition(25, 45);
            Console.WriteLine(dvds);

            var balls = multiply(25, 45);
            Console.WriteLine(balls);


            Console.WriteLine("Hello, What is your first name?");
            var userFirstName = Console.ReadLine();

            Console.WriteLine($"{userFirstName} I would like to write a short story about you. Would you mind answering a few quick questions?");
            var userReply = Console.ReadLine();

            Console.WriteLine($"What is your last name {userFirstName}? ");
            var userLastName = Console.ReadLine();
            

            Console.WriteLine($"{userFirstName} Are you a Mister or Miss or Misses?");
            var sex = Console.ReadLine();
           

            Console.WriteLine($"What is your favorite color {userFirstName}?");
            var color = Console.ReadLine();

            Console.WriteLine($"What kind of pet do you have {userFirstName}?");
            var pet = Console.ReadLine();

            Console.WriteLine($"What is your pets name {userFirstName}?");
            var petName = Console.ReadLine();

            Console.WriteLine($"What is your favorite song {userFirstName}?");
            var song = Console.ReadLine();

            Console.WriteLine($"Finally {userFirstName}, what vehicle do you drive?");
            var car = Console.ReadLine();

            Console.WriteLine($"There is a {sex} named {userFirstName}");
            Console.WriteLine($"Your last name is {userLastName} and some say that it is hard to pronounce");
            Console.WriteLine($"{userFirstName} has a {pet} named {petName} It is said {userFirstName} and {petName} are Best buds!");
            Console.WriteLine($"{petName} likes to ride shotgun while {userFirstName} drives the  {car} ");
            Console.WriteLine($"And all the while they are listening to {"song"}");
            
        }
    }
}
