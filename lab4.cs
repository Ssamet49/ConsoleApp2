int count = 0;
int sum = 0;
while (true)
{
    Console.Write("Enter the number (0 to stop): ");
    int sayi = int.Parse(Console.ReadLine());

    // Kullanıcı 0 girdiyse döngüden çık
    if (sayi == 0)
    {
        break;
    }

    // Sayı 0 değilse toplamı ve adedi güncelle
    sum += sayi;
    count++;
}

double average = 0;
if (count> 0)
{
    average = (double)sum / count;

}

Console.WriteLine("\n--- Sonuçlar ---");
Console.WriteLine($"count: {count}");
Console.WriteLine($"sum: {sum}");
Console.WriteLine($"average: {average}");
