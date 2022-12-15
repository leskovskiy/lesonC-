// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

void Zadacha54()
{
    Random rand = new Random();
    int m = 4;
    int n = 5;
    int[,] array = new int[m, n];
    FillArray(array, 9, -9);
    PrintArray(array);

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < n - j - 1; k++)
            {
                if (array[i, k] < array[i, k + 1]) ;
                {
                    int temp = array[i, k];
                    array[i, k] = array[i, k + 1];
                    array[i, k + 1] = temp;
                }
            }

        }
    }
    Console.WriteLine();
    PrintArray(array);
}
//Zadacha54();

//Задача 56. Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку 
//с наименьшей суммой элементов.

void Zadacha56()
{
    Random rand = new Random();
    int m = 4;
    int n = 5;
    int[,] array = new int[m, n];
    FillArray(array, 9, -9);
    PrintArray(array);
    int sumMin =    FindSumInRow(array,0);
    int indMin = 0;

    for (int i = 0; i < m; i++)
    {
        int sum = 0;
        for (int j = 0; j < n; j++)
        {
            sum += array[i, j];
        }
        Console.WriteLine($"Сумма {i+1} строки равна {sumMin}");
        if (sum < sumMin)
        {
            sumMin = sum;
            indMin = i;
        }
    }
    Console.WriteLine($"Минимальная сумма находиться в {indMin+1} строке и равна {sumMin}");
}

int FindSumInRow(int [,] array, int m)
{
    int sum = 0;
    int n = array.GetLength(1);
    for(int j = 0; j < n; j++)
    {
        sum = array[m,j];
    }
    return(sum);
}

Zadacha56();

void FillArray(int[,] array, int minvalue = 0, int maxvalue = 15)
{
    maxvalue++;
    Random rand = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = rand.Next(10);
        }
    }
}

void PrintArray(int[,] array)
{
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

