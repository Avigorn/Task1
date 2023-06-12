// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear(); // Очистка экрана
Console.Write("Введите первое число: ");
string num1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string num2 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
int number2 = Convert.ToInt32(num2);
int max = 0;

if (number1 > number2)
{
    max = number1;
}
else max = number2;

Console.WriteLine(max);