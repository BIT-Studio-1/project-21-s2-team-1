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

            //Savegame();
            Menu();
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
            //switch to occompany the menu options

            string temp = Console.ReadLine();
            char input = Convert.ToChar(temp);
            switch(input)
            {
                case '1':
                    
                    IntroCutscene();
                    break;
                case '2':
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

                    
                    break;
                case '3':
                    Environment.Exit(0);
                    break;
                default:
                    Menu(); //runs menu function again if input is not 1, 2, or 3
                    break;
            }
            Console.Clear();


        }
        public static Boolean keyboardshield = false, mousenunchuck = false, screwdriver = false, hdmichain = false; //inventory booleans (you can initialize multiple of the same datatype this way)
        
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

        public struct desks
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

            //color sheet
            //Player/thoughts = white

            //joy = purple

            //vaughn = red 

            TextBox("Today is october 1st, a friday. Its currently about 7:50am, I really don't like these 8am days.", Player, false);

            TextBox("I make my way to my math class and take my seat near the back. Most people are here already", Player, false);
            
            TextBox("joy's already here, somethings wrong", Player, false);
            
            TextBox("start class, binary question happens, joy short circuit", Player, false);
            
            TextBox("we walk over and see what happened", Player, false);
            
            TextBox("Vaughn comes in.", Player, false);

            TextBox("Vaughn:  Everyone out!", Vaughn, false);

            TextBox("we all leave", Player, false);

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
            String temp;
            TextBox("You have entered the North hall way", Player, false);
            TextBox("Theres a billboard infront of me with various flyers and notes on it.", Player, false);
            //class to left
            //TextBox("Looking at the vending machine it doesnt look normal but appears to be able to save game in some way", Player, false);
            TextBox("Theres also another classroom to my right", Player, false);
            TextBox("The hallway bends round the corner leading into the west hallway", Player, false);
            TextBox("What would you like to do \n" + "1: Joy Classroom\n2: Billboard\n3: Enter Other Classroom\n4: Move Through Hallway", Player, true);
            

            bool fail = false;

            do
            {
                temp = Console.ReadLine();
                switch (temp)
                {
                    case "1":
                        //try to enter this room but its locked
                        //later when you've collected the keycard you can enter this room
                        fail = false;

                        break;
                    case "2":
                        //you go look at the billboard
                        fail = false;

                        break;
                    case "3":
                        //enter the first coderoom
                        fail = false;

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
            Console.Clear();
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
                    Savegame();
                    TextBox("Save Successful", Player, false);
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
        public static void BreakRoom()
        {
            //this will be the text when the room is entered
            Console.WriteLine("Vaughn join me MWAHAHAHHAA!!");
            Thread.Sleep(500);
            Console.WriteLine("Make your choice");
            Console.WriteLine("PRESS 1 : Beat them?  ");
            Console.WriteLine("PRESS 2 : Join them?  ");
            string temp = Console.ReadLine();
            if (temp == "1")
            {
                Fight();
            }
            else
            {
                AltEnd();

            }

        }
        public static void AltEnd()
        {
            Console.WriteLine("you take a sip of the gin vaughn gives you and you spend the rest of your days sipping gin in the teacher lounge vowing top always keep thier club a secret.");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Would you like to play again y/n");
            string temp = Console.ReadLine();
            if (temp == "y")
            {
                Main();
            }

            else
            {
                Environment.Exit(0);
            }
        }
        public static void Fight()
        {
            Console.WriteLine("WAHAHAHAHA YOU CAN'T DEFEAT ME AND MY ROBOTS");

            /*
            
            //Andrews attempt at a bool array if you know how to fux this plz do ive never done of of these beore
            bool[] inventory = new bool{keyboardshield, mousenunchuck, screwdriver, hdmichain};
            // for loop to use each itam in the array
            int i = 0;
            
            foreach (int i in inventory.Length)
            {
                Console.WriteLine("What do you use now?");

                if (i == true)
                {
                    Console.WriteLine($"You searched your pockets and you found {i} and threw it at him");
                    Thread.Sleep(1500);
                    Console.WriteLine($"it didnt do anything");
                    i++;
                }
           
                
            }*/

            //liams code

            //keyboardshield, mousenunchuck, screwdriver, hdmichain

            

            Console.WriteLine("random bullshit go!");

            if(keyboardshield == true)
            {
                //keyboardshield dialouge
            }
            if (mousenunchuck == true)
            {
                //mouse dialouge
            }
            if (screwdriver == true)
            {
                //screwdriver dialouge
            }
            if (hdmichain == true)
            {
                //hdmi dialouge
            }


            // true ending
            Console.WriteLine("Throw cup of gin on vaughn");
            Menu();

        }
        public static void Savegame()
        {

            StreamWriter sw = new StreamWriter($@"save.txt");
            sw.WriteLine($"{keyboardshield}");
            sw.WriteLine($"{mousenunchuck}");
            sw.WriteLine($"{screwdriver}");
            sw.WriteLine($"{hdmichain}");

            TextBox("you have successfully saved game", Player, false);
            sw.Close();
        }
        public static void Loadgame()
        {
            StreamReader sr = new StreamReader($@"save.txt");

            keyboardshield = Convert.ToBoolean(sr.ReadLine());
            mousenunchuck = Convert.ToBoolean(sr.ReadLine());
            screwdriver = Convert.ToBoolean(sr.ReadLine());
            hdmichain = Convert.ToBoolean(sr.ReadLine());


            TextBox("You have successfully loaded your save", Player, false);
            //Console.WriteLine($"{keyboardshield}, {mousenunchuck}, {screwdriver}, {hdmichain}");
            //Console.ReadLine();
            sr.Close();


            SouthHallway();
        }
    }
}




