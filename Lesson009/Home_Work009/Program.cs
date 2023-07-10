// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



int ShowNumbersFromNtoOne (int number)
{
    if (number < 1) return 0;
    Console.Write($"{number}  ");
    number--;
    return ShowNumbersFromNtoOne(number);

}
// ShowNumbersFromNtoOne(9);


// Задача 66: Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int SumElementsFromMtoN (int m, int n)
{
    int sum = 0;
    if (m < 0) m *= -1;
    if (n < 0) n *= -1;
    int Min = Math.Min(n,m);
    int Max = Math.Max(n,m);
    
    if (n != m) sum = Min + SumElementsFromMtoN(Min+1,Max);
    if (n == m) return m; 
    return sum;
    
}

// Console.WriteLine("Пожалуйста, введите первое число:");
// int mUser = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Пожалуйста, введите второе число:");
// int nUser = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Сумма элементов в промежутке между числами {mUser} и {nUser} составила: {SumElementsFromMtoN(mUser, nUser)}.");



// Задача 68*: Напишите программу вычисления функции Аккермана 
//с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int m, int n)
{
    if (m == 0){
        return n + 1;
    }
    else if((m > 0) && (n == 0)){
        return Akkerman(m - 1, 1);
    }
    else if((m > 0) && (n > 0)){
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
    return Akkerman(m,n);
}
Console.WriteLine(Akkerman(3,3));