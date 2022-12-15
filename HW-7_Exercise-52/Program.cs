// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateArray(int row, int col)
{
    int[,] arr = new int[row, col];
    for(int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0;j < arr.GetLength(1); j++){
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void AverageAriphmSummColumn(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++){
        double columnSumm = 0;
        for (int i = 0; i < arr.GetLength(0); i++){
            columnSumm += arr[i, j];
        }
        Console.Write($"{Math.Round((columnSumm / arr.GetLength(0)), 2)}; ");
    }
}
int[,] matrix = CreateArray(3, 4);
PrintArray(matrix);
Console.WriteLine();
AverageAriphmSummColumn(matrix);
