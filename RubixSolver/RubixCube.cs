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
        
        // Rotate: clockwise/anti, then account for the adjacent faces.
        
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
    }
}