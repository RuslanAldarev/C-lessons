// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Найдите вторую цифру из трёхзначного числа: ");
int number = new Random().Next(100 , 1000);
int SecondDigit(int num)
{
    return(((num%100)-(num%10))/10);
}
int a = int.Parse(Console.ReadLine());
Console.WriteLine(SecondDigit(a));




