﻿//Задача 10: Напишите программу, которая 
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
