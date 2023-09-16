// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// 18 = 2 * 3 + 4 * 3
// 20 = 2 * 
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

int[,] ProdArray(int[,] array1, int[,] array2)
{
    int[,] result = new int[array1.GetLength(0), array2.GetLength(0)];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                sum += array1[i, k] * array2[k, j];
            }
            result[i, j] = sum;
        }
       
    } return result;
}




System.Console.WriteLine("Введите количество строк");
int rows = Convert.ToInt32(Console.ReadLine());
int[,] array1 = new int[rows, rows];
int[,] array2 = new int[rows, rows];
FillArray(array1);
PrintArray(array1);
System.Console.WriteLine();
FillArray(array2);
PrintArray(array2);
System.Console.WriteLine();
PrintArray(ProdArray(array1, array2));