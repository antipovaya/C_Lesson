//Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
//m = 3, n = 4.

// int [,] Create2DArray () // создание двумерного массива
// {
//     Console.WriteLine("Enter count of rows: ");
//     int userR = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter count of collumns: ");
//     int userC = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter min: ");
//     int userMin = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter max: ");
//     int userMax = Convert.ToInt32(Console.ReadLine());

    

//     int [,] creatArr = new int [userR, userC];
//     for (int i = 0; i < userR; i++){
//         for(int j = 0; j < userC; j++)
//         {
//             creatArr[i,j] = new Random().Next(userMin, userMax +1);
//         }
//     }
//     return creatArr;
// }

// void Print (int [,] array2d){

//     for (int i = 0; i < array2d.GetLength(0); i++){
//         for(int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine(); // переход вывода на новую строку
// }
// Console.WriteLine(); // отступ от массива
// }

// int [,] new2darr = Create2DArray();
// Print(new2darr);

/*Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3      [0,0] [0,1] [0,2] [0,3]  
1 2 3 4      [1,0] [1,1] [1,2] [1,3]
2 3 4 5
*/

// int [,] FillArray (){


//     //Console.WriteLine("Enter count of rows: ");
//     int userR =3; // Convert.ToInt32(Console.ReadLine());

//     //Console.WriteLine("Enter count of collumns: ");
//     int userC = 4;//Convert.ToInt32(Console.ReadLine());

//     int [,] fille2dArray = new int [userR, userC];

//     for(int i =0; i < userR; i++)

//         for(int j =0; j < userC; j++)

//             fille2dArray[i,j] = i + j;
//     return fille2dArray;

// }

// void Print (int [,] array2d){

//     for (int i = 0; i < array2d.GetLength(0); i++){
//         for(int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine(); // переход вывода на новую строку
// }
// Console.WriteLine(); // отступ от массива
// }
// int [,] secondArr = FillArray();
// Print (secondArr);


//Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.

// double [,] Create2DArray () // создание двумерного массива
// {
//     Console.WriteLine("Enter count of rows: ");
//     int userR = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter count of collumns: ");
//     int userC = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter min: ");
//     int userMin = Convert.ToInt32(Console.ReadLine());

//     Console.WriteLine("Enter max: ");
//     int userMax = Convert.ToInt32(Console.ReadLine());

    

//     double [,] creatArr = new double [userR, userC];
//     for (int i = 0; i < userR; i++){
//         for(int j = 0; j < userC; j++)
//         {
//             creatArr[i,j] = Math.Round((new Random().Next(userMin, userMax +1) + new Random().NextDouble()), 2);
//         }
//     }
//     return creatArr;
// }

// double [,] ModiArray (double [,] arrayStart){

//     for (int i = 0; i < arrayStart.GetLength(0); i++)
//         for(int j = 0; j < arrayStart.GetLength(1); j++)

//             if (i%2 == 0 && j%2 ==0)
//                 arrayStart[i,j] *= arrayStart[i,j];

//         return arrayStart;
// }

// void Print (double [,] array2d){

//     for (int i = 0; i < array2d.GetLength(0); i++){
//         for(int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine(); // переход вывода на новую строку
// }
// Console.WriteLine(); // отступ от массива
// }

// double [,] newArray = Create2DArray();
// Print(newArray);
//  double [,] modiArr = ModiArray (newArray);
// Print(modiArr);



// Дан двумерный массив. Вывести на экран:
// а) все элементы пятой строки массива;
// б) все элементы s-го столбца массива.


// int [,] Create2DArray () // создание двумерного массива
// {
    
//     int userR = new Random().Next(6, 11);
//     int userC = new Random().Next(6, 11);

//     int [,] creatArr = new int [userR, userC];
//     for (int i = 0; i < userR; i++){
//         for(int j = 0; j < userC; j++)
//         {
//             creatArr[i,j] = new Random().Next(1, 16);
//         }
//     }
//     return creatArr;
// }

// void Print (int [,] array2d){

//     for (int i = 0; i < array2d.GetLength(0); i++){
//         for(int j = 0; j < array2d.GetLength(1); j++)
//         {
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine(); // переход вывода на новую строку
// }
// Console.WriteLine(); // отступ от массива
// }


// int [,] taskArray = Create2DArray();
// Print (taskArray);


// void Print5Line (int [,] array){

//     for( int j = 0; j < array.GetLength(1); j++)
//         Console.Write (array[4,j] + " ");

// }
// Print5Line (taskArray);


//Дан двумерный массив. Найти:
//а) сумму элементов, расположенных в левом верхнем и правом нижнем углах;
//б) среднее арифметическое элементов, расположенных в четырех углах.

int [,] Create2DArray () // создание двумерного массива
{
    
    int userR = new Random().Next(6, 11);
    int userC = new Random().Next(6, 11);

    int [,] creatArr = new int [userR, userC];
    for (int i = 0; i < userR; i++){
        for(int j = 0; j < userC; j++)
        {
            creatArr[i,j] = new Random().Next(1, 16);
        }
    }
    return creatArr;
}

void Print (int [,] array2d){

    for (int i = 0; i < array2d.GetLength(0); i++){
        for(int j = 0; j < array2d.GetLength(1); j++)
        {
            Console.Write(array2d[i,j] + " ");
        }
        Console.WriteLine(); // переход вывода на новую строку
}
Console.WriteLine(); // отступ от массива
}

int [,] taskArray = Create2DArray();
Print (taskArray);

double Avg (int [,] array){

    double sum = Math.Round(((array[0,0] + 
    array[(array.GetLength(0) -1), (array.GetLength(1) - 1)] + 
    array[array.GetLength(0) - 1, 0] + 
    array[0, array.GetLength(1) - 1])/4.0),2);

    return sum;
}

Console.WriteLine(Avg(taskArray));