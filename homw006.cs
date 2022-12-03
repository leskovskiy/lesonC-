// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

void Zadacha41()
{
    Console.Write("Введите количество элементов : ");
    int elements = int.Parse(Console.ReadLine());
    int[] array = new int[elements];
    int count =0;
   
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"\nВведите  элемент массива под индексом {i} : ");
        array[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine();
    Console.Write("Вывод массива: ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    Console.WriteLine($"В заданом массиве {count} числа > 0 ");
}
Zadacha41();

//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.


void Zadacha43()
{
    
    Console.WriteLine("введите значение b1: ");
    double b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение k1: ");
    double k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение b2: ");
    double b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите значение k2: ");
    double k2 = Convert.ToInt32(Console.ReadLine());
    
    double x = (-b2+b1)/(-k1+k2);
    double y = k2 * x + b2;

    Console.WriteLine($"Прямые пересекаются в точках : {x}, {y} ");
}
Zadacha43();
