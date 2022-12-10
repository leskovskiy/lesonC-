// Задача 47: Задайте двумерный массив размером m×n, заполненный 
//случайными вещественными числами ,округлёнными до одного знака.

void Zadacha47()
{
    Random rand = new Random();
    int m = 4;
    int n = 5;
    double[,] array = new double[m, n];
    FillArray(array);
    PrintArray(array);

}

void FillArray(double[,] array, double minvaliuue = 0, double maxvalue = 20)
{
    maxvalue++;
    Random rand = new Random();
    int m = array.GetLength(0);
    int n = array.GetLength(1);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(rand.NextDouble(), 1);
        }
    }
}

void PrintArray(double[,] array)
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

//Zadacha47();

//Напишите программу, которая на вход принимает индексы элемента в 
//двумерном массиве, и возвращает значение этого элемента или же указание,
// что такого элемента нет.

void Zadacha50()
{

    Console.WriteLine("Введите размеры массива");

    int m = Convert.ToInt32(Console.ReadLine());
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] arr = new int[m, n];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            arr[i, j] = Convert.ToInt32(new Random().Next(0, 15));
    }

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write(arr[i, j] + "\t  ");
        Console.WriteLine();
    }

    Console.WriteLine("Введите индексы элемента ");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = Convert.ToInt32(Console.ReadLine());
    if (a > m && b > n)
        Console.WriteLine("такого числа нет");
    else
    {
        object c = arr.GetValue(a, b);
        Console.WriteLine(c);
    }
    
}

//Zadacha50();

//Задача 52. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.

