
//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да



/*
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
Console.WriteLine("Введите пятизначное число: ");
int uzer_number = Convert.ToInt32(Console.ReadLine());
getNumberFive (uzer_number);

*/

//Задача 21
//Напишите программу, которая принимает на вход координаты 
//двух точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double getLongLineAB (int xA, int xB, int yA, int yB, int zA, int zB){

    double longLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA) + (zB - zA)*(zB - zA));
   
    return longLine;
}

Console.WriteLine("Input number X coord of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number Y coord of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number Z coord of A: ");
int zCoordA = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Input number X coord of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number Y coord of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number Z coord of B: ");
int zCoordB = Convert.ToInt32(Console.ReadLine());



double dist = getLongLineAB (xCoordA, xCoordB, yCoordA, yCoordB, zCoordA, zCoordB);
Console.WriteLine($"Distance between A and B is {dist:f2}");

*/
//Задача 23
//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void getCube (int numberN){

if (numberN > 0){
    int current = 1;
    while (current <= numberN){

     double res = Math.Pow(current, 3);
      Console.Write($"{res:f0}, ");
     current++;
    }
}
else {

Console.Write("1, 0, ");

int current = -1;
    while (current >= numberN){

     double res = Math.Pow(current, 3);
      Console.Write($"{res:f0}, ");
     current--;
    }

}

Console.WriteLine("\b\b.");
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

getCube (number);