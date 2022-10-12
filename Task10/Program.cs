// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1
Console.WriteLine("Найдите вторую цифру из трёхзначного числа: ");
int number = new Random().Next(100 , 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
int secondDigit = number / 100;
int thirdDigit = number % 10;
int result = secondDigit * 10 + thirdDigit;
Console.WriteLine($"Итог: {result}");


