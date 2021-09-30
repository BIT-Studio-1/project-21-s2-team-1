using System;

namespace DBlock_Game
{
    class Program
    {

        static void Main()
        {

            

            Console.WriteLine("Hello World!");
//<<<<<<< HEAD

            Menu();
//=======
            
           IntroCutscene();
//>>>>>>> refs/remotes/origin/master
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

        public static ConsoleColor Player = ConsoleColor.White;  // Using for textbox player/narrator dialogue
        public static ConsoleColor Vaughn = ConsoleColor.Red;  // Using for textbox vaughn dialogue
        public static ConsoleColor Joy = ConsoleColor.Magenta;  // Using for textbox joy dialogue



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

            TextBox("Today is october 1st, a friday. Its currently about 7:50am, I really don't like these 8am days.", Player, false);

            TextBox("test", Player, false);
            /*
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
            Console.Clear();*/


            TextBox("I make my way to my math class and take my seat near the back. Most people are here already", Player, false);
            
            TextBox("joy's already here, somethings wrong", Player, false);
            
            


            TextBox("start class, binary question happens, joy short circuit", Player, false);
            

            TextBox("we walk over and see what happened", Player, false);
            
            TextBox("Vaughn comes in.", Player, false);

            TextBox("Vaughn:  Everyone out!", Vaughn, false);

            //enter building
            //enter homeroom

            //dialouge
            //something happens
            //kicked out of homeroom

            TextBox("we all leave", Player, false);


            //homeroom is locked

            //now in north hallway



            NorthHallway();

        }

        public static void TextBox(string text, ConsoleColor color, bool readLineBool)
        {

            string dialouge;
            ConsoleColor textColor;
            bool isReadLine;




            dialouge = text;
            textColor = color;
            isReadLine = readLineBool;

            Console.ForegroundColor = ConsoleColor.White;

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
            
            if (isReadLine == false)
            {
                Console.ReadLine();
                Console.Clear();
            }
            
            


        }

