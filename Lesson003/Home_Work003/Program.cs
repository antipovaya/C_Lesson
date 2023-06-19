//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int uzer_number = Convert.ToInt32(Console.ReadLine());

void getNumberFive(int x){

if (x > 99999 || x < 10000){
    Console.WriteLine ("Пожалуйста, введите ПЯТИЗНАЧНОЕ число");
}
else {

    int a1 = x / 10000;
    int a2 = x / 1000 - a1 * 10;
    int a5 = x % 10;
    int a4 = (x % 100 - a5) / 10;

    Console.WriteLine (a1);
    Console.WriteLine (a2);
    Console.WriteLine (a4);
    Console.WriteLine (a5);

    if ( a1 == a5 && a2 == a4 ){
        Console.WriteLine ($"Ваше число {x} является палиндромом");
    }
    else {
        Console.WriteLine ($"Ваше число {x} не является палиндромом");
    }
}
}
getNumberFive (uzer_number);


//Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53