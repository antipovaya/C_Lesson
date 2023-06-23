//Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//Найдите сумму отрицательных и положительных элементов массива.

/*
int [] CreateArray (int size, int minVal, int maxVal){

    int [] newArray = new int [size];
    for (int i =0; i < size; i++)
    {
        newArray [i] = new Random().Next(minVal, maxVal+1);
    }
    return newArray;
}

void ShowArray (int [] arrayToShow){

    for (int i = 0; i < arrayToShow.Length; i++)
        Console.Write (arrayToShow[i] + " ");
    Console.WriteLine(); // Переход на новую строку
}

void FindSumNegElem (int [] array)
{
    int sumNegElem = 0;
    for (int i = 0; i < array.Length; i++)
    if (array[i] < 0)
        sumNegElem += array[i];
    Console.WriteLine($"Sum of negative elements of array is {sumNegElem}");
}

int FindSumPosElem (int [] arrayToAnalyse)
{
    int sumPosElem = 0;
    for (int i = 0; i < arrayToAnalyse.Length; i++)
    if (arrayToAnalyse[i] > 0)
        sumPosElem += arrayToAnalyse[i];
    return sumPosElem;
}

// Теперь сделаем поиск сумм в одном методе:


void FindSummElem (int [] array){

int sumNegElem = 0;
int sumPosElem = 0;

for (int i = 0; i < array.Length; i++){
    if (array[i] < 0)
        sumNegElem += array[i];
    else 
        sumPosElem += array[i];
}
    Console.WriteLine($"Sum of negative elements of array is {sumNegElem}");
    Console.WriteLine($"Sum of positive elements of array is {sumPosElem}");
}


int sizeArray = 12;
int minArrayVal = -9;
int maxArrayVal = 9;

int [] createdArray = CreateArray (sizeArray, minArrayVal, maxArrayVal);

ShowArray (createdArray);
FindSummElem (createdArray);
// Вывод возвратного метода пример:
Console.WriteLine($"Sum of positive elements of array is {FindSumPosElem(createdArray)}");

*/


//Задача 2.
//Напишите программу замены элементов массива: положительные элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

/*

int [] RandomArray ()
{
    int size = new Random().Next(4,10);
    
    int [] randomArray = new int [size];
    for ( int i = 0; i < size; i++){

        randomArray[i] = new Random().Next(-10,11);
    }
    return randomArray;
}

void PrintArray(int [] arrayPrint){

    for (int i = 0; i < arrayPrint.Length; i++){

        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}

int [] InvertArray(int [] invArray){

    for (int i = 0; i < invArray.Length; i++)
        invArray[i] = invArray[i] * (-1); // invArray [i] *= (-1);
    return invArray;
    }

int [] massiv = RandomArray();
PrintArray(massiv);
int [] massivItog = InvertArray(massiv);
PrintArray(massivItog);

*/




// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

int [] RandomArray ()
{
    int size = new Random().Next(4,10);
    
    int [] randomArray = new int [size];
    for ( int i = 0; i < size; i++){

        randomArray[i] = new Random().Next(-10,11);
    }
    return randomArray;
}

void PrintArray(int [] arrayPrint){

    for (int i = 0; i < arrayPrint.Length; i++){

        Console.Write(arrayPrint[i] + " ");
    }
    Console.WriteLine();
}


// делим на 2 размерб те ищем середину исходного массива


int [] startArray = RandomArray();

int size = startArray.Length;


int [] MultyArray(int [] startArray){


    int [] temp = new int [size/2 + 1];
    for (int i = 0; i < size/2; i++)

    {
        temp[i] = startArray[i] * startArray[startArray.Length - 1 - i];
    }
    return temp;

}
PrintArray(startArray);

int [] multy = MultyArray(startArray);
PrintArray(multy);