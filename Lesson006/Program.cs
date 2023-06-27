//Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, 
//а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


// int [] CreatArray (int min, int max){

//     int size = new Random().Next(7, 9);
//     int [] newArray = new int [size];

//     for (int i = 0; i < size; i++)
//     {
//         newArray [i] = new Random().Next(min, max + 1);
//     }

//     return newArray;
// }


// // void PrintArray (int [] arrayToShow){

// //      Console.WriteLine ("Ваш массив: ");

// //     for (int i = 0; i < arrayToShow.Length; i++)
// //     {
// //         Console.Write (arrayToShow[i] + " ");
// //     }
   
// // }


void PrintArray(int[] arrToPrint)
{
    Console.WriteLine("Массив:");
    for (int i = 0; i < arrToPrint.Length; i++)
    {
        Console.Write(arrToPrint[i]);
        if (i != arrToPrint.Length - 1) Console.Write(", ");
        else Console.WriteLine(".");
    }
    Console.WriteLine();
}

// int [] ReversArray (int [] arrayRevers){

//     int k = arrayRevers.Length;
//     for(int i = 0; i < k/2; i++){

//         int temp = arrayRevers[i];
//         arrayRevers[i] = arrayRevers[k - 1 - i];
//         arrayRevers[k - 1 -i] = temp;
//     }

//     return arrayRevers;
// }
//  int minV = -9;
//  int maxV = 9;

//  int [] created = CreatArray(minV, maxV);
//  PrintArray(created);
//  int [] revers = ReversArray(created);
//  PrintArray(revers);



// //Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// //45 -> 101101
// //3  -> 11

// int CountOfBinar (int user_nam){
//     int countOfDigit;
//     while (user_nam !=0){
//         user_nam = user_nam /2;
//         countOfDigit++;
//     }
//     return countOfDigit;
// }

// int [] ConversionToBinar (int numToConvert){
//     int n = CountOfBinar(numToConvert);
//     int [] binarNum = new int [n];

//     for(int i = n - 1; i >= 0; i--)
//     {
//         binarNum[i] = numToConvert % 2;
//         numToConvert /=2;
//     }
//     return binarNum;
// }

// int user_Number = 45;
// int counEl = CountOfBinar(user_Number);
// int [] binar = ConversionToBinar(user_Number);
// PrintArray(binar);



// Код предыдущей задачи, чтоб сохранился //Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// //45 -> 101101
// //3  -> 11

// int CountOfBinar (int user_num)
// {
//     int countOfDigits = 0;
//     while (user_num != 0)
//     {
//         user_num = user_num / 2;
//         countOfDigits++;
//     }
//     return countOfDigits;
// }

// int [] ConversionToBinar (int numToConvert)
// {
//     int n = CountOfBinar(numToConvert);
//     int [] binarNum = new int [n];

//     for (int i = n - 1; i >= 0; i--)
//     {
//         binarNum[i] = numToConvert % 2;
//         numToConvert /= 2;
//     }
//     return binarNum;
// }

// void ShowArray (int [] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.Length; i++)
//     {
//         Console.Write(arrayToShow[i]);
//         if (i != arrayToShow.Length - 1) Console.Write(", ");
//         else Console.WriteLine(".");
//     }
// Console.WriteLine();
// }

// int userNumber = 75;
// int countOfElem = CountOfBinar(userNumber);
// int [] binar = ConversionToBinar(userNumber);
// ShowArray(binar);





//Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//Первые два числа Фибоначчи: a и b (пользователь).

// void Fibonachy (int n, int a, int b){

//     int [] arrFib = new int [n];
//     arrFib[0] = a;
//     arrFib[1] = b;
//     for (int i = 2; i <n; i++){

//         arrFib[i] = arrFib[i-1] + arrFib[i-2];
//     }

// PrintArray(arrFib);

// }
// if()


// void Fibonacci (int n, int a, int b)
// {
//     int [] arrFibonacci = new int [n];
//     arrFibonacci[0] = a;
//     arrFibonacci[1] = b;
//     for (int i = 2; i < n; i++)
//     {
//         arrFibonacci[i] = arrFibonacci[i-2] + arrFibonacci[i-1];
//     }
//     ShowArray(arrFibonacci);
// }

// void ShowArray (int [] arrayToShow)
// {
//     for (int i = 0; i < arrayToShow.Length; i++)
//     {
//         Console.Write(arrayToShow[i]);
//         if (i != arrayToShow.Length - 1) Console.Write(", ");
//         else Console.WriteLine(".");
//     }
// Console.WriteLine();
// }

// Console.WriteLine("Enter count of elements: ");
// int userCount = Convert.ToInt32(Console.ReadLine());

// if (userCount > 2)
// {
//     Console.WriteLine("Enter first element: ");
//     int userFirstNum = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Enter second element: ");
//     int userSecondNum = Convert.ToInt32(Console.ReadLine());

//     Fibonacci(userCount, userFirstNum, userSecondNum);
// }
// else
// {
//     Console.WriteLine("Impossible value!");
// }




//Напишите программу, которая принимает на вход три числа и проверяет, 
//может ли существовать треугольник с сторонами такой длины.
// каждая сторона треугольника меньше суммы двух других сторон.

// a < b+c
// b < a+c
// c < a+b

// void Triangle(int firstSide, int secondSide, int thirdSide)
// {
//     int [] sides = {firstSide, secondSide, thirdSide};
//     if (sides[0] < sides[1] + sides[2] && sides[1] < sides[0] + sides[2] && sides[2] < sides[1] + sides[0])
//     {
//         Console.WriteLine($"Triangle {sides[0]}, {sides[1]}, {sides[2]} exists!");
//     }
//     else
//     {
//         Console.WriteLine($"Triangle {sides[0]}, {sides[1]}, {sides[2]} does NOT exist!");
//     }
// }

// Triangle(3,4,5);








// Вычислите сумму членов последовательности, начинающейся с единицы, 
// в которой каждый следующий член в три раза больше предыдущего,
// т.е. {1, 3, 9, 27, 81,…}, причем последний член последовательности не должен превышать 1000.










// Сформируйте массив целых чисел по алгоритму Фибоначчи: 
// 1-й и 2-й элемент равны 1, а каждый последующий равен сумме двух предыдущих, 
// т.е.: 1, 1, 2, 3, 5, 8, … . Найдите сумму и произведение его N членов.

// Задан массив целых чисел A[20]. Создать другой массив целых чисел B[ ], 
// в который войдут все числа исходного массива, 
// удовлетворяющие условию: А[i] <= 888, после чего отсортировать элементы массива В[ ] по убыванию


// Задано три треугольника со своими сторонами (a, b, c). 
// Найти треугольник с наибольшим периметром или наибольшей площадью. 
// Всегда ли это будет один и тот же треугольник?