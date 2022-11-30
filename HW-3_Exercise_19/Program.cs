// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

char[] numbers = num.ToString().ToArray();
int k = numbers.Length - 1;
int count = 0;
for(int i = 0; i < (numbers.Length / 2); i++){
    if (numbers[i] == numbers[k - i]){
        count ++;
    }

}
for (int j = 0; j < numbers.Length; j++){
    Console.Write($" {numbers[j]}");
}
if(count == (numbers.Length / 2)) Console.WriteLine(" -> Yes");
else    Console.WriteLine(" -> No");
