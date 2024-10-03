namespace Logic_and_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable
            string playerName = "adventurer";
            string userChoice = "NONE";

            //Program Start
            Console.Write("Welcome to the jungle\nWe got fun and games\nWe got everything you want\nHoney, we know the names\n\n");
            Console.WriteLine("Wait... I don't actually know your name.");
            Console.WriteLine("What is your name?");
            Console.WriteLine("[Please enter your name, then press 'ENTER' on the keyboard]");

            //User input
            playerName = Console.ReadLine();
            Console.WriteLine("\nWelcome to the jungle " + playerName +"!");

            //Continue the story
            Console.WriteLine("" +
                "We approach an opening in the jungle\n" +
                "There is a cave entrance on the left...\n" +
                "And a new trail on the right.\n");

            Console.WriteLine("Which path do you choose?");
            Console.WriteLine("Type 'left' to choose the cave on the left or type 'right' to choose the trail on the right.");

            //more user input
            userChoice = Console.ReadLine();
            Console.WriteLine("\nYou chose: " + userChoice+"\n");

            if (userChoice == "left")
            {
                //Go to the left
                Console.WriteLine("You enter the cave...and you eventually find the exit and leave the jungle. Congrats on surviving! :)");
            }else if (userChoice == "right") 
            {
                //Go to the right
                Console.WriteLine("You follow the trail...and you end up in a village. The villagers turn out to be cannibals!! You did not survive. :(");
            } else 
            {
                //Typed in something else

                userChoice = "NONE";
                Console.WriteLine("THAT'S NOT A CHOICE!!");

                while (userChoice != "left" && userChoice != "right" && userChoice != "up")
                {
                    Console.WriteLine("Please enter either 'left', 'right', or our now super secret answer of 'up'.");
                    userChoice = Console.ReadLine();
                    Console.WriteLine("\nYou chose: " + userChoice + "\n");
                }

                if (userChoice == "left")
                {
                    //Go to the left
                    Console.WriteLine("You enter the cave...and you eventually find the exit and leave the jungle. Congrats on surviving! :)");
                }
                else if (userChoice == "right")
                {
                    //Go to the right
                    Console.WriteLine("You follow the trail...and you end up in a village. The villagers turn out to be cannibals!! You did not survive. :(");
                }
                else if (userChoice == "up")
                {
                    Console.WriteLine("You suddenly get rocket boots and fly up...But you can't control them and you fly into space and\neventually explode on the sun. |_(-_-)_/");
                }
                else 
                {
                    Console.WriteLine("You realize that you were never in the Jungle and that you've been asleep in your bed this whole time.");
                }
       
            }
        }
    }
}
