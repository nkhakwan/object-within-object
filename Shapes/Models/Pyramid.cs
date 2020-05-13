using System;

namespace Shapes.Models
{
 public class Pyramid
 {
   public Triangle Face1 {get; set;}
   public Triangle Face2 {get; set;}
   public Triangle Face3 {get; set;}
   public Triangle Face4 {get; set;}

   public Pyramid (Triangle face1, Triangle face2, Triangle face3, Triangle face4)
   {
     Face1 = face1;
     Face2 = face2;
     Face3 = face3;
     Face4 = face4;
   }

   public double CalculateAreaOfTopPyramid()
   {
     Console.WriteLine("I am inside Area of CalculateAreaOfPyramid Calculation");
     return Face1.AreaOfTriangle() + Face2.AreaOfTriangle() + Face3.AreaOfTriangle() +Face4.AreaOfTriangle();
   }

 }

}