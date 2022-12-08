// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int lenght)
{
    int[]arr = new int[lenght];
    for (int i = 0; i < lenght; i++){
        arr[i] = new Random().Next(0, 100);
    }
    return arr;
}

void PrintAndSum(int[] array)
{
    for ( int i = 0; i < array.Length; i ++){
        Console.Write($"{array[i]} ");
    }

    Console.Write(" -> ");
    int count = 0;
    for ( int j = 0; j < array.Length; j++){
        if (j % 2 != 0) count += array[j];
    }
    Console.WriteLine(count);
}

int[] num = CreateArray(5);
PrintAndSum(num);
