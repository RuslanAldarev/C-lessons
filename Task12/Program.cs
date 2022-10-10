// Задача 12
Console.WriteLine("Найдите кратные и не кратные числа");

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: "); 
int num2 = Convert.ToInt32(Console.ReadLine());

int result = num1 % num2;
if(result ==0) Console.WriteLine($"Число {num1} кратно числу {num2}");
else Console.WriteLine($"Число {num1} не кратно числу {num2}. Остаток от деления: {result}");
