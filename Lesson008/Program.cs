//Задача 1.
//Задайте двумерный массив. Напишите программу, которая поменяет местами две любые строки массива.


int [,] Created2dArray(int rows, int collumns, int minV, int maxV)
{
    int [,] createdArray = new int [rows, collumns];

    for(int i = 0; i < rows; i++){
        for(int j = 0; j < collumns; j++){

            createdArray[i,j] = new Random().Next(minV,maxV +1);
        }
    }
    return createdArray;
}

void ShowArray (int [,] printArray)
{
    for(int i =0; i<printArray.GetLength(0); i++){
        for(int j =0; j < printArray.GetLength(1); j++){
            Console.Write(printArray[i,j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}


int [,] ChangeRows (int [,] arrayToChange, int row1, int row2)
{
    if (row1 >= 0 && 
        row1 < arrayToChange.GetLength(0) && 
        row1 !=row2 && 
        row2 >= 0 && 
        row2 < arrayToChange.GetLength(0))
        {
            for(int j = 0; j < arrayToChange.GetLength(1); j++)
            {
                int temp = arrayToChange[row1, j];
                arrayToChange [row1,j] = arrayToChange[row2,j];
                arrayToChange[row2,j] = temp;
            }
        }
    else Console.WriteLine("Error! Impossible value");

    return arrayToChange;
}


Console.Write("Input count of rows: ");
int user_rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Input count of collumns: ");
int user_collumns = Convert.ToInt32(Console.ReadLine());

Console.Write("Input min value: ");
int user_min = Convert.ToInt32(Console.ReadLine());

Console.Write("Input max value: ");
int user_max = Convert.ToInt32(Console.ReadLine());



int [,] newArr = Created2dArray (user_rows, user_collumns, user_min, user_max);
ShowArray(newArr);

// Console.Write($"Input number of tne first row to remove from 0 to {user_rows - 1} ");
// int user_first_row = Convert.ToInt32(Console.ReadLine());

// Console.Write($"Input number of tne second row to remove from 0 to {user_rows - 1} ");
// int user_second_row = Convert.ToInt32(Console.ReadLine());

// ShowArray(ChangeRows(newArr, user_first_row, user_second_row));

//Задача 2.
// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы.
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ExchRowsCols (int[,] arrToChange)
{
    int[,] tempArr = new int[arrToChange.GetLength(0), arrToChange.GetLength(1)];
    if (arrToChange.GetLength(0) == arrToChange.GetLength(1))
    {
        for (int i = 0; i < arrToChange.GetLength(0); i++)
        {
            for (int j = 0; j < arrToChange.GetLength(1); j++)
            {
                tempArr[j, i] = arrToChange[i, j];
            }
        }
        return tempArr;
    }
    else
    {
        Console.WriteLine("Impossible to exchange rows with columns. Array is not square.");
        return arrToChange;
    }
}
// Console.WriteLine("");
// ShowArray(ExchRowsCols(newArr));

//Другой вариант решения

// int[,] ChangeRowAndCollum (int[,] array, int rows, int colums)
// {   int[,] temp = new int[rows, colums];
//     if (rows == colums)
//     {
//         for (int i = 0; i < array.GetLength(0); i += 1)
//         {
//             for (int j = 0; j < array.GetLength(1); j += 1)
//             {
//                 temp[j, i] = array[i, j];
//             }
//         }
//     }
//     else Console.WriteLine("Error: rows != colums");
//     return temp;
// }

// Console.Write("Input count of rows: ");
// int userRows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Input count of colums: ");
// int userColums = Convert.ToInt32(Console.ReadLine());
// int[,] secondArray = Create2dArray(userRows, userColums, 1, 9);
// Show2dIntArray(secondArray);
// int[,] changedArrayColum = ChangeRowAndCollum(secondArray, userRows, userColums);
// Show2dIntArray(changedArrayColum);




//Задача 3.
// Задайте двумерный массив из целых чисел. Напишите программу, которая обнулит строку и столбец,
// на пересечении которых расположен первый наименьший элемент массива.

int FindMin (int [,] arr)
{
    int min = arr[0,0];
    for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
               if (arr[i,j] < min)
               {
                    min = arr[i,j];
               }
            }
        }
        return min;
}

int [,] TargetNull (int [,] arrToNull, int minVal)
{
    int col = 0;
    int row = 0;
    int escape = 0;
    for (int i = 0; i < arrToNull.GetLength(0); i++){

        for(int j = 0; j < arrToNull.GetLength(1); j++){

            if (arrToNull[i,j] == minVal)

            {
                row = i;
                col = j;
                escape = 1;
                break;
            }
        }
        if (escape == 1) break;
    } 
    for (int i = 0; i <arrToNull.GetLength(0); i++){

        arrToNull[i, col] = 0;
    }
    for (int j = 0; j <arrToNull.GetLength(0); j++){

        arrToNull[row, j] = 0;
    }
    return arrToNull;
}

int minimum = FindMin(newArr);
ShowArray(TargetNull(newArr, minimum));
