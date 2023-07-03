// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

// double [,] CreateARR2DRandom (){

//     int m = new Random().Next(2, 11);
//     int n = new Random().Next(3, 11);

//     double [,] arrRandom2D = new double [m, n];

//     for(int i = 0; i < m; i++)
//         for(int j = 0; j < n; j++)
//             arrRandom2D[i,j] = new Random().Next(-1,10) + new Random().NextDouble();
//     return arrRandom2D;
// }


// void Print (double [,] array2D){
// Console.WriteLine($"Создан массив с количеством строк: {array2D.GetLength(0)} и количеством столбцов: {array2D.GetLength(1)}. ");
// Console.WriteLine();
//     for(int i = 0; i < array2D.GetLength(0); i++){
//         for(int j = 0; j < array2D.GetLength(1); j++){
            
//             Console.Write($"{array2D[i,j]:f2}  ");
//         }
//         Console.WriteLine();
//     }
// Console.WriteLine();
// }

// double [,] newRandomArr = CreateARR2DRandom();
// Print(newRandomArr);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



//  int Message (string message){

//     Console.WriteLine(message);
//     int num_uz = Convert.ToInt32(Console.ReadLine());
//     return num_uz;
//  }


//  int [,] CreateArray2D (){

//     int m = new Random().Next(5, 11);
//     int n = new Random().Next(5, 11);

//     int [,] creatArr = new int [m, n];
//     for (int i = 0; i < m; i++){
//         for(int j = 0; j < n; j++)
//         {
//             creatArr[i,j] = new Random().Next(0, 10);
//         }
//     }
//     return creatArr;
//  }

// void Print (int [,] array2D){
//     Console.WriteLine("Ваш массив: ");
//     Console.WriteLine();

//     for(int i = 0; i < array2D.GetLength(0); i++){
//         for(int j = 0; j < array2D.GetLength(1); j++){
            
//             Console.Write(array2D[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
// Console.WriteLine();
// }


// void NumberSearch(int [,] arr, int user_row, int user_column){

//     if (arr.GetLength(0) >= user_row && arr.GetLength(1) >= user_column && user_row > 0 && user_column > 0){
//         Console.WriteLine($"Такой элемент существует в массиве, его значение: {arr[(user_row - 1), (user_column - 1)]}");
//     }
//     else Console.WriteLine("Искомый элемент не существует в массиве");
    
// }


// int [,] arrRandom = CreateArray2D();
// Print(arrRandom);

// int userRow = Message("Введите номер строки: ");
// int userColumn = Message("Введите номер столбца: ");

// NumberSearch (arrRandom, userRow, userColumn);




// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



 int [,] CreateArray2D (){

    int m = new Random().Next(5, 11);
    int n = new Random().Next(5, 11);

    int [,] creatArr = new int [m, n];
    for (int i = 0; i < m; i++){
        for(int j = 0; j < n; j++)
        {
            creatArr[i,j] = new Random().Next(0, 10);
        }
    }
    return creatArr;
 }

void Print (int [,] array2D){
    Console.WriteLine("Ваш массив: ");
    Console.WriteLine();

    for(int i = 0; i < array2D.GetLength(0); i++){
        for(int j = 0; j < array2D.GetLength(1); j++){
            
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}


void AvgLine (int [,] arrayNew){

double [] ArrAvg = new double [arrayNew.GetLength(1)];



    for (int j = 0; j < arrayNew.GetLength(1); j++)
    {
        double Average = 0;
        for (int i = 0; i < arrayNew.GetLength(0); i++){

        Average = Average + arrayNew[i,j];
        ArrAvg[j] = Math.Round((Average/arrayNew.GetLength(0)), 2);
        }    
    }
    
    for (int z = 0; z < ArrAvg.Length; z++){

        Console.Write(ArrAvg[z] + " ");
    }
}

int [,] arraytoAvg = CreateArray2D();
Print(arraytoAvg);
AvgLine (arraytoAvg);

