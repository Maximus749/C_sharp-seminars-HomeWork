// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int lenght)
{
    int[] name = new int[lenght];
    for (int i = 0; i < lenght; i++){
        name[i] = new Random().Next(0, 100);
    }
    return name;
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] numbers = CreateArray(8);
PrintArray(numbers);