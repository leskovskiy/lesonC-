//Задача 19
//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.

void Zadacha19()
{
    Console.WriteLine("Введите пятизначное число :  ");
    int N = Convert.ToInt32(Console.ReadLine());
    string str = Convert.ToString(N);
        
      if (str[0] == str[4] && str[1] == str[3])   Console.WriteLine("Число : " + N + " палиндром ");
      else Console.WriteLine("Число : " + N + " не является палиндром ");
       if (str.Length > 5 && str.Length < 5) Console.WriteLine("Введите корректные данные");

}
Zadacha19();

//Задача 21
//Напишите программу, 
//которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

void Zadacha21()
{
    Console.WriteLine("Введите X1 :  ");
    int x1 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите Y1 :  ");
    int y1 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите Z1 :  ");
    int z1 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите X2 :  ");
    int x2 = Convert.ToInt32(Console.ReadLine()); 
    Console.WriteLine("Введите Y2 :  ");
    int y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите Z2 :  ");
    int z2 = Convert.ToInt32(Console.ReadLine()); 

    double res = 0;
    res = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1),2)+ Math.Pow((z2 - z1),2));
     Console.WriteLine(" расстояние между координатами =  " + res);

}
Zadacha21();

//Задача 23
//Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

void Zadacha23()
{
Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int count = 1;

while(count <= N)
{
Console.WriteLine($"{count} * {count} * {count} = {count * count * count}");
 count++;
}

}
Zadacha23();