using System;

namespace Liam_Test_Version
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
            Hallway2();
        }

        public static void Hallway2()
        {
            int xPos = 1, yPos = 1;
            string choice;

            /*
            13 x 7
            ╔═══════════╗ 
          3 ║ X   X   X ║ 
            ║   ╔═══╗   ║  
          2 ║ X ║   ║ X ║ 
            ║   ╚═══╝   ║ 
          1 ║ X   X   X ║ 
          y ╚═══════════╝
            x 1   2   3 


            ╔╝┅╚═════════
            ║ X   X   X ┆ 
            ║   ╔═══╗   ╔
            ║ X ║     X ║ 
            ╝   ╚═══╝   ║
            ┆ X   X   X ║
            ═════════╗┅╔╝

            1,1
            ╔╝ ╚═════════
            ║            
            ║   ╔═══╗   ╔
            ║   ║       ║ 
            ╝   ╚═══╝   ║
              X         ║
            ═════════╗ ╔╝

            */






            for (int i = 0; i < 20; i++)
            {
                Console.Clear();
                Console.WriteLine($"X: {xPos} - Y:{yPos}");


                switch (xPos)
                {
                    case 1:
                        switch (yPos)
                        {
                            case 1:
                                Console.WriteLine("╔╝ ╚═════════\n║            \n║   ╔═══╗   ╔\n║   ║       ║\n╝   ╚═══╝   ║\n  X         ║\n═════════╗ ╔╝");
                                break;

                            case 2:
                                Console.WriteLine("╔╝ ╚═════════\n║            \n║   ╔═══╗   ╔\n║ X ║       ║\n╝   ╚═══╝   ║\n            ║\n═════════╗ ╔╝");
                                break;

                            case 3:
                                Console.WriteLine("╔╝ ╚═════════\n║ X          \n║   ╔═══╗   ╔\n║   ║       ║\n╝   ╚═══╝   ║\n            ║\n═════════╗ ╔╝");
                                break;
                        }
                        break;

                    case 2:
                        switch (yPos)
                        {
                            case 1:
                                Console.WriteLine("╔╝ ╚═════════\n║            \n║   ╔═══╗   ╔\n║   ║       ║\n╝   ╚═══╝   ║\n      X     ║\n═════════╗ ╔╝");
                                break;

                            case 2:
                                Console.WriteLine("╔╝ ╚═════════\n║            \n║   ╔═══╗   ╔\n║   ║ X     ║\n╝   ╚═══╝   ║\n            ║\n═════════╗ ╔╝");
                                break;

                            case 3:
                                Console.WriteLine("╔╝ ╚═════════\n║     X      \n║   ╔═══╗   ╔\n║   ║       ║\n╝   ╚═══╝   ║\n            ║\n═════════╗ ╔╝");
                                break;
                        }
                        break;

                    case 3:
                        switch (yPos)
                        {
                            case 1:
                                Console.WriteLine("╔╝ ╚═════════\n║            \n║   ╔═══╗   ╔\n║   ║       ║\n╝   ╚═══╝   ║\n          X ║\n═════════╗ ╔╝");
                                break;

                            case 2:
                                Console.WriteLine("╔╝ ╚═════════\n║            \n║   ╔═══╗   ╔\n║   ║     X ║\n╝   ╚═══╝   ║\n            ║\n═════════╗ ╔╝");
                                break;

                            case 3:
                                Console.WriteLine("╔╝ ╚═════════\n║         X  \n║   ╔═══╗   ╔\n║   ║       ║\n╝   ╚═══╝   ║\n            ║\n═════════╗ ╔╝");
                                break;
                        }
                        break;
                } //draw map




                choice = Console.ReadLine();

                if (choice.Contains("up")) //if y pos is y1 or y2
                {
                    if (yPos < 3)
                    {
                        //move
                        yPos += 1;
                    }
                }

                if (choice.Contains("down")) //if y pos is y2 or y3
                {

                    if (yPos > 1)
                    {
                        //move
                        yPos -= 1;
                    }
                }



                if (choice.Contains("right")) //if x pos is y1 or y2
                {
                    if (xPos < 3)
                    {
                        //move
                        xPos += 1;
                    }
                }

                if (choice.Contains("left")) //if x pos is y2 or y3
                {

                    if (xPos > 1)
                    {
                        //move
                        xPos -= 1;
                    }
                }
            }

        }

        public static void Hallway1()
        {
            //which room would you like to enter

            string choice;

            Console.WriteLine();
            /*
            ╔═══════════╗
            ║ X X X X X ║
            ║ X ╔═══╗ X ║  
            ║ X ║   ║ X ║
            ║ X ╚═══╝ X ║ 
            ║ X X X X X ║
            ╚═══════════╝
            ╠ ╣ ╦ ╩ ╗ ╔ ╝ ╚ ║ ═
            ╔═══════════╗
            ║ X   X   X ║
            ║   ╔═══╗   ║  
            ║ X ║   ║ X ║
            ║   ╚═══╝   ║ 
            ║ X   X   X ║
            ╚═══════════╝

            ╔╝ ╚═╝ ╚═════
            ║ X   X   X 
            ║   ╔═══╗   ╔
            ║ X ║     X ║ 
            ╝   ╚═══╝   ║
              X   X   X ║
            ═════╗ ╔═╗ ╔╝
            */

            Console.WriteLine("Room 101: \nRoom 102: \nRoom 103: ");

            //display choices

            //user input

            //if valid, run method
            //if invalid, repeat



            choice = Console.ReadLine();

            if (choice.Contains("101"))
            {
                Room101();
            } 
            else if (choice.Contains("102"))
            {
                Room102();
            }
            else if (choice.Contains("103"))
            {
                Room103();
            }
            else
            {
                Console.WriteLine("invalid");
            }
        }
        public static void Room101()
        {
            Console.ReadLine();
        }

        public static void Room102()
        {

        }

        public static void Room103()
        {

        }

    }
}
