using System;

namespace RubixSolver
{
    public class RubixCube
    {
        // we will use simple 2d char arrays for each face
        private char[,] frontFace;
        private char[,] rightFace;
        private char[,] upFace;
        private char[,] backFace;
        private char[,] leftFace;
        private char[,] downFace;

        // constructor to create each side of the cube.
        public void InitializeCube()
        {
            // Initialize each face with the solved state
            frontFace = InitializeFace('G');
            rightFace = InitializeFace('R');
            upFace = InitializeFace('W');
            backFace = InitializeFace('B');
            leftFace = InitializeFace('O');
            downFace = InitializeFace('Y');
        }

        private char[,] InitializeFace(char color)
        {
            // create a new 3x3 arr for each face, and assign each block a color
            var face = new char[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    face[i, j] = color;
                }
            }

            return face;
        }
        
        // Rotations: clockwise/anti, then account for the adjacent faces.
        
        /// <summary>
        /// Rotate a face clockwise.
        /// </summary>
        /// <param name="face"></param>
        private void RotateClockwise(char[,] face)
        {
            char[,] rotatedFace = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rotatedFace[j, 2 - i] = face[i, j];
                }
            }

            Array.Copy(rotatedFace, face, rotatedFace.Length);
        }
        
        /// <summary>
        /// Rotate anti-clockwise.
        /// Using the above logic, we can also now rotate in the opposite direction.
        /// </summary>
        /// <param name="face"></param>
        private void RotateAntiClockwise(char[,] face)
        {
            char[,] rotatedFace = new char[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    rotatedFace[2 - j, i] = face[i, j];
                }
            }

            Array.Copy(rotatedFace, face, rotatedFace.Length);
        }
        
        /// <summary>
        /// Update adjacent faces after a face has been rotated.
        /// </summary>
        /// <param name="face1"></param>
        /// <param name="face2"></param>
        /// <param name="face3"></param>
        /// <param name="face4"></param>
        private void RotateAdjacentClockwise(char[,] face1, char[,] face2, char[,] face3, char[,] face4)
        {
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++)
            {
                temp[i] = face1[2, i];
            }

            for (int i = 0; i < 3; i++)
            {
                face1[2, i] = face4[2 - i, 2];
                face4[2 - i, 2] = face3[0, i];
                face3[0, i] = face2[i, 0];
                face2[i, 0] = temp[i];
            }
        }
        
        /// <summary>
        /// Update adjacent faces after a face has been rotated anti-clockwise
        /// </summary>
        /// <param name="face1"></param>
        /// <param name="face2"></param>
        /// <param name="face3"></param>
        /// <param name="face4"></param>
        private void RotateAdjacentAntiClockwise(char[,] face1, char[,] face2, char[,] face3, char[,] face4)
        {
            char[] temp = new char[3];
            for (int i = 0; i < 3; i++)
            {
                temp[i] = face1[2, i];
            }

            for (int i = 0; i < 3; i++)
            {
                face1[2, i] = face2[i, 0];
                face2[i, 0] = face3[0, i];
                face3[0, i] = face4[2 - i, 2];
                face4[2 - i, 2] = temp[i];
            }
        }
        
        // Utility
        
        /// <summary>
        /// Print the current states / the cube
        /// </summary>
        public void PrintCube()
        {
            Console.WriteLine("Front Face:");
            PrintFace(frontFace);
            Console.WriteLine("Right Face:");
            PrintFace(rightFace);
            Console.WriteLine("Up Face:");
            PrintFace(upFace);
            Console.WriteLine("Back Face:");
            PrintFace(backFace);
            Console.WriteLine("Left Face:");
            PrintFace(leftFace);
            Console.WriteLine("Down Face:");
            PrintFace(downFace);
        }
        
        private void PrintFace(char[,] face)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(face[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        
        // public rotation methods to help with simplicity, abstraction and SOLID
        public void RotateFrontClockwise()
        {
            RotateClockwise(frontFace);
            RotateAdjacentClockwise(upFace, rightFace, downFace, leftFace);
        }
    }
}