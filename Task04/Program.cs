// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.WriteLine("Введите три числа a b n: ");
Console.WriteLine("Введите первое число");
int a  = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число");
int n  = Convert.ToInt32(Console.ReadLine());
if (a > b)
{
    Console.WriteLine("Первое число больше");
}
if (b > n)
{
    Console.WriteLine("Второе число больше");
}
if (n > a)
{
     Console.WriteLine("Третье число больше");
}
else
{
     Console.WriteLine("Мы нашли максимальное число");
}