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

    int m = new Random().Next(3, 7);
    int n = new Random().Next(3, 7);

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
    int n = arrayRandom.GetLength(0);
    int m = arrayRandom.GetLength(1);
    int [,] arrayCorrect = new int [arrayRandom.GetLength(0), arrayRandom.GetLength(1)];
    int max = arrayRandom[0,0];
    arrayCorrect[n - 1, m - 1] = arrayRandom[0,0];

    for (int i = 0; i < arrayRandom.GetLength(0) ; i++){

        for(int j = 0; j < arrayRandom.GetLength(1); j++){

            if (arrayRandom[i,j] > max) {
                max = arrayRandom[i,j];
                arrayCorrect[n - 1 - i, m - 1 - j] = max;
            }
        }
    }
    return arrayCorrect;
}