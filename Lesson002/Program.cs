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
Console.WriteLine("Остаток от деления чисел равен " + Line());