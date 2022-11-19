// Напишите программу, которая принимает на вход 
//трёхзначное число и на выходе показывает вторую цифру этого числа.

void Zadacha10()
{
Console.WriteLine("Введите  число: ");
int a = Convert.ToInt32(Console.ReadLine());
string str = Convert.ToString(a);
Console.WriteLine("вторая цифра этого числа  "+ str[1]);

    
}
Zadacha10();


//Напишите программу, которая с помощью деления выводит третью цифру заданного числа или
//сообщает, что третьей цифры нет.
void Zadacha13()
{
    Console.WriteLine("Введите  число: ");
int a = Convert.ToInt32(Console.ReadLine());
 string str = Convert.ToString(a);


if (str.Length  >  2 )
    
        Console.WriteLine("Число " + a + " третья цифра " + str[2] );
else
    
    Console.WriteLine("Трьетьей цифры нет в числе " + a );
    
}
Zadacha13();

//Напишите программу, которая принимает на
//вход цифру, обозначающую день недели, и проверяет,
//является ли этот день выходным

void Zadacha15()
{
Console.WriteLine("Введите  число от 1 до 7 : ");
int a = Convert.ToInt32(Console.ReadLine());


if (a  < 5 )
    Console.WriteLine("Это будний день");
else 
    Console.WriteLine("Это выходной день ");
}
Zadacha15();