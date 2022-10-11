// Задача 14

int arg(int Arg, int arg1, int arg2)
{
    int result = 1;
    if (Arg % arg1 == 0 && Arg % arg1 == 0) result = 0;
    return result;
}


Console.WriteLine("Введите число которое мы будем проверять на кратность");
int Number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: "); 
int secondnumber = Convert.ToInt32(Console.ReadLine());

int resultMy = arg(Number, firstnumber, secondnumber);
if (resultMy == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("нет");
}