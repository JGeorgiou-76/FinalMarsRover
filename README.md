# FinalMarsRover

First I would like to thank Greg Meyer and the team for giving me the opportunity with this assessment.

The Mars Rover Code Challenge:

One class was created (MarsRover) that contains a private two dimensional array variable, this variable is used to store the dimensions of the zone that the Mars Rover is initialised with, the zone is also used to hold the position of the Mars Rover, all values within the two dimensional are initialised to zero, but the Mars Rover is initialised to one. This was done to make it easy to find the Mars rover.

A private char variable is used to store the direction that the Mars Rover is currently heading, this variable gets initialised with the given input, and is updated each time a rotation is seen.

Ten public functions have been created to facilitate the creation, movement, rotation, and final postion for the Mars Rover.

Functions:
+ Get, and Set funtions for the Zone:
  - The Set function is used to facilitate the creation of the zone with the given dimensions.
  A simple function that takes two integer variables, the x and y coordinates, and creates a two dimensional array, then all values for the zone get set to zero.
  - The Get Function was created but never used.
    
+ Set function for the Mars Rovers Position:
  - A simple set function was created that accepts two integer variables, x and y, and I just simply set the value of the two dimensional array at the point x and y, to the value of one.
  - This function gets used within the movement function to update the Mars Rovers position after a movement is seen.
  
+ Get function for the Mars Rovers Position:
  - This get function has no return, due to the fact that it's used to find the final position of the Mars Rover with the use of a nested for loop, and once the value of one is found (The Mars Rover), an output to the console is written to reveal the Mars Rovers position.
  
+ Set and get functions, for the direction that the Mars Rover is heading:
  -The Set and Get Direction functions are simple get and set functions used to find the direction that the Mars Rover is heading.
  
+  Two rotation funtions were created to change the direction that the Mars Rover is heading:
  - Both functions are void, they are used to update the private direction variable that shows the direction the Mars Rover is heading, a simple case statement is used for both, where the existing heading is read from the get direction function, and depending on the heading of the Rover the direction is rotated accordingly.

+ A move forward funtion:
  - The move forward funtion was created to ficilitate the moving of the Mars Rover, first a nested for loop is used to find the position of the mars rover (x and y position), then the direction that the mars rover is facing gets called, and then a case statement is used to move the mars rover according to the Mars rovers heading, first I update the found coordinates in the two dimensional array and then move the mars rover forward in the desired direction.
  
+ Finally a Move Mars rover function was created:
  - This function accepts the movement string, and loops through the string, character by character, a case statement is used to read the characters, and then it fires the appropriate functions accoring to the read character. Once all characters have been read, the function calls the get mars rover funtion, that displays the final coordinates on the console.
  

In the main function of the program, a file is read from the bin, that contains the commands for the mars rover, the commands are on seperate lines, and the file is read line by line, and the commands are inputted accordingly.
