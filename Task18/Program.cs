// Задача 18

Console.WriteLine("Введите номер четверти");
string QuaterNum = Console.ReadLine();

string Range(string num)
{
    string a = "Диапозон координат находится в пределах";

    if(num == "1") return $"{a} -> Первой четверти";
    if(num == "2") return $"{a} -> Второй четверти";
    if(num == "3") return $"{a} -> Третий четверти";
    if(num == "4") return $"{a} -> Четвертой четверти";
    return "Введены неверные данные";
}  

string range = Range(QuaterNum);
Console.WriteLine(range);