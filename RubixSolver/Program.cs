// See https://aka.ms/new-console-template for more information

using System;
using RubixSolver;

// First: create a representation of a cube
// Second: Think of the ways we can manipulate the cube - what is each way we can turn it?
// Third: How does this actually change the data? E.g. A turn of the top face would cause each adjacent face (side faces) to get the top row of its neighbour. It would also change the orientation of data of the top face.

Console.WriteLine("Hi");

var cube = new RubixCube();
cube.InitializeCube();