using NUnit.Framework;

namespace RubixSolver
{
    [TestFixture]
    public class RubixCubeTests
    {
        // We can test the rotations, then before / after of step 1 and step 6.
        [Test]
        public void RotateFrontClockwise_Test()
        {
            RubixCube cube = new RubixCube();

            cube.RotateFrontClockwise();
            
            Assert.That('W', Is.EqualTo(cube.upFace[2, 1]));        // White center on the up face
            Assert.That('R', Is.EqualTo(cube.rightFace[0, 1]));     // Red center on the right face
            Assert.That('G', Is.EqualTo(cube.frontFace[1, 1]));     // Green center on the front face
        }
    }
}