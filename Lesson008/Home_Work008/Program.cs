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

// int [,] arr = CreateArray2D();
// Print(arr);
// Print2(ArrangeArray(arr));




// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


 int [,] CreateRectangularArray2D (){

    int m = new Random().Next(3, 5);
    int n = m + 2;

    int [,] creatArr = new int [m, n];
    for (int i = 0; i < m; i++){
        for(int j = 0; j < n; j++)
        {
            creatArr[i,j] = new Random().Next(0, 10);
        }
    }
    return creatArr;
 }

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
    int count = 1;
    for (int z = 0; z < arrSumRows.Length; z++){
        
        if(arrSumRows[z] < minSum){
            minSum = arrSumRows[z];//ищу минимальное значение одномерного массива              
            count = z+1;
        }
        
    }
    Console.Write($"Минимальной является строка номер {count}, сумма ее значений составила {minSum}");
}

// int [,] arraytoMin = CreateRectangularArray2D();
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

// if(Matrix1.GetLength(1) == Matrix2.GetLength(0)) - это записать в метод по созданию матриц
   
int [,] MatrixProduct (int [,] Matrix1, int [,] Matrix2)
{
    
    int [,] finalArray = new int [Matrix1.GetLength(0), Matrix2.GetLength(1)];

    for(int j = 0; j < finalArray.GetLength(1); j++)
    {
        for(int i = 0; i < finalArray.GetLength(0); i++)
        {
            finalArray[i,j] = Matrix1[i,j]*Matrix2[j,j] + Matrix1[i,j+1]*Matrix2[j+1,j];
        }
    }
return finalArray;
}

int [,] CreateArray2DMatrix1 (){

    int m = 2;
    int n = 3;

    int [,] creatArr = new int [m, n];
    for (int i = 0; i < m; i++){
        for(int j = 0; j < n; j++)
        {
            creatArr[i,j] = new Random().Next(0, 10);
        }
    }
    return creatArr;
 }

int [,] CreateArray2DMatrix2 (){

    int m = 3;
    int n = 2;

    int [,] creatArr = new int [m, n];
    for (int i = 0; i < m; i++){
        for(int j = 0; j < n; j++)
        {
            creatArr[i,j] = new Random().Next(0, 10);
        }
    }
    return creatArr;
 }

int[,] Matr1 = CreateArray2DMatrix1();
Print(Matr1);

int[,] Matr2 = CreateArray2DMatrix2();
Print(Matr2);

Print(MatrixProduct(Matr1,Matr2));



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int [] SupportingArray (int row, int col, int dep)
{
int[] uniqueArray = new int[row*col*dep];
    for (int z = 0; z < uniqueArray.Length; z++)
    {
        uniqueArray[z] = new Random().Next(10, 20);
    } 
   return uniqueArray;
}

void CheckArray (int [] arr)
{
    int count = 10;
    for (int i = 0; i < arr.Length; i++)
        for (int k = 1; k < arr.Length; k++)
    {
        if (arr[i] == arr[k])
        {
            arr[k] = arr[k] + count; 
            count--;
            
        }
        else count++;
    }
  Console.WriteLine();  
}


void PrintArray (int [] array_to_print){

    Console.WriteLine ("Ваш вспомогательный массив: ");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + " ");
        Console.WriteLine();
}

int[,,] Create3DArray (int row, int col, int dep, int [] arr) 
{
    
    int[,,] matrix = new int[row, col, dep];
    int c = 0;

    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
               
                    {
                        matrix[i,j,k] = arr[c];
                        c++;
                    }
                    
        }        
    }    

    
    return matrix;
} 
 

void Print3D(int[,,] matrix)
{
    Console.WriteLine();
    Console.WriteLine("Ваш трехмерный массив из неповторяющихся чисел: ");
    Console.WriteLine();

    for (int k = 0; k < matrix.GetLength(2); k++)
    {
        for (int i = 0; i <  matrix.GetLength(0); i++)
        {
            Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++) 
                  
                {
                    Console.Write($"{matrix[i, j, k], 1}({i},{j},{k})|");            
                }
    
            Console.WriteLine();        
        }        
    }
}

// int [] firstArray = SupportingArray(2,2,2);
// PrintArray(firstArray);
// CheckArray(firstArray);
// PrintArray(firstArray);
// int[,,] array3D = Create3DArray(2, 2, 2, firstArray);
// Print3D(array3D);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


 int [,] CreateSpiralArray2D (){

    int m = 4;
    int n = 4;

    int [,] createSpiralArr = new int [m, n];
    int count = 1;
    for (int i = 0; i == 0; i++){
        for(int j = 0; j < n; j++)
        {
            createSpiralArr[i,j] = count;
            count++;
        }
    }
    for (int j = n-1; j == n-1; j++){
        for(int i = 1 ; i < m; i++)
        {
            createSpiralArr[i,j] = count;
            count++;
        }
    }
    for (int i = m-1; i == m-1; i++){
        for(int j = n - 2; j >= 0; j--)
        {
            createSpiralArr[i,j] = count;
            count++;
        }
    }
    for (int j = 0; j == 0; j++){
        for(int i = m-2; i >0; i--)
        {
            createSpiralArr[i,j] = count;
            count++;
        }
    }
    for (int i = 1; i == 1; i++){
        for(int j = 1; j < n-1; j++)
        {
            createSpiralArr[i,j] = count;
            count++;
        }
    }
    for (int j = n-2; j == n-2; j++){
        for(int i = m-2; i == m-2; i++)
        {
            createSpiralArr[i,j] = count;
            count++;
        }
    }
     for (int i = m-2; i == m-2; i++){
        for(int j = 1; j ==1; j++)
        {
            createSpiralArr[i,j] = count;
            count++;
        }
    }
    
    return createSpiralArr;
 }

 void Print3 (int [,] array2D){
    Console.WriteLine("Ваш массив: ");
    Console.WriteLine();

    for(int i = 0; i < array2D.GetLength(0); i++){
        for(int j = 0; j < array2D.GetLength(1); j++){

            if(array2D[i,j] <10)
            {
                 Console.Write($"{0}{array2D[i,j]} ");
            }    
            else Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}

// int [,] arr = CreateSpiralArray2D();
// Print3(arr);

