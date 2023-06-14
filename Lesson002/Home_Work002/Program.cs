//Задача 10: Напишите программу, которая 
//принимает на вход трёхзначное число и на выходе 
//показывает вторую цифру этого числа.
//456 -> 5
//782 -> 8
//918 -> 1

/*
Console.WriteLine ("Введите трехзначное чиcло");
int num = Convert.ToInt32(Console.ReadLine());

void getNumberTwo(int x){
if (x > 99 && x < 1000){
    int a = x / 10;
    int b = a % 10;
    Console.WriteLine($"Второй цифрой числа {x} является {b}");
}
else{
    Console.WriteLine ("Пожалуйста, введите ТРЕХЗНАЧНОЕ число");
}
}
getNumberTwo(num);
*/

//Задача 13: Напишите программу, которая 
//выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

/*
int num = new Random().Next(1, 99999);
Console.WriteLine(num);

void getNumberThree (int x){

    if (x < 100){
        Console.WriteLine($"Число {x} не имеет третьей цифры");
    }

    else {
        int count = x;
        while (count >= 1000){
            count = count / 10;

        }
        count = count % 10;
        Console.WriteLine($"Третья цифра числа {x} - это {count}");
    }
}
getNumberThree(num);
*/

//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

//Вариант_15.1
/*
bool getWeek(){
    Console.WriteLine("Введите число от 1 до 7 включительно");
    int num = Convert.ToInt32(Console.ReadLine());


    if (num == 6 || num == 7){

        return true;
    }
    else{

        return false;
    }
}
Console.WriteLine("Result is - " + getWeek());
*/

//Вариант_15.2

Console.WriteLine("Введите число от 1 до 7 включительно");
int num = Convert.ToInt32(Console.ReadLine());

void getWeek(int x){
    if (x <= 7 && x >= 1){

    
        if (x == 6 || x == 7){

            Console.WriteLine("Да, это выходной");
        }
        else{

            Console.WriteLine("Нет, это не выходной");
        }
    }
    else{
        Console.WriteLine("Ошибка! Пожалуйста, введите число от 1 до 7 включительно");
    }
}
getWeek(num);

