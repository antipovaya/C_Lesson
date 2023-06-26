// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int [] CreatArray (){

    int size = new Random().Next(10, 41);
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray [i] = new Random().Next(100, 1000);
    }

    return newArray;
}

void PrintArray (int [] arrayToShow){

     Console.WriteLine ("Ваш массив: ");

    for (int i = 0; i < arrayToShow.Length; i++)
    {
        Console.Write (arrayToShow[i] + " ");
    }
   
}

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
