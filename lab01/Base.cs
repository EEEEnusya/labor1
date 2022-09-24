
using Task2;

internal class Program
{
    private static void Main(string[] args)
    {
        double side1;
        double side2;
        Console.Write("Введите длину одной стороны:");
        side1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Введите длину другой стороны:");
        side2 = Convert.ToInt16(Console.ReadLine());
        Rectangle ABCD = new Rectangle (side1, side2);
        double S= ABCD.AreaCalculator();
        double P = ABCD.PerimetrCalculator();
        Console.WriteLine($"S= {S}");
        Console.WriteLine($"p= {P}");
    }

}