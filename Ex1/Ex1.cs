// Найти кубы чисел от 1 до N
Console.WriteLine("Enter number N: ");
int n = int.Parse(Console.ReadLine());
int i;
for (i = 1; i <= n; i++)
{
int cube = i*i*i;
Console.WriteLine($"{i}^3 = {cube}");
}