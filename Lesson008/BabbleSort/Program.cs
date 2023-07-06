// Решение задачи на сортировку массива полностью

int [,] CreateArray2D (){

    int m = new Random().Next(3, 5);
    int n = new Random().Next(3, 5);

    int [,] creatArr = new int [m, n];
    for (int i = 0; i < m; i++){
        for(int j = 0; j < n; j++)
        {
            creatArr[i,j] = new Random().Next(0, 10);
        }
    }
    return creatArr;
 }

void Print (int [,] array2D){
    Console.WriteLine("Ваш массив: ");
    Console.WriteLine();

    for(int i = 0; i < array2D.GetLength(0); i++){
        for(int j = 0; j < array2D.GetLength(1); j++){
            
            Console.Write(array2D[i,j] + " ");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}



// int [,] ArrangeArray (int [,] arrayRandom)
// {
//     int n = arrayRandom.GetLength(0); //строки
//     int m = arrayRandom.GetLength(1); //столбцы
//     //int [,] arrayCorrect = new int[n,m];
//     int max = arrayRandom[0,0];

        
//             for (int i = 0; i < n; i++)
//                     for(int j = 0; j < m; j++)
//                         for (int x = 0; x < n ; x++)
//                             for (int y = 0; y < m ; y++)

//                             if (arrayRandom[x,y] > arrayRandom[i,j])
//                             {
//                                 max = arrayRandom[x,y];
//                                 arrayRandom[x,y] = arrayRandom[i,j];
//                                 arrayRandom[i,j] = max;
//                             }          
// return arrayRandom;
// }  

// int [,] arr = CreateArray2D();
// Print(arr);
// Print(ArrangeArray(arr));


int [,] ArrangeArray (int [,] arrayRandom)
{
    int n = arrayRandom.GetLength(0); //строки
    int m = arrayRandom.GetLength(1); //столбцы
    //int [,] arrayCorrect = new int[n,m];
    int max = arrayRandom[0,0];

        
            for (int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                        //for (int x = 0; x < n ; x++)
                            for (int y = 0; y < m ; y++)

                            if (arrayRandom[i,y] > arrayRandom[i,j])
                            {
                                max = arrayRandom[i,y];
                                arrayRandom[i,y] = arrayRandom[i,j];
                                arrayRandom[i,j] = max;
                            }          
return arrayRandom;
}  

int [,] arr = CreateArray2D();
Print(arr);
Print(ArrangeArray(arr));