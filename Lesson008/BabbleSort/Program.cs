// Решение задачи на сортировку массива полностью


int [,] ArrangeArray (int [,] arrayRandom)
{
    int n = arrayRandom.GetLength(0); //строки
    int m = arrayRandom.GetLength(1); //столбцы
    //int [,] arrayCorrect = new int[n,m];
    int max = arrayRandom[0,0];

        
            for (int i = 0; i < n; i++)
                    for(int j = 0; j < m; j++)
                        for (int x = 0; x < n ; x++)
                            for (int y = 0; y < m ; y++)

                            if (arrayRandom[x,y] > arrayRandom[i,j])
                            {
                                max = arrayRandom[x,y];
                                arrayRandom[x,y] = arrayRandom[i,j];
                                arrayRandom[i,j] = max;
                            }          
return arrayRandom;
}  

// int [,] arr = CreateArray2D();
// Print(arr);
// Print(ArrangeArray(arr));
