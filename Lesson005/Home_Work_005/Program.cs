// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

/*
int [] CreatArray (){

    int size = new Random().Next(10, 41);
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray [i] = new Random().Next(100, 1000);
    }

    return newArray;
}
*/
/*
void PrintArray (int [] arrayToShow){

     Console.WriteLine ("Ваш массив: ");

    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write (arrayToShow[i] + " ");
    }
   
}
*/
/*
void EvenNumber (int [] arrayCreat){

    int count = 0;
    for (int i = 0; i < arrayCreat.Length; i++){
        if (arrayCreat[i] % 2 == 0){
            count++;
        }
    }

    Console.Write($"-> {count}");
}

int [] Array = CreatArray();
PrintArray(Array);
EvenNumber(Array);
*/

// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] CreateArray(){

    int size = new Random().Next(5, 8);
    int [] CreateNewArray = new int [size];

    for (int i = 0; i < CreateNewArray.Length; i++){
        CreateNewArray[i] = new Random().Next(-5, 10);
    }
    return CreateNewArray;
}

void ShowArray (int [] arrayToShow){

     Console.WriteLine ("Ваш массив: ");

    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write (arrayToShow[i] + " ");
    }
   
}

void UnevenPosSumm (int [] arrayCreate){

    int summ = 0;
    for (int i = 0; i < arrayCreate.Length; i++){

        if (i % 2 > 0){
            summ += arrayCreate[i];
        }
    }
    Console.Write($"-> {summ}");
}

int [] Array = CreateArray();
ShowArray (Array);
UnevenPosSumm (Array);


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76



