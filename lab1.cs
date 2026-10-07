using System;

class Program
{
    static void Main()
    {
        Console.Write("Öğrencinin adını giriniz: ");
        string isim = Console.ReadLine();

        Console.Write("Vize notunu giriniz: ");
        double vize = Convert.ToDouble(Console.ReadLine());

        Console.Write("Final notunu giriniz: ");
        double final = Convert.ToDouble(Console.ReadLine());

        double ortalama = (vize * 0.40) + (final * 0.60);

        Console.WriteLine();
        Console.WriteLine("Öğrenci: " + isim);
        Console.WriteLine("Ortalama: " + ortalama);

        if (ortalama >= 50)
        {
            Console.WriteLine("Sonuç: Geçti");
        }
        else
        {
            Console.WriteLine("Sonuç: Kaldı");
        }
    }
}
