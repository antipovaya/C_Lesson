// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



//  int Message (string message){

//     Console.WriteLine(message);
//     int num_uz = Convert.ToInt32(Console.ReadLine());
//     return num_uz;
//  }

//  int [] InputArray (int size){

//     int [] array = new int [size];
//     for ( int i = 0; i < size; i++){
//         array [i] = Message($"Введите {i+1}-й элемент");
//     }
//     return array;
//  }

//  void PrintArray (int [] array){

//     Console.WriteLine ("Ваши числа: ");

//     for(int i = 0; i < array.Length; i++)
//         if(i == array.Length - 1){
//            Console.Write($" {array[i]}. "); 
//         }
//         else
//             Console.Write($" {array[i]}, ");
//     Console.WriteLine();
    
//  }

// int CountPositiveNum (int[] userArray){
//     int count = 0;
//     for(int i = 0; i < userArray.Length; i++){

//         if (userArray[i] > 0){
//             count++;
//         }
//     }
//     return count;
// }

// int size = Message("Введите количество чисел");
// int [] newArray = InputArray(size);
// PrintArray(newArray);
// Console.WriteLine($"Количество чисел больше 0 составило: {CountPositiveNum(newArray)}");


// Задача 43: Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

//  double Message (string message){

//     Console.WriteLine(message);
//     double num_uz = Convert.ToDouble(Console.ReadLine());
//     return num_uz;
//  }

//  double [] IntersectionOfLines (double k1, double b1, double k2, double b2){

//     double x = (b2-b1)/(k1-k2);
//     double y = k1 * x + b1;
//     double [] intersectionArray = new double [2];
//     intersectionArray[0] = x;
//     intersectionArray[1] = y;

//     return intersectionArray;
//  }

//  void ShowArray (double [] intersectionShow){

//      Console.WriteLine ("Координаты точки пересечения двух линий равны: ");

//     for (int i = 0; i < intersectionShow.Length; i++)
//     {
//         if (i == 0)
//         Console.Write ($"({intersectionShow[i]:f3}; ");
//         else
//         Console.Write ($"{intersectionShow[i]:f3}). ");
//     }
   
// }

// double userK1 = Message("Введите число k1: "); 
// double userB1 = Message("Введите число b1: ");
// double userK2 = Message("Введите число k2: ");
// double userB2 = Message("Введите число b2: ");

// double [] Array = IntersectionOfLines(userK1, userB1, userK2, userB2);
// ShowArray(Array);