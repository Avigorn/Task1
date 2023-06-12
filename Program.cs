// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear(); // Очистка экрана
Console.Write("Введите число: ");
string num = Console.ReadLine();
int value = Convert.ToInt32(num);

if (value % 2 == 0)
{
    System.Console.WriteLine("Число чётное");
}
else
{
    System.Console.WriteLine("Число нечётное");
}