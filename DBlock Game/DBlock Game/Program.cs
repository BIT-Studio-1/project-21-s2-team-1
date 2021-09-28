using System;

namespace DBlock_Game
{
    class Program
    {

        static void Main()
        {



            Console.WriteLine("Hello World!");
        }
        public static Boolean keyboardshield = false;


        /** a Struct for desks if anyone needs to use one for their room */
        public struct Desk
        {
            public string drawer1;
            public string drawer2;
            public string drawer3;
            public string topofdesk;
            public string note;
        }
        
        /** Method for joys Office 
         * still needing a method call to leave room
         * method calling for a help menu for player
         */
        public static void JoysOffice()
        {
            int choice;
            int choices;
            string temp;
            string search = "n";

            /** joys desk and the options for searching */
            Desk joysdesk;
            joysdesk.drawer1 = "key 0###";
            joysdesk.drawer2 = "You have found a Keyboard shield";
            joysdesk.drawer3 = "This draw is empty";
            joysdesk.topofdesk = " There appears to be a a few family photos, her laptop isnt here but there is a note sticking out, as well as 3 draws.";
            joysdesk.note = " Hey Joy, Bombay club is meeting in break room dont forget your code 7";


            Console.WriteLine("You have arrived in joys office");
            Console.WriteLine("there is her desk on one side of the room, a window overlooking the construction workers and a poster on the wall. nothing else of notice");
            Console.WriteLine("what would you like to do?");
            temp = Console.ReadLine();
            choices = Convert.ToInt32(temp);
            do
            {
                switch (choices)
                {
                    case 1:
                        Console.WriteLine("You have Searched the poster, there appears to be a picture of vaughn and a robotic vaughn beside him");
                        Console.WriteLine("Press enter to return");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(" Looking out the window it appears to be a bright day. The loud noise of construction workers distracts you from noticing anything useful");
                        Console.WriteLine("Press enter to return");
                        Console.ReadLine();

                        break;
                    case 3:
                        Console.WriteLine($"You take a closer look at the desk. {joysdesk.topofdesk}");
                        Console.WriteLine("What would you like to do?");
                        temp = Console.ReadLine();
                        choice = Convert.ToInt32(temp);
                        /** need a way to loop back through the other options */
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("you search the first draw");
                                Console.WriteLine($"{joysdesk.drawer1}");
                                Console.WriteLine("Press enter to return");
                                Console.ReadLine();
                                break;
                            case 2:
                                if (keyboardshield == true)
                                {
                                    Console.WriteLine("You have already searched this draw");
                                    Console.WriteLine("Press enter to return");
                                    Console.ReadLine();
                                }
                                else
                                {
                                    Console.WriteLine("You search the second draw");
                                    Console.WriteLine($"{joysdesk.drawer2}");
                                    Console.WriteLine("Press enter to return");
                                    keyboardshield = true;
                                    Console.ReadLine();
                                }
                                break;
                            case 3:
                                Console.WriteLine($"{joysdesk.drawer3}");
                                Console.WriteLine("Press enter to return");
                                Console.ReadLine();
                                break;
                            case 4:
                                Console.WriteLine($"{joysdesk.note}");
                                Console.WriteLine("Press enter to return");
                                Console.ReadLine();
                                break;

                        }
                        break;
                    case 4:
                        // Leaving the room method will be places here eg ( WestWingHallWay())
                        break;
                }
            } while (search == "y");

        }

    }
}
