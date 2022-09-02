// Возведите число А в натуральную степень B используя цикл
Console.WriteLine("Enter number A: ");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Enter number B: ");
double b = double.Parse(Console.ReadLine());
for (double i = 0; i <= b; i++)
{
Console.WriteLine($"{a}^{b} = {Math.Pow (a, i)}");
}
// double z = Math.Pow (a, b);



