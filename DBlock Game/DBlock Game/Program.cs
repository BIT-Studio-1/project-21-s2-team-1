using System;
using System.IO;
using System.Threading;

namespace DBlock_Game
{
    class Program
    {

        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8; //prevents some ascii text from not showing

            Menu();
        }
        //Menu screen ascii
        public static void Menu()
        {
            Console.Clear();
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
            //switch to occompany the menu options

            string temp = Console.ReadLine();
            switch (temp)
            {
                case "1":
                    IntroCutscene();
                    break;
                case "2":
                    if (File.Exists($@"save.txt"))
                    {
                        Loadgame();
                        break;
                    }
                    else
                    {
                        TextBox("Save file not found", Player, false);
                        Menu();
                        break;
                    }
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Menu(); //runs menu function again if input is not 1, 2, or 3
                    break;
            }
            Console.Clear();


        }
        public static void Inventory()
        {
            if (keyboardshield == true)
            {
                Console.WriteLine("keyboard Shield");
            }
            if (mousenunchuck == true)
            {
                Console.WriteLine("Mouse Nunchuck");
            }
            if (screwdriver == true)
            {
                Console.WriteLine("Screwdriver");
            }
            if (hdmichain == true)
            {
                Console.WriteLine("HDMI Chain");
            }
            if (keycode1 == true)
            {
                Console.WriteLine("Key Number 0###");
            }
            if (keycode2 == true)
            {
                Console.WriteLine("Key Number #1##");
            }
            if (keycode3 == true)
            {
                Console.WriteLine("Key Number ##1#");
            }
            if (keycode4 == true)
            {
                Console.WriteLine("Key Number ###1");
            }
            //for the other switchws
            //case "inventory":
            //      Inventory();      
            //break;
        }
        public static bool keyboardshield = false, mousenunchuck = false, screwdriver = false, hdmichain = false; //inventory booleans (you can initialize multiple of the same datatype this way)

        public static bool keycode1 = false, keycode2 = false, keycode3 = false, keycode4 = false, joyCard = false;

        public static ConsoleColor Player = ConsoleColor.White, Vaughn = ConsoleColor.Red, Joy = ConsoleColor.Magenta; //text color for player, vaughn, and joy

        /** a Struct for desks if anyone needs to use one for their room */
        public struct Desk
        {
            public string drawer1;
            public string drawer2;
            public string drawer3;
            public string topofdesk;
            public string note;
        }

        public struct Cabin
        {
            public string cabin1;
            public string cabin2;
            public string cabin3;
            public string cabin4;
        }

        public struct Desks
        {
            public string topdesk;
            public string drawer1;
            public string drawer2;
            public string drawer3;
            public string drawer4;
        }

        //public static string text;

        public static void IntroCutscene()
        {
            TextBox("Today is october 1st, a friday. Its currently about 7:50am, I really don't like these 8am days.", Player, false);

            TextBox("I make my way to my math class and take my seat near the back. Most people are here already", Player, false);

            TextBox("Joy's already here, She has a blank look on her face almost like shes a robot. I guess she's tired too.", Player, false);

            TextBox("Joy quickly gets up from her desk and walks to the front of the class. She starts teaching us binary and everything seems fairly normal", Player, false);

            TextBox("She says a binary number and suddenly theres a loud spark sound and a bright flash. Suddenly joy is lying on the floor", Player, false);

            TextBox("We walk over and see what happened", Player, false);

            TextBox("Vaughn comes in with an angry look on his face", Player, false);

            TextBox("Vaughn: Everyone out!", Vaughn, false);

            TextBox("We all leave, But we're all still confused on what just happened.", Player, false);

            TextBox("and why was Vaughn so angry?", Player, false);

            //homeroom is locked

            //now in north hallway

            NorthHallway();

        }

