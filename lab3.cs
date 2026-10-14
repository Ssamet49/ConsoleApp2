Console.Write("Enter score: ");
int score = int.Parse(Console.ReadLine());
Console.Write($"score: {score}      --> ");
if(score < 0 || score > 100)
{
    Console.WriteLine("Invalid score");
}
else if (score >= 90)
{
    Console.WriteLine("A");
}
else if (score >= 80)
{
    Console.WriteLine("B");
}
else if (score >= 70)
{
    Console.WriteLine("C");
}
else if (score >= 60)
{
    Console.WriteLine("D");
}
else
{
    Console.WriteLine("F");
}
