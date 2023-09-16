// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

void SortArray(int[,] array)
{
    // int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   //     for (int j = 0; j < array.GetLength(1); j++)


        for (int k = 0; k < array.GetLength(1) - 1; k++)
            for (int l = 0; l < array.GetLength(1) - 1; l++)

                if (array[i, l] > array[i, l + 1])

                    (array[i, l + 1], array[i, l]) = (array[i, l], array[i, l + 1]);
    }
}




System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int cols = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[rows, cols];
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SortArray(array);
PrintArray(array);

