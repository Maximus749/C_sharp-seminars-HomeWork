// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int Summ(string insert)
{
    int lenght = insert.Length;
    int number = Convert.ToInt32(insert);
    int sum = 0;
    for (int i = 0; i < lenght; i ++){
        if (number > 9){
            sum = sum + number % 10;
        }
        else sum = sum + number;
        number = number / 10;

    }
    return sum;
}
Console.Write("Введите число: ");
string newString = Console.ReadLine();
Console.WriteLine(Summ(newString));
