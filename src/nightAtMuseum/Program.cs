using System;
using System.Collections.Generic;

namespace nightAtMuseum
{
    class Program
    {
        static void Main(string[] args)
        {
             menu();
           
            Room entrance = new Room("Entrance");
            Room hallway = new Room("Hallway");
            Room greenRoom = new Room("Green room");
            Room redRoom = new Room("Red romm");
            Room purpleRoom = new Room("Purple room");
            Room blackRoom = new Room("Black room");
            Room blueRoom = new Room("Blue room");
            Room whiteRoom = new Room("White room");


            Artwork monaLisa = new Artwork("Mona Lisa ", "famous painting ", "Painted by: DaVinci ");
            Artwork scream = new Artwork("The Scream ", " famous painting ", "Painted by: Edvard Munch");
            Artwork night = new Artwork("The Night Watch ", "famous painting ", "Painted by: Rembrandt ");
            Artwork kiss = new Artwork("The Kiss ", "famous painting ", "Painted by: Gustav Klimt ");
            Artwork music = new Artwork("Musicians Lisa ", "famous painting ", "Painted by: Caravaggio");
            Artwork sleep = new Artwork("The Sleeping Gypsy ", "famous painting ", "Painted by: Henri Rousseau");
            Artwork wave = new Artwork("The Ninth Wave ", "famous painting ", "Painted by: Ivan Aivazovsky");
            Artwork gross = new Artwork("The Gross Clinic ", "famous painting ", "Painted by: Thomas Eakins");
            Artwork babel = new Artwork("The Tower Of Babel ", "famous painting ", "Painted by: Pieter Bruegel the Elder");
            Artwork above = new Artwork("The Wanderer Above The Sea Of Fog ", "Painted by: famous painting ", "Caspar David Friedrich");
            Artwork gleaners = new Artwork("The Gleaners ", "famous painting ", "Painted by: Jean-Francois Millet");


            // connect neighboring room to entrence
            entrance.roomUp = hallway;
            hallway.roomDown = entrance;
            hallway.roomUp = greenRoom;

            // Green room
            greenRoom.roomUp = blueRoom;
            greenRoom.roomRight = redRoom ;
            greenRoom.roomDown = hallway;
            greenRoom.addArtwork(monaLisa);
            greenRoom.addArtwork(night);

            // Red room
            redRoom.roomUp = purpleRoom;
            redRoom.roomRight = greenRoom;
            redRoom.addArtwork(kiss);
            redRoom.addArtwork(music);
            redRoom.addArtwork(sleep);


            // Purple room

            purpleRoom.roomDown = redRoom;
            purpleRoom.roomLeft = blueRoom;
            purpleRoom.addArtwork(gross);
            purpleRoom.addArtwork(babel);
            purpleRoom.addArtwork(above);
            purpleRoom.addArtwork(gleaners);

            // Blue room
            blueRoom.roomUp = blueRoom;
            blueRoom.roomRight = purpleRoom;
            blueRoom.roomDown = greenRoom;
            blueRoom.roomLeft = whiteRoom;
            blueRoom.addArtwork(wave);

            // Black room
            blackRoom.roomDown = blueRoom;
            whiteRoom.roomRight = blueRoom;
            whiteRoom.addArtwork(scream);

            Room currentRoom = entrance;
            Console.WriteLine("Press the key f to go from  entrence to the hallway");
            bool run = true;
            while (run)
            {
                currentRoom.printArtworks();

                Room roomUp = currentRoom.roomUp;
                Room roomRight = currentRoom.roomRight;
                Room roomDown = currentRoom.roomDown;
                Room roomLeft = currentRoom.roomLeft;

                if (currentRoom == hallway)
                {
                    Console.WriteLine("Press the key f to enter the green room" );
                }

                if (currentRoom == greenRoom)
                {
                    Console.WriteLine("Press the key f to enter the blue room");
                    Console.WriteLine("Press the key r to enter the red room");
                    Console.WriteLine("Press the key b to go back to the hallway");
                }

                if (currentRoom == blueRoom)
                {
                    Console.WriteLine("Press the key r to enter the purple room");
                    Console.WriteLine("Press the key f to enter the black room");
                    Console.WriteLine("Press the key l to enter the white room");
                    Console.WriteLine("Press the key b to return to the blue room");
                }

                if (currentRoom == redRoom)
                {
                    Console.WriteLine("Press the key f to enter the purple room");
                    Console.WriteLine("Press the key l to enter the green room");
                }
                if (currentRoom == purpleRoom)
                {
                    Console.WriteLine("Press the key l to enter the blue room");
                    Console.WriteLine("Press the key d to enter the red room");
                }
                if (currentRoom == blackRoom)
                {
                    Console.WriteLine("Press the key d to enter the blue room");
                }
                if (currentRoom == whiteRoom)
                {
                    Console.WriteLine("Press the key r to enter the blue room");
                }

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "f":
                        if (roomUp != roomDown && roomUp != roomRight && roomUp != roomLeft)
                        {
                            currentRoom = roomUp;
                        }
                        else
                        {
                            Console.WriteLine("There is no room above.");
                        }
                        break;
                    case "r":
                        if (roomRight != roomDown && roomRight != roomUp && roomRight != roomLeft)
                        {
                            currentRoom = roomRight;
                        }
                        else
                        {
                            Console.WriteLine("There is no room on the right.");
                        }
                        break;

                    case "b":
                        if (roomDown != roomUp && roomDown != roomLeft && roomDown != roomRight)
                        {
                            currentRoom = roomDown;
                        }
                        else
                        {
                            Console.WriteLine("There is no room below.");
                        }
                        break;
                    case "l":
                        if (roomLeft != roomUp && roomLeft != roomRight && roomLeft != roomDown)
                        {
                            currentRoom = roomLeft;
                        }
                        else
                        {
                            Console.WriteLine("There is no room on the left.");
                        }
                        break;
                    case "q":
                        Console.WriteLine("Thank you for visiting us.");
                        run = false;
                        break;
                    default:
                        Console.WriteLine("You pressed the wrong key, try again");
                        break;
                }
                Console.WriteLine();
            }

            static void menu()
            {
                Console.WriteLine("Welcome to Museum Masterpieces where you will find the 11 most fascinating paintings");
                Console.WriteLine("You move around the various rooms by pressing the suggested keys. If you want to exit the program press q");
                Console.WriteLine("Good luck and enjoy all the artwork");
                Console.WriteLine();
            }



        }
    }
}
