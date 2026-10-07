using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Toplama: " + (number1 + number2));
        Console.WriteLine("Çıkarma: " + (number1 - number2));
        Console.WriteLine("Çarpma: " + (number1 * number2));
        Console.WriteLine("Bölme: " + (number1 / number2));
    }
}
