// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Write("Введите несколько чисел от -1000 до 1000 через пробел: ");
int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
foreach (int num in numbers)
{
    if (num > 0) count += 1;
}
Console.WriteLine($"{count} ");