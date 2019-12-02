using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover2
{
    class MarsRover
    {
        /// All Public funtions are seen below

        //Function to Get the Zone
        public int[,] GetZone()
        {
            return Zone;
        }

        //Function to Set the Zone
        public void SetZone(int x, int y)
        {
            //initialize the Zone with the given dimensions
            Zone = new int[x, y];

            //Set all values in the Zone to 0
            for (int xCount = 0; xCount < x; xCount++)
            {
                for (int yCount = 0; yCount < y; yCount++)
                {
                    Zone[xCount, yCount] = 0;
                }
            }
        }

        //Function to set the initial position of the Mars Rover
        public void SetRoverPosition(int x, int y)
        {
            Zone[x, y] = 1;
        }

        //Function to output the Rovers final position
        public void OutputRoversPosition()
        {
            //Variables to hold the found coordinates for the Rover
            int xCoordFound = 0;
            int yCoordFound = 0;

            //Variables to hold the size of the Zone
            int xSize = Zone.GetLength(0);
            int ySize = Zone.GetLength(1);

            // For loops to loop through the Zone to find the Mars Rovers current position
            for (int xCount = 0; xCount < xSize; xCount++)
            {
                for (int yCount = 0; yCount < ySize; yCount++)
                {
                    if (Zone[xCount, yCount] == 1)
                    {
                        xCoordFound = xCount;
                        yCoordFound = yCount;
                        break;
                    }
                }
            }

            Console.WriteLine("The Mars Rover has come to rest at Coordinates: " + xCoordFound + " " + yCoordFound);
            Console.WriteLine("Positioned: " + GetDirection());
        }

        //Function to Set the direction that the Mars Rover is facing
        public void SetDirection(char dir)
        {
            direction = dir;
        }

        //Function to get the direction the Mars Rover is facing  
        public char GetDirection()
        {
            return direction;
        }

        //Function  to move the Mars Rover according to the prescribed directions
        public void MoveRover(string commands)
        {
            commands = commands.ToUpper();

            foreach (char c in commands)
            {
                switch (c)
                {
                    case 'M':
                        //move forward function
                        MoveRoverForward();
                        break;
                    case 'L':
                        //Rotate left function
                        RotateLeft();
                        break;
                    case 'R':
                        //Rotate right function
                        RotateRight();
                        break;
                    default:
                        Console.WriteLine("An unidentified command was found");
                        break;
                }
            }
            Console.WriteLine("The Mars Rover has finished the Commands");
            OutputRoversPosition();

        }

        //Function to rotate the Mars Rover to the left
        public void RotateLeft()
        {
            char direction = char.ToUpper(GetDirection());
            switch (direction)
            {
                case 'N':
                    SetDirection('W');
                    break;
                case 'E':
                    SetDirection('N');
                    break;
                case 'S':
                    SetDirection('E');
                    break;
                case 'W':
                    SetDirection('S');
                    break;
                default:
                    Console.WriteLine("An unexpected error occured");
                    break;
            }
        }

        //Function to rotae the Mars Rover to the Right
        public void RotateRight()
        {
            char direction = char.ToUpper(GetDirection());
            switch (direction)
            {
                case 'N':
                    SetDirection('E');
                    break;
                case 'E':
                    SetDirection('S');
                    break;
                case 'S':
                    SetDirection('W');
                    break;
                case 'W':
                    SetDirection('N');
                    break;
                default:
                    Console.WriteLine("An unexpected error occured");
                    break;
            }
        }

        //Function to move the Mars Rover forward
        public void MoveRoverForward()
        {
            //Variables to hold the found coordinates for the Rover
            int xCoordFound = 0;
            int yCoordFound = 0;

            //Variables to hold the size of the Zone
            int xSize = Zone.GetLength(0);
            int ySize = Zone.GetLength(1);

            // For loops to loop through the Zone to find the Mars Rovers current position
            for (int xCount = 0; xCount < xSize; xCount++)
            {
                for (int yCount = 0; yCount < ySize; yCount++)
                {
                    if (Zone[xCount, yCount] == 1)
                    {
                        xCoordFound = xCount;
                        yCoordFound = yCount;
                        break;
                    }
                }
            }

            // Switch Case Statement to move the Mars rover according to its heading direction
            char direction = char.ToUpper(GetDirection());
            switch (direction)
            {
                case 'N':
                    Zone[xCoordFound, yCoordFound] = 0;
                    SetRoverPosition(xCoordFound, yCoordFound - 1);
                    break;
                case 'E':
                    Zone[xCoordFound, yCoordFound] = 0;
                    SetRoverPosition(xCoordFound + 1, yCoordFound);
                    break;
                case 'S':
                    Zone[xCoordFound, yCoordFound] = 0;
                    SetRoverPosition(xCoordFound, yCoordFound + 1);
                    break;
                case 'W':
                    Zone[xCoordFound, yCoordFound] = 0;
                    SetRoverPosition(xCoordFound - 1, yCoordFound);
                    break;
                default:
                    Console.WriteLine("An unexpected error occured");
                    break;
            }
        }

        /// All Public funtions are seen Above

        //Private Variables
        private int[,] Zone;

        private char direction;
    }
}

