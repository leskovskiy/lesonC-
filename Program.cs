
//Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.
void Zadacha2 ()
{
Console.WriteLine("Введите первое число: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int second = Convert.ToInt32(Console.ReadLine());

if (first > second )
    Console.WriteLine(first + " больше " + second);
else 
    Console.WriteLine(first + " меньше " + second);
}
Zadacha2();

//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
void Zadacha4()
{

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
 
 int max = Math.Max(Math.Max(a, b) , c);
 int min = Math.Min(Math.Min(a, b) ,c );

Console.WriteLine("Максимальное число: " + max);
Console.WriteLine("Минимальное число: "+ min );

}
Zadacha4();

//Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
void Zadacha6()
{
    Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 ==0 )
    Console.WriteLine(number + ": число четное  ");
else 
    Console.WriteLine(number + ": число нечетное  ");
}
Zadacha6();

//Напишите программу, которая на вход принимает 
//число (N > 0), а на выходе показывает все чётные числа от 1 до N.
void Zadacha8()

{  
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
N = Math.Abs(N);
int k = 1;

while (N <= k);
    
    if (k % 2 == 0)
    k++;
    Console.WriteLine( k +  " ");


Console.WriteLine();



}
Zadacha8();