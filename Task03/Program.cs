// Задача номер 03

Console.WriteLine("Введите номер дня недели");
int numbers = Convert.ToInt32(Console.ReadLine());
if (numbers > 7)
{
    Console.Write("Любое число введённое больше 7 будет не корректно");
}
if (numbers == 1)
{
    Console.Write("понедельник");
}
if (numbers == 2)
{
    Console.Write("вторник");
}
if (numbers == 3)
{
    Console.Write("среда");
}
if (numbers == 4)
{
    Console.Write("четверг");
}
if (numbers == 5)
{
    Console.Write("пятница");
}
if (numbers == 6)
{
    Console.Write("суббота");
}
if (numbers == 7)
{
    Console.Write("воскресенье");
}

