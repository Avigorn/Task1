// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear(); // Очистка экрана
Console.Write("Введите первое число: ");
string num1 = Console.ReadLine();
Console.Write("Введите второе число: ");
string num2 = Console.ReadLine();
Console.Write("Введите третье число: ");
string num3 = Console.ReadLine();
int number1 = Convert.ToInt32(num1);
int number2 = Convert.ToInt32(num2);
int number3 = Convert.ToInt32(num3);
int maximum = Math.Max(number1, Math.Max(number2, number3));

System.Console.WriteLine(maximum);
