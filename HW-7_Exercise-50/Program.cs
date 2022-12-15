// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

int[,] CrateArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++){
        for (int j = 0; j < array.GetLength(1); j ++){
            array[i, j] = new Random().Next(10);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i ++){
        for(int j = 0; j < array.GetLength(1); j ++){
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindElement1(int[,] array)
{
    Console.Write("Введите номер строки массива(1-3): ");
    int rowNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца массива(1-4): ");
    int columnNumber = Convert.ToInt32(Console.ReadLine());
    if (((rowNumber) <= array.GetLength(0) && (rowNumber - 1) >= 0) 
    && (columnNumber) <= array.GetLength(1) && (rowNumber - 1) >= 0){
        Console.WriteLine($"В указанных координатах находится число {array[rowNumber - 1, columnNumber - 1]}");
    }
    else Console.WriteLine($"Таких координат в данном массиве нет");
}
void FindElement2(int[,] array)
{
    Console.Write("Введите число, а я поищу его в массиве: ");
    int num = Convert.ToInt32(Console.ReadLine());
    bool x = false;
    for (int i = 0; i < array.GetLength(0); i ++){
        for(int j = 0; j < array.GetLength(1); j ++){
            if (num == array[i, j]){
                Console.WriteLine($"Указанное число находится в {i + 1} строке, {j + 1} столбце.");
                x = true;
            }
        }
    }
    if (x == false) Console.WriteLine("Такого числа в массиве нет");
}
int[,] matrix = CrateArray(3, 4);
PrintArray(matrix);
Console.WriteLine();
FindElement1(matrix);
FindElement2(matrix);