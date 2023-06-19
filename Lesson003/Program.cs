//Console.WriteLine ("Введите трехзначное чиcло");
//int num = Convert.ToInt32(Console.ReadLine());


//int num = new Random().Next(1, 99999);
//Console.WriteLine(num);

/*void getNumberTwo(int x){
if (x > 99 && x < 1000){
    int a = x / 10;
    int b = a % 10;
    Console.WriteLine($"Второй цифрой числа {x} является {b}");
}
else{
    Console.WriteLine ("Пожалуйста, введите ТРЕХЗНАЧНОЕ число");
}
}
getNumberTwo(num);*/




/*int Line()
{
int num = new Random().Next(10,100);
Console.WriteLine("Your num is " +num);
int dec = num/10;
int ed = num%10;
if(dec>ed){
    return dec;
}
else{
    return ed;
}
}
Console.WriteLine("Result is - " + Line());*/



//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

/*void NameFunk(аргументы нужны не всегда) невозвратный метод, его имя NameFunk
{
тело
}
NameFunk(); - программа пойметб что это обращение к функции
*/
// Возвратный метод: int, bool, double, string FunkNume(int arg1, int arg2....)

/*int FunktName (int arg1, int arg2)
{      // arg1 = number
        //arg2 = 9
        int del = arg1 % arg2;

return del;   
}

Console.WriteLine("Input ");
int number = Convert.ToInt32(Console.ReadLine());

int resul = FunktName(number, 9);
Console.WriteLine("1 " + resul);
int result1 = FunktName(1000, 78);
Console.WriteLine("2 " + result1);
*/
/*
void FunktName1 ()
{      
        Console.WriteLine("Input ");
        int number = Convert.ToInt32(Console.ReadLine());

        int del = number % 9;
        Console.WriteLine("1 " + del);
}
FunktName1();
*/



//Напишите программу, которая принимает на вход координаты точки (X и Y), 
//причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*

int Koord (int x, int y){

    int numberQuater;
   
    if (x > 0 && y > 0)
        numberQuater = 1;
    else if (x > 0 && y < 0)
        numberQuater = 4;
    else if (x < 0 && y > 0)
        numberQuater = 2;
    else 
        numberQuater = 3;

        return numberQuater;
}
Console.WriteLine("Введите координату х: ");
int xCoord = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y: ");
int yCoord = Convert.ToInt32(Console.ReadLine());
int numQuat;

if (xCoord == 0 || yCoord ==0){
    Console.WriteLine("ERROR");
}
else {
    numQuat = Koord (xCoord, yCoord);
    Console.WriteLine ($"Number of quater is {numQuat}");

}
*/
//Напишите программу, которая по заданному номеру четверти, 
//показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void PossibleValue (int quadro)
{
    if (quadro == 1)
        Console.WriteLine ("1st quater x > 0, y > 0");
    else if (quadro == 2)
        Console.WriteLine ("2nd quater x < 0, y > 0");
    else if (quadro == 3)
        Console.WriteLine ("3rd quater x < 0, y < 0");
    else 
        Console.WriteLine ("4st quater x > 0, y < 0");
}

Console.WriteLine("Input number of quater: ")     ;
int numQater = Convert.ToInt32(Console.ReadLine());

if(numQater >= 1 && numQater <= 4)
    PossibleValue(numQater);
else Console.WriteLine("its not number of quater!");
*/

//Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 2D пространстве.
// A(x1,y1); B(x2,y2)

                //------------------------
// duoble distanceAB = \/ (x2-x1)*(x2-x1) + (y2-y1)*(y2-y1) 

// duoble так как извлекаем корень

//Math.Sqrt (25); - извлекаем квадрат с помощью библиотеки Math


/*double LongLineAB (int xA, int xB, int yA, int yB){

    double longLine = Math.Sqrt((xB - xA)*(xB - xA) + (yB - yA)*(yB - yA));
    //longLine = Math.Round (longLine, 2);
    return longLine;
}

Console.WriteLine("Input number X coord of A: ");
int xCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number Y coord of A: ");
int yCoordA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number X coord of B: ");
int xCoordB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input number Y coord of B: ");
int yCoordB = Convert.ToInt32(Console.ReadLine());

double dist = LongLineAB (xCoordA, xCoordB, yCoordA, yCoordB);
Console.WriteLine($"Distance between A and B is {dist:f3}");
*/




//Напишите программу, которая принимает на вход число (N) и 
//выдаёт ряд квадратов чисел от 1 до N.
//5 -> 1, 4, 9, 16, 25.
//2 -> 1,4.

void SqPrint (int numberN){

    int current = 1;
    while (current <= numberN){

     double res = Math.Pow(current, 2);
     Console.Write($"{res:f0}, ");
     current++;
    }
    Console.WriteLine("\b\b.");
}
Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

SqPrint (number);