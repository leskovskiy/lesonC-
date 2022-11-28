// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

void Zadacha34()
{
    int size = 4;
    int[] array = new int[size];
    int count = 0;
    Fillarray(array, 100, 999);
    Printarray(array);

    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine(" В массиве  " + count + " четных числа");
    Console.WriteLine();

}

void Fillarray(int[] arr, int minValue, int maxValue)
{
    maxValue++;
    int size = 4;
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(minValue, maxValue);
    }
}

void Printarray(int[] arr)
{
    int size = 4;
    Console.WriteLine("Вывод массива : ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();

}

Zadacha34();

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов с нечётными индексами.

void Zadacha36()
{
    int size = 8;
    int[] array = new int[size];
    int sum = 0;
    Fillarray(array, 100, 999);
    Printarray(array);

    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0)
        {
            sum = array[i] + sum;
        }
    }
    Console.WriteLine($" Сумма нечетных элементов массива =  {sum}   ");
    Console.WriteLine();
}
Zadacha36();


//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.

void Zadacha38()
{
    int size = 6;
    double[] array = new double[size];
    Random rand = new Random();
    double result = 0;
    

    for (int i = 0; i < size; i++)
    {
        array[i] = rand.NextDouble()*10;
    }
    Console.WriteLine();
    Console.WriteLine("Вывод массива : ");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    for (int i = 0; i < size; i++)
    {
       result = array.Max() - array.Min();
    }
    Console.WriteLine($" Разница между максимальным и минимальным элементом массива = {result} ");
    Console.WriteLine();
    

}
Zadacha38();