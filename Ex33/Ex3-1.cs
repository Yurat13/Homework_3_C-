// Подсчитать сумму цифр в числе
int n = new Random().Next(1, 100000);
Console.WriteLine(n);
int sum = 0;

while (n > 0)
{
    sum = sum + n%10;
    n = n/10;
}

Console.WriteLine(sum);
