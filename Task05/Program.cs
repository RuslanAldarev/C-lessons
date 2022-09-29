// Задача 5
Console.WriteLine("Введите целое число:");
int n = Convert.ToInt32(Console.ReadLine());
int i = -n;
while (i <= n)
{
    Console.Write($"{i} ");
    i++;
}
