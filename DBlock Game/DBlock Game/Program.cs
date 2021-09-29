using System;

namespace DBlock_Game
{
    class Program
    {

        static void Main()
        {



            Console.WriteLine("Hello World!");
<<<<<<< HEAD

            Menu();
=======
            
           IntroCutscene();
>>>>>>> refs/remotes/origin/master
        }
        //Menu screen ascii
        public static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(@"

           ▄████████  ▄████████    ▄████████    ▄███████▄    ▄████████    ▄██████▄     ▄████████    ▄████████  ▄████████    ▄████████ 
          ███    ███ ███    ███   ███    ███   ███    ███   ███    ███   ███    ███   ███    ███   ███    ███ ███    ███   ███    ███ 
          ███    █▀  ███    █▀    ███    ███   ███    ███   ███    █▀    ███    █▀    ███    ███   ███    ███ ███    █▀    ███    █▀  
          ███        ███          ███    ███   ███    ███  ▄███▄▄▄      ▄███         ▄███▄▄▄▄██▀   ███    ███ ███         ▄███▄▄▄     
        ▀███████████ ███        ▀███████████ ▀█████████▀  ▀▀███▀▀▀     ▀▀███ ████▄  ▀▀███▀▀▀▀▀   ▀███████████ ███        ▀▀███▀▀▀     
                 ███ ███    █▄    ███    ███   ███          ███    █▄    ███    ███ ▀███████████   ███    ███ ███    █▄    ███    █▄  
           ▄█    ███ ███    ███   ███    ███   ███          ███    ███   ███    ███   ███    ███   ███    ███ ███    ███   ███    ███ 
         ▄████████▀  ████████▀    ███    █▀   ▄████▀        ██████████   ████████▀    ███    ███   ███    █▀  ████████▀    ██████████ 
                                                                                        
");
            Console.WriteLine("                                                         ╔════════════════════════╗");
            Console.WriteLine("                                                         ║                        ║");
            Console.WriteLine("                                                         ║    PRESS 1 START GAME  ║");
            Console.WriteLine("                                                         ║                        ║");
            Console.WriteLine("                                                         ║    PRESS 2 LOAD SAVE   ║");
            Console.WriteLine("                                                         ║                        ║");
            Console.WriteLine("                                                         ║    PRESS 3 EXIT GAME   ║");
            Console.WriteLine("                                                         ║                        ║");
            Console.WriteLine("                                                         ╚════════════════════════╝");
            Console.ReadLine();
            Console.Clear();

        }
        public static Boolean keyboardshield = false;
        public static Boolean mousenunchuck = false;
        public static Boolean screwdriver = false;
        public static Boolean hdmichain = false;
        public static Boolean keybgun = false;


        /** a Struct for desks if anyone needs to use one for their room */
        public struct Desk
        {
            public string drawer1;
            public string drawer2;
            public string drawer3;
            public string topofdesk;
            public string note;
        }

        //public static string text;

