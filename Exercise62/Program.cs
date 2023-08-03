// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

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

int[,] createArray (int[,] sampleArray)
{
    if (sampleArray.GetLength(0) == sampleArray.GetLength(1))
    {
        int n=1; 
        int i =0; 
        int j=0; 

        while (n <= sampleArray.GetLength(0) * sampleArray.GetLength(1))
            {
                sampleArray[i, j] = n;
                n++;
                if (i <= j + 1 && i + j < sampleArray.GetLength(1) - 1)
                    j++;
                else if (i < j && i + j >= sampleArray.GetLength(0) - 1)
                    i++;
                else if (i >= j && i + j > sampleArray.GetLength(1) - 1)
                    j--;
                else
                    i--;
            }
    }
    else 
    {
        Console.Write("The length of both sites should be equal\n"); 
    }
    return sampleArray;
}

Console.Clear();
Console.Write("Please enter the matrix sizes: ");
int[] arraySize = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] myArray = new int[arraySize[0], arraySize[1]];

int[,] filledArray = createArray(myArray);
ShowArray(filledArray);