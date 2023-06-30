// Зфдайте двумерный массив размером m на n, заполненный случайнми целыми числами


// int [,] Create2DArray () // сщздание двумерного массива
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

//     for (int i = 0; i < array2d.GetLength; i++){
//         for(int j = 0; j < array2d.GetLength; j++)
//         {
//             Console.Write(array2d[i,j] + " ");
//         }
//         Console.WriteLine();
// }
// Console.WriteLine();
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

// int FillArray (){


//     //Console.WriteLine("Enter count of rows: ");
//     int userR =3; // Convert.ToInt32(Console.ReadLine());

//     //Console.WriteLine("Enter count of collumns: ");
//     int userC = 4;//Convert.ToInt32(Console.ReadLine());

//     int [,] fille2dArray = new int [userR,userC];
//     for(int i =0; i<userR;i++)
//         for(int i =0; i<userC;i++)
//             fille2dArray[i,j] = i + j;
//     return fille2dArray;

// }
// int [,] secondArr = FillArray();


//Задайте двумерный вещественный массив. Найдите элементы, у которых оба индекса чётные, 
//и замените эти элементы на их квадраты.


// Дан двумерный массив. Вывести на экран:
// а) все элементы пятой строки массива;
// б) все элементы s-го столбца массива.

//Дан двумерный массив. Найти:
//а) сумму элементов, расположенных в левом верхнем и правом нижнем углах;
//б) среднее арифметическое элементов, расположенных в четырех углах.