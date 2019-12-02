using System;
using System.IO;

namespace MarsRover2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            MarsRover MarsRover = new MarsRover();

            int counter = 0;
            string line;

            try
            {   // Open the text file using a stream reader.
                using StreamReader file = new StreamReader("MarsRoverCommands.txt");
                // Read the file line by line and set the commands for the Mars Rover.                 
                while ((line = file.ReadLine()) != null)
                {
                    switch (counter)
                    {
                        case 0:
                            string[] ZoneCoords = line.Split(' ');
                            MarsRover.SetZone(int.Parse(ZoneCoords[0]), int.Parse(ZoneCoords[1]));
                            Console.WriteLine("The Zone has been created with the dimensions: " + ZoneCoords[0] + " " + ZoneCoords[1]);
                            break;
                        case 1:
                            string[] RoverCoords = line.Split(' ');
                            MarsRover.SetRoverPosition(int.Parse(RoverCoords[0]), int.Parse(RoverCoords[1]));
                            MarsRover.SetDirection(char.Parse(RoverCoords[2]));
                            Console.WriteLine("The Mars Rover has been positioned at Coordinates: " + RoverCoords[0] + " " + RoverCoords[1]);
                            Console.WriteLine("Facing a " + RoverCoords[2] + " Direction");
                            break;
                        case 2:
                            Console.WriteLine("");
                            MarsRover.MoveRover(line);
                            break;
                        default:
                            break;
                    }
                    counter++;
                }

                file.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }

        }
    }
}