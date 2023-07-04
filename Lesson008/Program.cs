//Задача 1.
//Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.


int [,] Created2dArray(int rows, int collumns, int minV, int maxV)
{
    int [,] createdArray = new int [rows,collumns];

    for(int i = 0; i < rows; i++){
        for(j = 0; j< collumns; j++){

            createdArray[i,j] = new Random().Next(minV,maxV +1);
        }
    }
}

void ShowArray (int [,] printArray)
{
    for(int i =0; i<printArray.GetLength(0); i++){
        for(int j =0; j<printArray.GetLength(1); j++)
            Console.Write(printArray[i,j] + " ");
    }
}