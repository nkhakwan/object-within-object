using System;

namespace Shapes.Models
{
  public class Triangle
  {
    public double Height {get; set;}
    public double Base {get; set;}

    public Triangle (double height, double triangleBase)
    {
      Height = height;
      Base = triangleBase;
    }

    public double AreaOfTriangle()
    {
      Console.WriteLine("I am inside AreaOfTriangle Calculation");
      return (Base*Height) /2;
      
    }

  }


}