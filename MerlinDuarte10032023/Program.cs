Console.Write("Introduce la altura del triángulo -> ");
int altura = int.Parse(Console.ReadLine());

for (int i = 1; i <= altura; i++)
{
    for (int t = 1; t <= i; t++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}