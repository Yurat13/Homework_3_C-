// Задать массив из 12 элементов, заполненных числами из [0,9]. 
// Найти сумму положительных/отрицательных элементов массива

int[] array = new int [12];
int sum = 0;
int sumNegative = 0;
for (int i = 0; i < 12; i++)
{
    array[i] = new Random().Next(-9, 10);
    if (array[i] > 0)
    {
        sum = sum + array[i];
    }
    else if (array[i] < 0)
    {
        sumNegative = sumNegative + array[i];
    }
    Console.Write($" {array[i]} ");
}
Console.WriteLine();
Console.WriteLine($"Sum of positive array elements = {sum}");
Console.WriteLine($"Sum of negative array elements = {sumNegative}");