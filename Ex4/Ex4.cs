// Написать программу вычисления произведения чисел от 1 до N
// Console.WriteLine("Enter number N:");
Console.WriteLine("Enter number N:");
int n = int.Parse(Console.ReadLine() ?? "0");

for (int i = 1; i <= n; i++)
{
    for (int j = 1; j <= 9; j++)
    {
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.WriteLine();
}