        public static void IntroCutscene()
        {
            //color sheet
            //Player/thoughts = white

            //joy = purple

            //vaughn = red 


            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");

            Console.Write("║");
            Console.Write("Today is october 1st, a friday. Its currently about 7:50am, I really don't like these 8am days.                      ");
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();




            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");

            Console.Write("║");
            Console.Write("I make my way to my math class and take my seat near the back. Most people are here already                          ");
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");

            Console.Write("║");
            Console.Write("joy's already here, somethings wrong                                                                                 ");
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");

            Console.Write("║");
            Console.Write("start class, binary question happens, joy short circuits                                                             ");
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");

            Console.Write("║");
            Console.Write("we walk over and see what happened                                                                                   ");
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");
            
            Console.Write("║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("vaughn comes in, he tells us to leave the room                                                                       ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");

            Console.Write("║");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Vaughn:  Everyone out! Now!                                                                       ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();

            //enter building
            //enter homeroom

            //dialouge
            //something happens
            //kicked out of homeroom

            TextBox("test", ConsoleColor.Magenta);



            //homeroom is locked

            //now in north hallway

            

            NorthHallway();

        }

        public static void TextBox(string text, ConsoleColor color)
        {

            string dialouge;
            ConsoleColor textColor;

            dialouge = text;
            //"Joy: I hope you finished your binary homework";

            textColor = color;

            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╗");

            Console.Write("║");
            Console.ForegroundColor = textColor;

            Console.Write($"{dialouge}");
            for (int i = 0; i < 117 - dialouge.Length; i++)
                Console.Write(" ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("║");

            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("║                                                                                                                     ║");
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ReadLine();
            Console.Clear();


        }

        public static void NorthHallway()
        {
            //start of game

            //basic info
        }

        public static void CodeRoom1()
        {
            /*
            Console.WriteLine(" ");
            Console.ReadLine();
            Console.Clear();
            */
            string userAnswer;

            //enter room info
            Console.WriteLine("I enter room D202. Theres no one in here. ");
            Console.ReadLine();
            Console.Clear();

            //look around?



            Console.Write("What would you like to do:");

            userAnswer = Console.ReadLine(); //user answer

            //view
            Console.Write("What would you like to look at: ");
            userAnswer = Console.ReadLine();
            switch (userAnswer)
            {
                case "1":
                case "whiteboard": //view whiteboard
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "2":
                case "room":
                    Console.WriteLine("There isn't much out of the ordinary here. Its just a regular classroom. There are about 20 desks all facing a whiteboard");
                    Console.WriteLine("Theres also a teachers desk at the front of the room");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                case "3":
                case "teachers desk":
                    Console.WriteLine(" ");
                    Console.ReadLine();
                    Console.Clear();
                    break;

                    default:
                        Console.WriteLine("didn't understand that command");
                        break;
            }


            //leave room
            Console.WriteLine("I leave the room");
            Console.ReadLine();
            Console.Clear();

            //help
            Console.WriteLine("List of commands");
            Console.WriteLine("When propted to, type these commands in and press enter");
            Console.WriteLine("Search: ");
            Console.WriteLine("View: view an area/object, view room is a good option when you're stuck");
            Console.WriteLine("Use: ");
            Console.WriteLine("Leave: Leave the room you're currently in");

            Console.ReadLine();
            Console.Clear();


            Console.ReadLine();
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

            /* joys desk and the options for searching */
            Desk joysdesk;
            joysdesk.drawer1 = "You have found a key 0###";
            joysdesk.drawer2 = "You have found a Keyboard shield";
            joysdesk.drawer3 = "This draw is empty";
            joysdesk.topofdesk = " There appears to be a a few family photos, her laptop isnt here but there is a note sticking out, as well as 3 draws.";
            joysdesk.note = " Hey Joy, Bombay club is meeting in break room dont forget your code 7";

            Console.Clear();
            Console.WriteLine("You have arrived in joys office");
            Console.WriteLine("there is her desk on one side of the room, a window overlooking the construction workers and a poster on the wall. nothing else of notice");
            Console.WriteLine("what would you like to do?");

          
  
            /* a do while loop to continue running until a player decides to leave the room
             */
            do
            {
                // options list for anyone that wants to test code later on
                Console.WriteLine("options 1 2 3 4");
                temp = Console.ReadLine();
                choices = Convert.ToInt32(temp);
                // switch case to run through the multiple choices
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

                        /** a do while loop asking if the player would like to search the area of the desk
                         * as well a while loop to run through the options if they do want to search the area
                         * Switch case to deal with the players options'
                         */
                        do
                        {
                            Console.WriteLine("would you like to search (y or n)");
                            temp = Console.ReadLine();
                            search = temp;

                            while (search == "y")
                            {
                                Console.WriteLine("What would you like to search? \n 1: first draw \n 2: second draw" +
                                    "\n 3: third draw  \n 4: Note on desk \n 5: leave");
                                temp = Console.ReadLine();
                                choice = Convert.ToInt32(temp);

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
                                    case 5:
                                        search = "n";
                                        break;
                                }
                            }
                        } while (search == "y");
                        break;
                    case 4:
                        choices = 4;
                        WestHallWay();
                        break;
                }
            } while (choices != 4);

        }

        public struct Cabin
        {
            public string cabin1;
            public string cabin2;
            public string cabin3;
            public string cabin4;
        }
        public struct desks
        {
            public string topdesk;
            public string drawer1;
            public string drawer2;
            public string drawer3;
            public string drawer4;
        }

        public static void WestCode()
            /* a method for calling the classroom on the westwing. This room will have another code to the end boss room
             * a do while loop will be used to give player the room layout and if they want to search or leave room
             */
        {
         
            do
            {
                Console.WriteLine("What would you like to do?");
                temp = Console.ReadLine();
                choices = temp;
                
                switch (choices)
                {
                    case "1":
                        stay = "n";
                        WestHallWay();
                        
                        break;

                    case "2":
                        
                        Console.WriteLine("You have turned on the lights, Congrats");
                        Console.WriteLine(" In the room you have found a desks and computers");
                        Console.WriteLine("What would you like to do?");

                        do
                        {
                            temp = Console.ReadLine();

                            switch (temp)
                            {
                                case "1":
                                    search = "n";
                                    break;
                                case "2":
                                    Console.WriteLine($"You decide to take a look at the desk {randomdesk.topofdesk}");
                                    do
                                    {
                                        Console.WriteLine("What would you like to do?");


                                        switch (temp)
                                        {
                                            case "1":
                                                desksearch = "n";
                                                break;

                                            case "2":
                                                Console.WriteLine($"You search first drawer  {randomdesk.drawer1}");
                                                Console.WriteLine("Press enter to continue");
                                                Console.ReadLine();
                                                break;
                                            case "3":
                                                Console.WriteLine($"You search first drawer  {randomdesk.drawer2}");
                                                Console.WriteLine("Press enter to continue");
                                                Console.ReadLine();
                                                break;
                                            case "4":
                                                Console.WriteLine($"You search first drawer  {randomdesk.drawer3}");
                                                Console.WriteLine("Press enter to continue");
                                                Console.ReadLine();
                                                break;
                                        }
                                    } while (desksearch == "y");
                                    break;
                            }
                        } while (search == "y");
                        break;

            

            // a method back to the westwinghall to be placed here
        }

    }
}