        public static void NorthHallway()
        {
            //start of game
            Console.WriteLine("north hallway");
            Console.ReadLine();

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
            TextBox("You have arrived in joys office", Player, false);
            TextBox("there is her desk on one side of the room, a window overlooking the construction workers and a poster on the wall. nothing else of notice", Player, false);
            



            /* a do while loop to continue running until a player decides to leave the room
             */
            do
            {
                TextBox("what would you like to do?", Player, false);
                // options list for anyone that wants to test code later on
                TextBox("what would you like to do?\n1:Poster\n2:Window\n3:Desk\n4:Leave", Player, true);
                temp = Console.ReadLine();
                Console.Clear();
                choices = Convert.ToInt32(temp);
                // switch case to run through the multiple choices
                switch (choices)
                {
                    case 1:
                        TextBox("You have Searched the poster, there appears to be a picture of vaughn and a robotic vaughn beside him",Player,false);
                        Console.ReadLine();
                        break;
                    case 2:
                        TextBox(" Looking out the window it appears to be a bright day. The loud noise of construction workers distracts you from noticing anything useful", Player,false);
                        Console.ReadLine();

                        break;
                    case 3:
                        TextBox($"You take a closer look at the desk. {joysdesk.topofdesk}", Player,false);

                        /** a do while loop asking if the player would like to search the area of the desk
                         * as well a while loop to run through the options if they do want to search the area
                         * Switch case to deal with the players options'
                         */
                        do
                        {
                            TextBox("would you like to search this desk (y or n)",Player,true);
                            temp = Console.ReadLine();
                            search = temp;
                            Console.Clear();

                            while (search.ToLower() == "y")
                            {
                                TextBox("What would you like to search? \n 1: first draw \n 2: second draw" +
                                    "\n 3: third draw  \n 4: Note on desk \n 5: leave", Player,true);
                                temp = Console.ReadLine();
                                choice = Convert.ToInt32(temp);
                                Console.Clear();

                                switch (choice)
                                {
                                    case 1:
                                        TextBox("you search the first draw",Player,false);
                                        TextBox($"{joysdesk.drawer1}", Player, false);
                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        if (keyboardshield == true)
                                        {
                                            TextBox("You have already searched this draw", Player,false);
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            TextBox("You search the second draw", Player,false);
                                            TextBox($"{joysdesk.drawer2}", Player,false);
                                            keyboardshield = true;
                                            Console.ReadLine();
                                        }
                                        break;
                                    case 3:
                                        TextBox($"{joysdesk.drawer3}", Player,false);
                                        Console.ReadLine();
                                        break;
                                    case 4:
                                        TextBox($"{joysdesk.note}", Player,false);
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
                        
                        break;
                }
            } while (choices != 4);
            WestHallWay();
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

            Desk randomdesk;
            randomdesk.drawer1 = "Bottles of Scrape Grace gin";
            randomdesk.drawer2 = "Key #1##";
            randomdesk.drawer3 = "Another note referencing for the teachers to go to the bombay club meet up in the break room. the code is scratched out";
            randomdesk.topofdesk = "You find a computer without the log in though it is of no use. There is a 3d printer waiting for use on the desk. You also find 3 draws";
            randomdesk.note = "there is no note";
            string temp;
            string choices = "y";
            string search = "y";
            string desksearch = "y";
            Console.Clear();
            TextBox("You have entered the Classroom D212", Player,false);
            TextBox("You enter the room and the blinds are shut", Player,false);
            TextBox("There is nothing put darkness as far as you can see", Player,false);

            string stay = "y";
            do
            {
                TextBox("What would you like to do? 1: Leave 2: lights", Player,true);
                temp = Console.ReadLine();
                choices = temp;
                Console.Clear();

                switch (choices)
                {
                    case "1":
                        stay = "n";
                        

                        break;
                    case "2":

                        TextBox("You have turned on the lights, Congrats", Player,false);
                        TextBox(" In the room you have found a desks and computers", Player,false);
                        
                        do
                        {
                            TextBox("What would you like to do? 1:leave 2 search desk", Player,true);
                            temp = Console.ReadLine();
                            Console.Clear();
                            switch (temp)
                            {
                                case "1":
                                    search = "n";
                                    break;
                                case "2":
                                    TextBox($"You decide to take a look at the desk {randomdesk.topofdesk}",Player,false);
                                    do
                                    {
                                        TextBox("What would you like to do? "+" 1:leave 2: first draw 3: second draw 4: third draw", Player,true);
                                        temp = Console.ReadLine();
                                        
                                        switch (temp)
                                        {
                                            case "1":
                                                desksearch = "n";
                                                break;
                                            case "2":
                                                TextBox($"You search first drawer  {randomdesk.drawer1}", Player,false);
                                                Console.ReadLine();
                                                break;
                                            case "3":
                                                TextBox($"You search second drawer  {randomdesk.drawer2}", Player,false);
                                                Console.ReadLine();
                                                break;
                                            case "4":
                                                TextBox($"You search third drawer  {randomdesk.drawer3}", Player,false);
                                                Console.ReadLine();
                                                break;
                                        }
                                    } while (desksearch == "y");
                                    break;
                            }
                        } while (search == "y");
                        break;
                }

            } while (stay == "y");
            WestHallWay();
        }
        public static void WestHallWay()
        {
            string attempts = "y";
            string temp;
            Console.Clear();
            Console.WriteLine();
            TextBox("You enter the west hallway you have another 2 rooms you can enter.", Player,false);
            TextBox("There is a keypad that you have never noticed before beside a vending machine you normally get your lunch from.", Player,false);
            TextBox("there is Joys office first room to the right as you move down \n There is the last classroom for this hallway 2nd room to the right", Player,false);
            TextBox("The hallway bends round the corner leading into the south hallway", Player,false);
            TextBox("What would you like to do now?\n " +" 1: north hallway \n 2: Joys Office \n 3: Classroom \n 4: southhallway", Player,true);
            temp = Console.ReadLine();
            Console.Clear();
            switch (temp)
            {
                case "1":
                    NorthHallway();
                    break;
                case "2":
                    JoysOffice();
                    break;
                case "3":
                    WestCode();
                    break;
                case "4":
                    SouthHallway();
                    break;
                case "5":

                    TextBox("You approach the key pad, try entering a key", Player,true);
                    temp = Console.ReadLine();
                    Console.Clear();
                    if (temp == "0111")
                    {
                        //BreakRoom();
                    }
                    else
                    {
                        TextBox("The machine beeps and nothing else happens (the code you have entered is wrong)",Player,false);
                    }
                    break;

            }


        }
        public static void SouthHallway()
        {
            String temp;
            TextBox("You have entered the Southern hall way", Player,false);
            TextBox("You see another vending machine at the end of the hall way as well as a 2 more classrooms", Player,false);
            TextBox("Looking at the vending machine it doesnt look normal but appears to be able to save game in some way", Player,false);
            TextBox("The 2 classrooms to the right look like normal classrooms", Player,false);
            TextBox("What would you like to do \n"+ "options 1:Classroom 2:Storage Room 3: SaveGame 4: Go back", Player,true);
            temp = Console.ReadLine();
            switch (temp)
            {
                case "1":
                    //classroom 1 method
                    break;
                case "2":
                    janitorsroom();
                    break;
                case "4":
                    WestHallWay();
                    break;
                case "3":
                    //Save Game Method
                    break;
                    
            }
        }
        public static void janitorsroom()
        {
            string temp, search = "n";
            int option, options;

            Cabin janitorscabin;
            janitorscabin.cabin1 = "You have found a keyb gun";
            janitorscabin.cabin2 = "You have found a mousenunchuck";
            janitorscabin.cabin3 = "There is nothing in here";
            janitorscabin.cabin4 = "You have found a hdmichain";

            desks janitorsdesk;
            janitorsdesk.topdesk = "There a muffin and a cup of coffee";
            janitorsdesk.drawer1 = "There is nothing in here";
            janitorsdesk.drawer2 = "You have found a key";
            janitorsdesk.drawer3 = "You have found a mug";
            janitorsdesk.drawer4 = "You have found a lighter";

            Console.WriteLine("Welcome to the janitors room");
            Console.WriteLine("There is a desk in the middle of the room, two cabin on the left side, two cabin on the right side, a window overlooking the carpark and a picture on the wall.");
            Console.WriteLine("What would you like to look at ");
            temp = Console.ReadLine();

            Console.WriteLine("options 1 2 3 4 5 6 7 8");
            temp = Console.ReadLine();
            option = Convert.ToInt32(temp);
            do
            {
                switch (option)
                {
                    case 1:
                        Console.WriteLine("You have looked at the poster, there appears to be a picture of the janitor's family photo");
                        Console.WriteLine("Press enter to return");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine(" Looking out the window it appears to be a bright day in the parking lot. The loud noise of construction workers distracts you from noticing anything useful");
                        Console.WriteLine("Press enter to return");
                        Console.ReadLine();

                        break;
                    case 3:
                        Console.WriteLine($"You take a closer look at the desk. {janitorsdesk.topdesk}");
                        Console.WriteLine("What would you like to do?");

                        do
                        {
                            while (search == "y")
                            {
                                Console.WriteLine("What would you like to search? \n 1: first drawer \n 2: second drawer \n 3: third drawer  \n 4: fouth drawer \n 5: first cabin on the right \n 6: second cabin on the right \n 7: first cabin on the left \n 8: second cabin on the left \n 9: leave");
                                temp = Console.ReadLine();
                                options = Convert.ToInt32(temp);

                                switch (options)
                                {

                                    case 1:
                                        Console.WriteLine("you search the first draw");
                                        Console.WriteLine($"{janitorsdesk.drawer1}");
                                        Console.WriteLine("Press enter to return");
                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        Console.WriteLine("you search the second draw");
                                        Console.WriteLine($"{janitorsdesk.drawer2}");
                                        Console.WriteLine("Press spacebar to return");
                                        Console.ReadLine();
                                        break;
                                    case 3:
                                        Console.WriteLine("you search the third draw");
                                        Console.WriteLine($"{janitorsdesk.drawer3}");
                                        Console.WriteLine("Press spacebar to return");
                                        Console.ReadLine();
                                        break;
                                    case 4:
                                        Console.WriteLine("you search the fouth draw");
                                        Console.WriteLine($"{janitorsdesk.drawer4}");
                                        Console.WriteLine("Press spacebar to return");
                                        break;
                                    case 5:
                                        Console.WriteLine("You search the first cabin on the right");
                                        Console.WriteLine($"{janitorscabin.cabin1}");
                                        Console.WriteLine("Press spacebar to return");
                                        break;
                                    case 6:
                                        Console.WriteLine("You search the second cabin on the right");
                                        Console.WriteLine($"{janitorscabin.cabin2}");
                                        Console.WriteLine("Press spacebar to return");
                                        break;
                                    case 7:
                                        Console.WriteLine("You search the first cabin on the left");
                                        Console.WriteLine($"{janitorscabin.cabin3}");
                                        Console.WriteLine("Press spacebar to return");
                                        break;
                                    case 8:
                                        Console.WriteLine("You search the second cabin on the left");
                                        Console.WriteLine($"{janitorscabin.cabin4}");
                                        Console.WriteLine("Press spacebar to return");
                                        break;
                                    case 9:
                                        search = "n";
                                        break;
                                }
                            }
                        } while (search == "y");
                        break;
                    case 4:
                        break;
                }
            } while (option != 4);

        }
    }
}




