// Показать кубы чисел, заканчивающихся на четную цифру
Console.WriteLine("Enter number:");
double n = double.Parse(Console.ReadLine() ?? "0");
for (double i = 1; i <= n; i++)
{
double cube = Math.Pow (i, 3);
double lastNumber = cube % 10;
    if (lastNumber % 2 == 0)
    {
        Console.WriteLine($"{i} ^ {3} = {cube}");
    }
}
