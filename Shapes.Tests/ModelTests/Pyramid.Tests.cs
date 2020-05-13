using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;


namespace Shapes.Tests
{
  [TestClass]
  public class PyramidTests
  {
    [TestMethod]
    public void Pyramid_GetArea_AreaOfPyramid()
    {
      // Arrange
      Triangle sideOne = new Triangle(5,5);
     
      Triangle sideTwo = new Triangle(5,5);
      
      Triangle sideThree = new Triangle(5,5);
     
      Triangle sideFour = new Triangle(5,5);
      
      Pyramid testOnePyramid = new Pyramid(sideOne, sideTwo, sideThree, sideFour);

      // Act
      double result = testOnePyramid.CalculateAreaOfTopPyramid();

      // Assert
      Assert.AreEqual(result, 50);

    }

    [TestMethod]
    public void Pyramid_GetArea2_AreaOfPyramid()
    {
      // Arrange
      Triangle sideOne = new Triangle(7,5);
     
      Triangle sideTwo = new Triangle(5,5.2);
      
      Triangle sideThree = new Triangle(5.5,5);
     
      Triangle sideFour = new Triangle(5.6,5.1);
      
      Pyramid testOnePyramid = new Pyramid(sideOne, sideTwo, sideThree, sideFour);

      // Act
      double result = testOnePyramid.CalculateAreaOfTopPyramid();

      // Assert
      Assert.AreEqual(result, 58.53);

    }
  }
}