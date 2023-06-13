// Напишите программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.
/*int Line()
{
int num = new Random().Next(10,100);
Console.WriteLine("Your num is " +num);
int dec = num/10;
int ed = num%10;
if(dec>ed){
    return dec;
}
else{
    return ed;
}
}
Console.WriteLine("Result is - " + Line());*/


//Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

/*int Line()
{
int num = new Random().Next(100,1000);
Console.WriteLine("Your num is " +num);
int num1 = num/100;
int num2 = num%10;
int z = num1*10 + num2;
return z;
}
Console.WriteLine("Result is - " + Line());
*/


// Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

/*Console.WriteLine("Enter first number");
int mum1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int mum2 = Convert.ToInt32(Console.ReadLine());*/
/*
int Line()
{
    Console.WriteLine("Enter first number");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Enter second number");
    int num2 = Convert.ToInt32(Console.ReadLine());

    int z = num2 % num1;
    if (z == 0)
    {
        return z;
    }
    else
    {
        
        return z;
    }
}
Console.WriteLine("Остаток от деления чисел равен " + Line());*/

/*System.Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num2 != 0 && num1 != 0){
if (num2 % num1 == 0){
System.Console.WriteLine("Число кратное");
}
else{
System.Console.WriteLine("Остаток = " + num2 % num1);
}
}
else{
System.Console.WriteLine("Не вводи 0)))");
}
*/

// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Enter number");
int num = Convert.ToInt32(Console.ReadLine());

void getNumberDiv (int x)
{
    int a = x % 7;
    int b = x % 23;
    if (a == 0 && b == 0){
      Console.WriteLine(x + " является кратным 7 и 23");  
    }
    else{
      Console.WriteLine(x + " не является кратным 7 и 23");    
    }
}
getNumberDiv(num);

// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*Console.WriteLine("Enter first number");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number");
int num2 = Convert.ToInt32(Console.ReadLine());

int a = num1*num1;
int b = num2*num2;
if (a = num2 || b = num1){
    Console.WriteLine("Enter second number");
}
*/