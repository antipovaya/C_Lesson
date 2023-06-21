//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int getDegreeAtoB (int a, int b){

//     int degree = 1;
//     for (int count = 1; count <= b; count++){

//         degree = degree*a;
//     }
//     return degree;    
// }

// Console.WriteLine ("Введите первое число: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine ("Введите второе число: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num2 < 0 ){
//     Console.WriteLine ("Второе число должно быть положительным!");

// }
// else{
// Console.WriteLine (getDegreeAtoB(num1, num2));

// }


//Задача 27: Напишите программу, которая принимает 
//на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// Console.WriteLine("Введите число: ");
// int user_num = Convert.ToInt32(Console.ReadLine());

// int getSumm (int num){
  
//     int sum = 0;
//     int a = num;

//     while (a > 0){

//         sum = sum + a % 10;
//         a = a / 10;
//     }
//     return sum;
// }
// Console.Write($"Сумма всех цифр числа {user_num} составила: ");
// Console.WriteLine(getSumm(user_num));


// Задача 29: Напишите программу, которая задаёт массив из 
// проивольного количества элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]



int [] CreateNewArray (int size_array)
{
    int [] randomarray = new int[size_array]; 
    for (int i = 0; i < size_array; i++){
        randomarray[i] = new Random().Next(0, 100);

    }
    return randomarray;
}

void PrintArray (int [] array_to_print){

    Console.WriteLine ("Ваш массив: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + " ");
}

Random x = new Random();
int size = x.Next(0, 100);


int [] firstArray = CreateNewArray(size);
PrintArray(firstArray);


