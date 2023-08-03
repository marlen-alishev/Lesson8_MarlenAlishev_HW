// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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
            sampleArray[i, j] = new Random().Next(1,100);
        }
    }
    return sampleArray;
}

int[,] findMaxAndChangeArray (int[,] sampleArray) 
{
    for (int i=0; i<sampleArray.GetLength(0); i++)
    {
        for (int j=0; j<sampleArray.GetLength(1); j++) 
        {
            for (int k=j+1; k<sampleArray.GetLength(1); k++)
            {
                int temp;
                if (sampleArray[i,j] < sampleArray[i,k])
                {
                    temp = sampleArray[i,j];
                    sampleArray[i,j] = sampleArray[i,k]; 
                    sampleArray[i,k] = temp; 
                }
            }
        }
    }
    return sampleArray;
}


Console.Clear();
Console.Write("Please enter the matrix sizes: ");
int[] arraySize = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] myArray = new int[arraySize[0], arraySize[1]];

int[,] filledArray = FillArray(myArray);
ShowArray(filledArray);
Console.WriteLine();
findMaxAndChangeArray(filledArray);
ShowArray(filledArray);