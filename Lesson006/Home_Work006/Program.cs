// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



 int Message (string message){

    Console.WriteLine(message);
    int num_uz = Convert.ToInt32(Console.ReadLine());
    return num_uz;
 }

 int [] InputArray (int size){

    int [] array = new int [size];
    for ( int i = 0; i < size; i++){
        array [i] = Message($"Введите {i+1}-й элемент");
    }
    return array;
 }

 void PrintArray (int [] array){

    Console.WriteLine ("Ваши числа: ");

    for(int i = 0; i < array.Length; i++)
    Console.Write($" {array[i]}, ");
    
 }

int CountPositiveNum (int[] userArray){
    int count = 0;
    for(int i = 0; i < userArray.Length; i++){

        if (userArray[i] > 0){
            count++;
        }
    }
    return count;
}

int size = Message("Введите количество чисел");
int [] newArray = InputArray(size);
PrintArray(newArray);
Console.WriteLine($"Количество чисел больше 0 составило: {CountPositiveNum(newArray)}");


// Дан двумерный массив. Вывести на экран:
// а) все элементы пятой строки массива;
// б) все элементы s-го столбца массива.

//Дан двумерный массив. Найти:
//а) сумму элементов, расположенных в левом верхнем и правом нижнем углах;
//б) среднее арифметическое элементов, расположенных в четырех углах.