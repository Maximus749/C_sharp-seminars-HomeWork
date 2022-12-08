// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArray(int lenght)
{
    int[] arr = new int[lenght];
    for(int i = 0; i < lenght; i++){
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

void PrintAndSelect(int[] arr)
{
    for (int i = 0; i < arr.Length; i++){
        Console.Write($"{arr[i]} ");
    }

    Console.Write(" -> ");

    int count = 0;
    for (int j = 0; j < arr.Length; j++){
        if (arr[j] % 2 == 0) count += 1;
    }
    Console.WriteLine(count);
}

int[] numbers = CreateArray(9);
PrintAndSelect(numbers);
