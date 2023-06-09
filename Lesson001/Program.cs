/*
Console.WriteLine("Today is Friday");
Console.Write("Today is friday");

Console.ReadLine(); // string // Нужно ли переводить строку в число? Да.
int number = Convert.ToInt32(Console.ReadLine());
*/
/*Console.WriteLine("Input number");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(number);
Console.WriteLine($"your number is {number}");
// Задача 1.
//Напишите программу, которая на вход принимает число и выдаёт его квадрат*/


/*Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine(result);
*/



//Задача 3. 
//Напишите программу, которая на вход принимает два числа и проверяет, 
//является ли первое число квадратом второго.

/*Console.WriteLine("Enter first number: ");
Console.WriteLine("Enter second number: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 == number2 * number2)
{
    Console.WriteLine("First number is a square of the second one");
}
else
{
    Console.WriteLine(number1 + " is not a square of the " + number2);
}
*/

// Задача 5
// Напишите программу, которая на вход принимет одно число (N)?
// а на выходе показывает все целые числа от -N до N

/*Console.WriteLine ("Enter one number");
int number = Convert.ToInt32(Console.ReadLine());

int count = number * -1;

while (count <= number)
{
    Console.WriteLine(count);
    count = count + 1; // count += 1    count++
}
*/

//Задача 7
//Напишите программу, которая принимает на вход трехзначное число и
// на выходе показывает последгюю цифру этого числа.

// Деление на цело 
// Деление с остатком
// 11 / 3 = 3   деление нацело
// 11 % 3 = 2   остаток от деления 11 на 3
/*
456 % 10 = 6
456 / 10 = 45

456 % 100 = 56
456 / 100 = 4

456 % 1000 = 456
456 / 1000 = 0
*/
Console.WriteLine("Enter number");
int number = Convert.ToInt32(Console.ReadLine());
if (number >= 100)
{
    int a = number % 10;
    Console.WriteLine(a);
}
else 
{
    Console.WriteLine("Пожалуйста, введите трехзначное число");
}
