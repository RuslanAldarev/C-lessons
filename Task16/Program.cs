// Задача 16

void square(int num1, int num2)
{
    int sqr = 0;
    if (num1 < num2)
    {
        sqr = num1 * num1;
        if (sqr == num2)
        {
            Console.WriteLine($"Число {num2} является квадратом числа {num1}");
        }
        else
        {
            Console.WriteLine($"Число {num2} не является квадратом числа {num1}");
        }
    }
    else
    {
        sqr = num2 * num2;
        if (sqr == num1)
        {
            Console.WriteLine($"Число {num1} является квадратом числа {num2}");
        }
        else
        {
            Console.WriteLine($"Число {num1} не является квадратом числа {num2}");
        }
    }
}

Console.WriteLine("Введите первое число: ");
int firstnumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int secondnumber = Convert.ToInt32(Console.ReadLine());
square(firstnumber, secondnumber);