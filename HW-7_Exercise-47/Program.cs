// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateArray()
{
    Console.Write("Введите количество строк масссива: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите количество столбцов масссива: ");
    int col = Convert.ToInt32(Console.ReadLine());
    double[,] arr = new double[row, col];
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            arr[i, j] = new Random().Next(- 999, 1000) / 100;
        }
    }
    return arr;
}
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j++){
            Console.Write($"{array[i, j]} ");
        }
    Console.WriteLine();
    }
}
double[,] matrix = CreateArray();
PrintArray(matrix);