        public static void TextBox(string text, ConsoleColor color, bool readLineBool)
        {
            Console.Clear();

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
            TextBox("I'm now in the the North hallway", Player, false);
            TextBox("Theres a billboard infront of me with various flyers and notes on it.", Player, false);
            TextBox("Theres also another classroom to my right", Player, false);
            TextBox("The hallway bends round the corner leading into the west hallway", Player, false);

            bool fail = false;

            do
            {
                TextBox("What should I do now? \n" + "║1: Enter Joy's Classroom\n║2: Check Billboard\n║3: Enter Other Classroom\n║4: Move to West Hallway", Player, true);

                string temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        TextBox("The room is locked, I wonder of vaughn is still in there", Player, false);
                        fail = true;
                        break;

                    case "2":
                        TextBox("I go up an look at the billboard, theres lots of random flyers I don't care about", Player, false);
                        TextBox("In the corner of the board is a note numbers on it that read 0###. This might help me figure out whats going on with the teachers", Player, false);
                        TextBox("I take the note of the wall and put it in my pocket", Player, false);
                        keycode1 = true;
                        fail = true; //if fail is true, the loop is ran again, taking us back to the hallway without the extra dialouge
                        break;

                    case "3":
                        fail = false;
                        NorthCode();
                        break;

                    case "4":
                        fail = false;
                        WestHallWay();//move to west hallway
                        break;

                    default:
                        fail = true;
                        break;
                }
            } while (fail == true);
        }

        public static void NorthCode()
        {

            TextBox("You have entered the Classroom D211", Player, false);
            TextBox("You enter the room but no ones here", Player, false);
            TextBox("", Player, false);

            bool stay = true;
            do
            {
                TextBox("What would you like to do? \n║1: Leave the room\n║2: Look desks \n║3: Look whiteboard", Player, true);
                string temp = Console.ReadLine();
                Console.Clear();

                switch (temp)
                {
                    case "1":
                        stay = false;
                        break;

                    case "2":
                        TextBox("In the room you have found a desks and computers", Player, false);
                        break;

                    case "3":
                        TextBox("I start inspecting the whiteboard, hoping to find something interesting. But the only thing here is github notes", Player, false);
                        TextBox("I turn around to go look elsewhere, but at the corner of my eye I see a small sticky note", Player, false);
                        TextBox("I go to look at the note, the note has a number on it and 3 #'s. ##1#", Player, false);
                        TextBox("This note seems important, I think I'll take it just incase", Player, false);
                        keycode3 = true;
                        break;
                }

            } while (stay == true);

            TextBox("I leave the classroom", Player, false);
            NorthHallway();
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
                        TextBox("You have Searched the poster, there appears to be a picture of vaughn and a robotic vaughn beside him", Player, false);
                        Console.ReadLine();
                        break;
                    case 2:
                        TextBox(" Looking out the window it appears to be a bright day. The loud noise of construction workers distracts you from noticing anything useful", Player, false);
                        Console.ReadLine();

                        break;
                    case 3:
                        TextBox($"You take a closer look at the desk. {joysdesk.topofdesk}", Player, false);

                        /** a do while loop asking if the player would like to search the area of the desk
                         * as well a while loop to run through the options if they do want to search the area
                         * Switch case to deal with the players options'
                         */
                        do
                        {
                            TextBox("would you like to search this desk (y or n)", Player, true);
                            temp = Console.ReadLine();
                            search = temp;
                            Console.Clear();

                            while (search.ToLower() == "y")
                            {
                                TextBox("What would you like to search? \n 1: first draw \n 2: second draw" +
                                    "\n 3: third draw  \n 4: Note on desk \n 5: leave", Player, true);
                                temp = Console.ReadLine();
                                choice = Convert.ToInt32(temp);
                                Console.Clear();

                                switch (choice)
                                {
                                    case 1:
                                        TextBox("you search the first draw", Player, false);
                                        TextBox($"{joysdesk.drawer1}", Player, false);
                                        keycode4 = true;
                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        if (keyboardshield == true)
                                        {
                                            TextBox("You have already searched this draw", Player, false);
                                            Console.ReadLine();
                                        }
                                        else
                                        {
                                            TextBox("You search the second draw", Player, false);
                                            TextBox($"{joysdesk.drawer2}", Player, false);
                                            keyboardshield = true;
                                            Console.ReadLine();
                                        }
                                        break;
                                    case 3:
                                        TextBox($"{joysdesk.drawer3}", Player, false);
                                        Console.ReadLine();
                                        break;
                                    case 4:
                                        TextBox($"{joysdesk.note}", Player, false);
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

        public static void WestCode()
        /* a method for calling the classroom on the westwing. This room will have another code to the end boss room
         * a do while loop will be used to give player the room layout and if they want to search or leave room
         */
        {

            TextBox("You have entered the Classroom D212", Player, false);
            TextBox("You enter the room and the blinds are shut", Player, false);
            TextBox("There is nothing put darkness as far as you can see", Player, false);

            bool stay = true;
            do
            {
                TextBox("What would you like to do? \n║1: Leave the room\n║2: Turn the lights on", Player, true);
                string temp = Console.ReadLine();
                Console.Clear();

                switch (temp)
                {
                    case "1":
                        stay = false;
                        break;

                    case "2":
                        TextBox("You have turned on the lights, Congrats", Player, false);
                        TextBox("In the room you have found a desks and computers", Player, false);

                        do
                        {
                            TextBox("What would you like to do? \n║1: Leave the room\n║2: search desk", Player, true);
                            temp = Console.ReadLine();
                            switch (temp)
                            {
                                case "1":
                                    stay = false;
                                    break;
                                case "2":
                                    TextBox("You decide to take a look at the desk", Player, false);
                                    TextBox("You find a computer without the log in though it is of no use. \nThere is a 3d printer waiting for use on the desk. You also find 3 drawers", Player, false);
                                    do
                                    {
                                        TextBox("What would you like to do? \n║1: Leave the room \n║2: Search first drawer \n║3: Search second drawer \n║4: Search third drawer", Player, true);
                                        temp = Console.ReadLine();

                                        switch (temp)
                                        {
                                            case "1":
                                                stay = false;
                                                break;
                                            case "2":
                                                TextBox("You search first drawer", Player, false);
                                                TextBox("Inside theres a few bottles of ScrapeGrace gin", Player, false);
                                                TextBox("I think I'll just leave them there", Player, false);
                                                break;
                                            case "3":
                                                TextBox("You search second drawer", Player, false);
                                                TextBox("Inside theres a note with numbers on it, The numbers read #1##", Player, false);
                                                TextBox("I take this note and put it in my pocket", Player, false);
                                                keycode2 = true;
                                                break;
                                            case "4":
                                                TextBox($"You search third drawer", Player, false);
                                                TextBox("inside theres a note telling the teachers to go to the bombay club meet up in the break room.", Player, false);
                                                break;
                                        }
                                    } while (stay == true);
                                    break;
                            }
                        } while (stay == true);
                        break;
                }

            } while (stay == true);

            TextBox("I turn the lights back off and leave the classroom", Player, false);
            WestHallWay();
        }

        public static void WestHallWay()
        {
            TextBox("You enter the west hallway you have another 2 rooms you can enter.", Player, false);
            TextBox("There is a keypad that you have never noticed before beside a vending machine you normally get your lunch from.", Player, false);
            TextBox("there is Joys office first room to the right as you move down \n There is the last classroom for this hallway 2nd room to the right", Player, false);
            TextBox("The hallway bends round the corner leading into the south hallway", Player, false);

            bool fail = false;

            do
            {
                TextBox("What should I do now?\n║1: Move to North hallway \n║2: Enter Joys Office \n║3: Enter Classroom \n║4: Move to South hallway \n║5: Use Keypad", Player, true);
                string temp = Console.ReadLine();

                switch (temp)
                {
                    case "1":

                        fail = false;
                        NorthHallway();
                        break;

                    case "2":
                        fail = false;
                        JoysOffice();
                        break;

                    case "3":
                        fail = false;
                        WestCode();
                        break;

                    case "4":
                        fail = false;
                        SouthHallway();
                        break;

                    case "5":
                        TextBox("You approach the key pad", Player, true);

                        if (keycode1 == true && keycode2 == true && keycode3 == true && keycode4 == true)
                        {
                            TextBox("I look through my bag and see all my notes", Player, false);
                            TextBox("Using these notes I enter into the keypad 0110", Player, false);
                            TextBox("The door opens! I walk into the teachers break room, unsure of what I'll find", Player, false);
                            BreakRoom();
                            fail = false;
                        }
                        else
                        {
                            TextBox("I try entering a code into the keypad but its no use", Player, false);
                            TextBox("The keypad makes an error sound and the screen turns red", Player, false);
                            TextBox("I guess I don't know what the code is, Maybe I should look around for a code", Player, false);
                            fail = true;
                        }

                        fail = true;
                        break;

                    default:
                        fail = true;
                        break;
                }

            } while (fail == true);
        }

        public static void SouthHallway()
        {
            TextBox("You have entered the Southern hall way", Player, false);
            TextBox("You see another vending machine at the end of the hall way as well as a 2 more classrooms", Player, false);
            TextBox("Looking at the vending machine it doesnt look normal but appears to be able to save game in some way", Player, false);
            TextBox("The 2 classrooms to the right look like normal classrooms", Player, false);

            bool fail = false;

            do
            {
                TextBox("What should I do now? \n" + "║1: Enter Classroom \n║2: Enter Storage Room \n║3: Use vending Machine (Save Game) \n║4: Move to West Hallway", Player, true);
                string temp = Console.ReadLine();

                switch (temp)
                {
                    case "1":
                        //classroom 1 method
                        fail = false;
                        break;

                    case "2":
                        Janitorsroom();
                        fail = false;
                        break;

                    case "3":
                        Savegame();
                        fail = true;
                        break;

                    case "4":
                        WestHallWay();
                        break;

                    default:
                        fail = true;
                        break;

                }
            } while (fail == true);
        }

        public static void SouthCode()
        {

            TextBox("You have entered the Classroom D211", Player, false);
            TextBox("You enter the room but no ones here", Player, false);
            TextBox("", Player, false);

            bool stay = true;
            do
            {
                TextBox("What would you like to do? \n║1: Leave the room\n║2: Look desks \n║3: Look whiteboard", Player, true);
                string temp = Console.ReadLine();
                Console.Clear();

                switch (temp)
                {
                    case "1":
                        stay = false;
                        break;

                    case "2":
                        TextBox("In the room you have found a desks and computers", Player, false);
                        break;

                    case "3":
                        TextBox("I start inspecting the whiteboard, hoping to find something interesting. But the only thing here is github notes", Player, false);
                        TextBox("I turn around to go look elsewhere, but at the corner of my eye I see a small sticky note", Player, false);
                        TextBox("I go to look at the note, the note has a number on it and 3 #'s. ##1#", Player, false);
                        TextBox("This note seems important, I think I'll take it just incase", Player, false);
                        joyCard = true;
                        break;
                }

            } while (stay == true);

            TextBox("I leave the classroom", Player, false);
            SouthHallway();
        }


        public static void Janitorsroom()
        {
            string temp, search = "n";
            int option, options;

            Cabin janitorscabin;
            janitorscabin.cabin1 = "You have found a keyb gun";
            janitorscabin.cabin2 = "You have found a mousenunchuck";
            janitorscabin.cabin3 = "There is nothing in here";
            janitorscabin.cabin4 = "You have found a hdmichain";

            Desks janitorsdesk;
            janitorsdesk.topdesk = "There a muffin and a cup of coffee";
            janitorsdesk.drawer1 = "There is nothing in here";
            janitorsdesk.drawer2 = "You have found a key";
            janitorsdesk.drawer3 = "You have found a mug";
            janitorsdesk.drawer4 = "You have found a lighter";

           TextBox("Welcome to the janitors room",Player, false);
            TextBox("There is a desk in the middle of the room, two cabin on the left side, two cabin on the right side, a window overlooking the carpark and a picture on the wall.",Player, false );
            TextBox("What would you like to look at ",Player, false);
            TextBox("what would you like to do?\n1:Poster\n2:Window\n3:Desk\n4:Leave", Player, true);
            temp = Console.ReadLine();
            Console.Clear();
            options = Convert.ToInt32(temp);

            Console.WriteLine("options 1 2 3 4 5 6 7 8");
            temp = Console.ReadLine();
            option = Convert.ToInt32(temp);
            do
            {
                switch (option)
                {
                    case 1:
                        TextBox("You have looked at the poster, there appears to be a picture of the janitor's family photo",Player, false);
                        TextBox("Press enter to return",Player,true);
                        Console.ReadLine();
                        break;
                    case 2:
                        TextBox(" Looking out the window it appears to be a bright day in the parking lot. The loud noise of construction workers distracts you from noticing anything useful",Player, false);
                        TextBox("Press enter to return",Player,true);
                        Console.ReadLine();

                        break;
                    case 3:
                        TextBox($"You take a closer look at the desk. {janitorsdesk.topdesk}",Player, false);
                        TextBox("What would you like to do?",Player, false);

                        do
                        {
                            while (search == "y")
                            {
                                TextBox("What would you like to search? \n 1: first drawer \n 2: second drawer \n 3: third drawer  \n 4: fouth drawer \n 5: first cabin on the right \n 6: second cabin on the right \n 7: first cabin on the left \n 8: second cabin on the left \n 9: leave", Player, false);
                                temp = Console.ReadLine();
                                options = Convert.ToInt32(temp);

                                switch (options)
                                {

                                    case 1:
                                        TextBox("you search the first draw", Player, false);
                                        TextBox($"{janitorsdesk.drawer1}", Player, false);
                                        TextBox("Press enter to return", Player, true);
                                        Console.ReadLine();
                                        break;
                                    case 2:
                                        TextBox("you search the second draw",Player, false);
                                        TextBox($"{janitorsdesk.drawer2}",Player, false);
                                        TextBox("Press spacebar to return", Player, true);
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

        public static void BreakRoom()
        {
            //this will be the text when the room is entered
            TextBox("You have entered the Break Room", Player, false);

            TextBox("The room suddenly pauses and stares at  you", Player, false);

            TextBox("As you star back you realise that all of the polytech staff are here", Player, false);

            TextBox("AND THEY ARE JUST SITTING AROUND DRINKING SCAPEGRACE GIN!!!", Player, false);

            TextBox("Vaughn: WHAT ARE YOU DOING HERE? HOW DID YOU GET IN THERE IS A LOCK FOR A REASON?.", Vaughn, false);

            TextBox("You cannot leave here and let this get out that we have replaced ourselves with robot so that we can can just have fun all day.", Vaughn, false);

            TextBox("Vaughn walks over to the table in the middle of the room and pours a glass and extends his arm out to you with a glass full of gin.", Player, false);

            TextBox("Join us in taking over the Polytech or we will have to get rid of you MWAHAHAHHAA!!", Vaughn, false);

            TextBox("Make your choice\n║1: Fight them.\n║2: Join them.", Player, true);


            int x = 0;
            while (x == 0)
            {
                string temp = Console.ReadLine();

                if (temp == "1")
                {
                    x = 1;
                    Fight();
                }
                else if (temp == "2")
                {
                    x = 1;
                    AltEnd();

                }
                else
                {
                    TextBox("Sorry Invalid Input", Player, false);
                }
            }
        }

        public static void AltEnd()
        {
            TextBox("You accept the glass of the crystal clear cup of Scapegrace gin from vaughs extended hand and take a small sip.", Player, false);
            TextBox("As you seat yourself on one of the chairs in the room you look across and see a not so familiar face .", Player, false);
            TextBox("ITS ANDREAS... HES BEEN IN HERE THE WHOLE TIME!!!", Player, false);
            TextBox("unfortunatly you spend all your time here and never leave and you fail your course.", Player, false);
            TextBox("The End.", Player, false);
            Main();
        }

        public static void Fight()
        {
            TextBox("Vaughn: Ah so you have chosen to fight!", Vaughn, false);
            TextBox("Vaughn: WAHAHAHAHA YOU CAN'T DEFEAT ME AND MY ROBOTS", Vaughn, false);


            if (keyboardshield == true)
            {
                //keyboardshield dialouge
                TextBox("Vaughn starts reeling his arm back for a robo punch", Player, false);

                TextBox("I pick up the keyboard shield from my backpack to block Vaughn's Mech Punch.", Player, false);

                TextBox("But the punch breaks straight through.", Player, false);
            }
            if (mousenunchuck == true)
            {
                //mouse dialouge
                TextBox("You dig around in your backpack and find the Mouse Nunchucks!!!", Player, false);

                TextBox("They break as you swing them because they arent real nunchucks.", Player, false);
            }
            if (screwdriver == true)
            {
                //screwdriver dialouge

                TextBox("You whipp out the screwdriver from you back pocket.", Player, false);

                TextBox("Its no very effective because Vaughns suit is held together by bolts not screws.", Player, false);
            }
            if (hdmichain == true)
            {
                //hdmi dialouge
                TextBox("Its time for the big guns you reach deep into your backpack and grab yout trusty HDMi chain.", Player, false);

                TextBox("Turns out that HDMI chain wasnt so trusty afterall as Vaught breaks free with his robosuit.", Player, false);
            }


            // true ending
            TextBox("There is no running your back is against the wall, it looks like you are about to bite it.", Player, false);

            TextBox("Somthing shiny from the corner of your eye catches your attention... its a full glass of GIN!!", Player, false);

            TextBox("You quickly cease the glass and throw the contents onto Vaughns powersuit.", Player, false);

            TextBox("NOOOOOOOOOOOO MY SUITS CIRCUITS WILL FRY!!!!!!!", Vaughn, false);

            TextBox("the suit snap crackles and pops as it begins to shut down.", Player, false);

            TextBox("Vaughn has been defeated without his robit armor he is powerless.", Player, false);

            TextBox("The teachers will now have to go back to thier old lives and continue wroking at the Otago Polytechnic.", Player, false);

            TextBox("you have succe.", Player, false);

            TextBox("The End.", Player, false);

            Menu();
        }

        public static void Savegame()
        {

            StreamWriter sw = new StreamWriter($@"save.txt");
            sw.WriteLine($"{keyboardshield}");
            sw.WriteLine($"{mousenunchuck}");
            sw.WriteLine($"{screwdriver}");
            sw.WriteLine($"{hdmichain}");

            sw.WriteLine($"{keycode1}");
            sw.WriteLine($"{keycode2}");
            sw.WriteLine($"{keycode3}");
            sw.WriteLine($"{keycode4}");

            TextBox("you have successfully saved game", Player, false);
            sw.Close();

            SouthHallway();
        }

        public static void Loadgame()
        {
            StreamReader sr = new StreamReader($@"save.txt");

            keyboardshield = Convert.ToBoolean(sr.ReadLine());
            mousenunchuck = Convert.ToBoolean(sr.ReadLine());
            screwdriver = Convert.ToBoolean(sr.ReadLine());
            hdmichain = Convert.ToBoolean(sr.ReadLine());

            keycode1 = Convert.ToBoolean(sr.ReadLine());
            keycode2 = Convert.ToBoolean(sr.ReadLine());
            keycode3 = Convert.ToBoolean(sr.ReadLine());
            keycode4 = Convert.ToBoolean(sr.ReadLine());


            TextBox("You have successfully loaded your save", Player, false);
            sr.Close();

            SouthHallway();
        }
    }
}




