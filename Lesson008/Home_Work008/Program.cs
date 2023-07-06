// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


 int Message (string message){

    Console.WriteLine(message);
    int num_uz = Convert.ToInt32(Console.ReadLine());
    return num_uz;
 }


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

int [,] ArrangeArray (int [,] arrayRandom)
{
    int n = arrayRandom.GetLength(0); //строки
    int m = arrayRandom.GetLength(1); //столбцы
    int [,] arrayCorrect = new int[n,m];
    int max = 0;

    
            for (int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    max = 0;
                    if ( arrayRandom[i,j] > max){
                        max = arrayRandom[i,j];
                    }
                for (int x = 0; x < n; x++)
                {
                    for(int y = 0; y < m; y++)
                    {
                        arrayCorrect[x,y+j] = max;
                        max =0;
                    }
                }
                    
                }
            }
   

return arrayCorrect;
}  

// int [,] arr = CreateArray2D();
// Print(arr);
// Print(ArrangeArray(arr));






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

int [] arrSumRows = new int [arrayNew.GetLength(0)];



    for (int i = 0; i < arrayNew.GetLength(0); i++)
    {
        int Sum = 0;
        for (int j = 0; j < arrayNew.GetLength(1); j++){

        Sum = Sum + arrayNew[i,j];
        arrSumRows[i] = Sum;
        
        }
    }    
    int minSum = arrSumRows[0];
    int count = 0;
    for (int z = 0; z < arrSumRows.Length; z++){
        
        if(arrSumRows[z] < minSum){
            minSum = arrSumRows[z];
            count = z+1;
        }
        
    }
    Console.Write($"Минимальной является строка номер {count}, сумма ее значений составила {minSum}");
}

// int [,] arraytoMin = CreateArray2D();
// Print(arraytoMin);
// MinSumRows(arraytoMin);
