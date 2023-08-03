// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20 -- 2*3+4*3 2*4+4*3
// 15 18 -- 3*3+2*3 3*4+2*3 

void ShowArray(int[,] arrayToShow)
{
    for (int i=0; i<arrayToShow.GetLength(0); i++)
    {
        for(int j=0; j<arrayToShow.GetLength(1); j++)
        {
            Console.Write($"{string.Join(",", arrayToShow[i,j])}; ");
        }
        Console.WriteLine();
    }
}

int[,] FillArray(int[,] sampleArray)
{
    for (int i=0; i<sampleArray.GetLength(0); i++)
    {
        for(int j=0; j<sampleArray.GetLength(1); j++)
        {
            sampleArray[i, j] = new Random().Next(1,10);
        }
    }
    return sampleArray;
}

int[,] FillArray2(int[,] sampleArray2)
{
    for (int i=0; i<sampleArray2.GetLength(0); i++)
    {
        for(int j=0; j<sampleArray2.GetLength(1); j++)
        {
            sampleArray2[i, j] = new Random().Next(1,10);
        }
    }
    return sampleArray2;
}

//Мое первая попытка решить.
//int[,] functionToCalc (int[,] firstArray, int[,] secondArray)
// {
//     int[,] resultArray = new int[5,5];
//     if (firstArray.GetLength(1) == secondArray.GetLength(0)) 
//     {
//         int sum = 0;
//         for (int i=0; i<firstArray.GetLength(0); i++)
//         {
//             for (int j=0; j<firstArray.GetLength(1); j++)
//             {
//                 sum = sum + firstArray[i,j] * secondArray[j,i];
//                 if (j==firstArray.GetLength(1)-1)
//                 {
//                     //Console.WriteLine(sum+"YEAR!");
//                     resultArray[i,j] = sum;
//                 }
//             }
//             sum=0;
//         }
//     }
//     else 
//     {
//         Console.WriteLine("The number of rows and columns should be equal!");
//     }

//     return resultArray;
// }

//Финальное решение 
int[,] funtionToCreateFinalArray (int[,] firstArray, int[,] secondArray)
{
    int[,] resultArray = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    if (firstArray.GetLength(1) == secondArray.GetLength(0)) 
    {
        for (int i=0; i<firstArray.GetLength(0); i++)
        {
            for (int j=0; j<secondArray.GetLength(1); j++)
                {
                    for (int k=0; k<secondArray.GetLength(0);k++)
                    {
                        resultArray[i,j] += firstArray[i,k]*secondArray[k,j];
                    }
                }
        }
    }
    else 
    {
        Console.WriteLine("Error! Please take a look at requirements!");
    }
    return resultArray;
}

Console.Clear();
Console.Write("Please enter the first matrix sizes: ");
int[] arraySize = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] myArray = new int[arraySize[0], arraySize[1]];
Console.Write("Please enter the second matrix sizes: ");
int[] arraySize2 = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] myArray2 = new int[arraySize2[0], arraySize2[1]];

int[,] filledArray = FillArray(myArray);
int[,] filledArray2 = FillArray2(myArray2);
int[,] finalArray = funtionToCreateFinalArray(filledArray, filledArray2);

ShowArray(filledArray);
Console.WriteLine();
ShowArray(filledArray2);
Console.WriteLine();
ShowArray(finalArray);