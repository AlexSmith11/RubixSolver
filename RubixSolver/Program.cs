// See https://aka.ms/new-console-template for more information

using System;
using RubixSolver;

// First: create a representation of a cube
// Second: Think of the ways we can manipulate the cube - what is each way we can turn it?
// Third: How does this actually change the data? E.g. A turn of the top face would cause each adjacent face (side faces) to get the top row of its neighbour. It would also change the orientation of data of the top face.

Console.WriteLine("Hi");

var cube = new RubixCube();
cube.InitializeCube();

// Print the cube! Instructions per PDF are:
Console.WriteLine("Cube start state: ");
cube.PrintCube();
Console.WriteLine("=================================");
Console.WriteLine("Step 1/6");
cube.RotateFrontClockwise();
cube.PrintCube();

Console.WriteLine("Step 2/6");
cube.RotateRightClockwise();
cube.PrintCube();

Console.WriteLine("Step 3/6");
cube.RotateUpClockwise();
cube.PrintCube();