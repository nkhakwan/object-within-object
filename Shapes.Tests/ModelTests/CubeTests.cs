using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class CubeTests
  {

    [TestMethod]
    public void Cube_GetVolume_VolumeOfCube()
    {
      // Arrange
      Rectangle testOneRectangle = new Rectangle(4, 4);
      Cube testOneCube = new Cube(testOneRectangle);
      // Act
      int result = testOneCube.GetVolume();
      // Assert
      Assert.AreEqual(result, 64);
    }

    [TestMethod]
    public void Cube_GetSurfaceArea_SurfaceAreaOfCube()
    {
      // Arrange
      Rectangle testTwoRectangle = new Rectangle(4, 4);
      Cube testTwoCube = new Cube(testTwoRectangle);
      // Act
      int result = testTwoCube.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 96);
    }

  }  
}