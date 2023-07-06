// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


 int [,] CreateArray2D (){

    int m = new Random().Next(3, 5);
    int n = new Random().Next(3, 5);

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
void Print2 (int [,] array2D){
    Console.WriteLine("Ваш сортированный построчно массив: ");
    Console.WriteLine();

    for(int i = 0; i < array2D.GetLength(0); i++){
        for(int j = 0; j < array2D.GetLength(1); j++){
            
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}


int [,] ArrangeArray (int [,] arrayRandom)
{
    int n = arrayRandom.GetLength(0); //строки
    int m = arrayRandom.GetLength(1); //столбцы
    int max = arrayRandom[0,0];

        
            for (int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                            for (int y = 0; y < m ; y++)

                            if (arrayRandom[i,y] > arrayRandom[i,j])
                            {
                                max = arrayRandom[i,y];
                                arrayRandom[i,y] = arrayRandom[i,j];
                                arrayRandom[i,j] = max;
                            }          
return arrayRandom;
}  

int [,] arr = CreateArray2D();
Print(arr);
Print2(ArrangeArray(arr));




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка



void MinSumRows (int [,] arrayNew){

int [] arrSumRows = new int [arrayNew.GetLength(0)]; //Создала одномерный масссив



    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < arrayNew.GetLength(1); j++){

        Sum = Sum + arrayNew[i,j]; //Считаю суммму каждой строки в двумерном массиве
        arrSumRows[i] = Sum;       //Перезаписываю ее как элемент одномерного
        
        }
    }    
    int minSum = arrSumRows[0];
    int count = 0;
    for (int z = 0; z < arrSumRows.Length; z++){
        
        if(arrSumRows[z] < minSum){
            minSum = arrSumRows[z];//ищу минимальное значение одномерного массива
            count = z+1;           //номер элемента минимального занчения
        }
        
    }
    Console.Write($"Минимальной является строка номер {count}, сумма ее значений составила {minSum}");
}

// int [,] arraytoMin = CreateArray2D();
// Print(arraytoMin);
// MinSumRows(arraytoMin);




// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18







// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


