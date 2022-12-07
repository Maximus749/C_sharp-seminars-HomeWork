// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Pow(int digit1, int digit2)
{
    double result = Math.Pow(digit1, digit2);
    return result;
}

Console.Write("Insert digit 1: ");
int dig_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Insert digit 2: ");
int dig_2 = Convert.ToInt32(Console.ReadLine());
double number = Pow(dig_1, dig_2);
Console.WriteLine($"{dig_1} {dig_2} -> {number}");
