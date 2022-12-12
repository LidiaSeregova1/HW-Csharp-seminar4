// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
// степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите еще одно число:");
int number2 = Convert.ToInt32(Console.ReadLine());

int res = number1;

for (int i = 2; i <= number2; i++)
{
    res *= number1;
}

Console.WriteLine($"{number1}^{number2} = {res}");