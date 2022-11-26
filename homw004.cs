//Задача 25: Используя определение степени числа, напишите цикл, который принимает на вход 
//два натуральных числа (A и B) и возводит число A в степень B.

void Zadacha24()
{
    Console.WriteLine("Введите число А : ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B : ");
    int b = Convert.ToInt32(Console.ReadLine());
    int step = a;

    for (int i = 1; i < b; i++)
    {
        step = a * step;
    }
    Console.WriteLine("Результат возведения в степень =  " + step);

}
Zadacha24();


//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
void Zadacha27()
{
    Console.WriteLine("Введите число  : ");
    int a = Convert.ToInt32(Console.ReadLine());
    int res = 0;
    while (a > 0)
    {
        int num = a % 10;
        a = a / 10;
        res = num + res;
    }
    Console.WriteLine("Сумма цифр числа =  " + res);
}
Zadacha27();



//Задача 29: Напишите программу, которая задаёт массив 
//из 8 случайных целых чисел и выводит отсортированный по модулю массив.
void Fillarray(int[] arr)
{
    Random rand = new Random();
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(0, 100);
    }
}

void PrintArray(int[] arr)
{
    int size = arr.Length;

    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"{arr[i]}");
    }
    Console.WriteLine();
}

void SelectionSort(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size - 1; i++)
    {
        int minposition = i;

        for (int j = i + 1; j < size; j++)
        {
            if (arr[j] < arr[minposition]) minposition = j;
        }
        int temp = arr[i];
        arr[i] = arr[minposition];
        arr[minposition] = temp;
    }
    Console.WriteLine();
}
void Zadacha29()
{
    Console.WriteLine();
    Console.WriteLine("задача 29 ");
    int size = 8;
    int[] array = new int[size];

    Fillarray(array);
    PrintArray(array);
    SelectionSort(array);
}
Zadacha29();

