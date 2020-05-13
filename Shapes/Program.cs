using System;
// using System.Collection.Generic;

namespace Shapes.Models
{
  class Program
  {

    public static void Main()
    {
      Console.WriteLine("Just begininng to code");
      Triangle sideOne = new Triangle(5,5);
      Triangle sideTwo = new Triangle(5,5);
      Triangle sideThree = new Triangle(5,5);
      Triangle sideFour = new Triangle(5,5);
      Pyramid testOnePyramid = new Pyramid(sideOne, sideTwo, sideThree, sideFour);
      double result = testOnePyramid.CalculateAreaOfTopPyramid();
      Console.WriteLine($"Here is our result {result}");





    }

    


  }




}