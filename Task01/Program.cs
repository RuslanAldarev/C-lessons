// Задача 1
Console.WriteLine("Введите два числа");
Console.WriteLine("Введите первое число");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int square_a = a * a;
if (square_a == b)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}