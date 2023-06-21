//Задача 1.
//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

//1.1 Через for

// void FindSumm1toA (int num_a)
// {
//     int sumOfElem = 0;
//     for (int current = 1; current <= num_a; current++){
//         sumOfElem += current; // sumOfElem = sumOfElem + current
//     }
// Console.WriteLine($"Сумма чисел от 1 до {num_a} равна {sumOfElem}");

// }
// Console.WriteLine ("Введите число: ");

// int num = Convert.ToInt32(Console.ReadLine());
// if (num > 0)
// {
//     FindSumm1toA(num);
// }
// else {
//     Console.WriteLine("Введите положительное число");
// }

// 1.2 Через while

// void Find (int n)
// {

//     int sum = 0;
//     int temp = 1;
//     while (temp <= n){
//         sum += temp;
//         temp++;
//     }
//     Console.WriteLine($"Сумма чисел от 1 до {n} равна {sum}");
// }

// Console.WriteLine("Пожалуйста введите положительное число");
// int user_num = Convert.ToInt32(Console.ReadLine());
// if (user_num < 0){
//     Console.WriteLine($"Число {user_num} не является положительным, введите положительное");
// }
// else{
//     Find (user_num);
// }

// Задача 2.
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
//456 -> 3
//78 -> 2
//89126 -> 5


// Console.WriteLine("Введите число ");
// int num = Convert.ToInt32(Console.ReadLine());

// int CountOfDigits (int num_user)
// {
//     int count = 0;
//     while (num_user > 0)
//     {
//         num_user /= 10;
//         count++;
//     } 
//     return count;
// }

// int res;
// if (num >=0){
//     res = CountOfDigits(num);
// }
// else{
//     int num1 = (-1) * num;
//     res = CountOfDigits(num1);
// }
// Console.WriteLine(res);
//Console.WriteLine(CountOfDigits(num));


//Задача 3.
//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
//4 -> 24 
//5 -> 120


// int FindMulty(int user_n){

//     int composition = 1;
//     for (int count = 1; user_n >= count; count++){
//         composition *= count;
//     }
//         return composition;
        
// }
// Console.WriteLine("Пожалуйста введите число ");
// int num = Convert.ToInt32(Console.ReadLine());
// int res = FindMulty(num);
// if (num <= 0){
//     Console.WriteLine(0);
// }
// else {
//     Console.WriteLine(res);
// }




//Задача 4.

//Напишите программу, которая выводит массив из 8 элементов, 
//заполненный нулями и единицами в случайном порядке.

//[1,0,1,1,0,1,0,0]



int [] CreateNewArray (int size_array)
{
    int [] randomarray = new int[size_array]; //int - целочисленные массивы нью - выделение памяти под массив
    for (int i = 0; i < size_array; i++){
        randomarray[i] = new Random().Next(0,2);
    }
    return randomarray;
}

void PrintArray (int [] array_to_print){

    Console.WriteLine ("Ваш массив: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + " ");
}

int size = 8;


int [] firstArray = CreateNewArray(size);
PrintArray(firstArray);