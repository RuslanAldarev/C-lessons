// Задача 11
Console.WriteLine("Найдите первое и третье число");
int number = new Random().Next(100 , 1000);
Console.WriteLine($"Случайное число из отрезка 100 - 999 => {number}");
int firstDigit = number / 100;
int secondDigit = number % 10;
int result = firstDigit * 10 + secondDigit;
Console.WriteLine($"Итог: {result}");
