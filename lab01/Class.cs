using System;
namespace Task2;
   public class Rectangle
{
    double side1;
    double side2;
   public  Rectangle(double sideA, double sideB)
    {
        side1 = sideA;
        side2 = sideB;
    }
    public double AreaCalculator()
    {
        return side1*side2;
    }
    public double PerimetrCalculator()
    {
        return 2 * (side1 + side2);
    }
   public double Area
    {
        get { return this.AreaCalculator(); }
    }
    public double Perimeter
    {
        get { return this.PerimetrCalculator(); }
    }
}
