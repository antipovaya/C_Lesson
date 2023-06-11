// Задача 2: Напишите программу, которая на вход 
//принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

/*Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine("max = " + a);
    Console.WriteLine("min = " + b);
}
else
{
    if (a == b)
    {
       Console.WriteLine(a + " = " + b); 
    }
    else
    {
        Console.WriteLine("max = " + b);
        Console.WriteLine("min = " + a);
    }
}
*/

//Задача 4: Напишите программу, которая принимает на вход три 
//числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

/*Console.WriteLine("Enter first number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter third number: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;
if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);
*/

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//4 -> да
//-3 -> нет
//7 -> нет
/*
Console.WriteLine("Enter your number: ");
int a = Convert.ToInt32(Console.ReadLine());

int x = a % 2;

if (x == 0)
{
    Console.Write("Your number " + a);
    Console.WriteLine(" is even");
}
else
{
    Console.Write("Your number " + a);
    Console.WriteLine(" is not even");
}
*/

//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine ("Enter one number");
int number = Convert.ToInt32(Console.ReadLine());

int count = number * -1;

while (count <= number)
{
    Console.WriteLine(count);
    count = count + 1; 
}
