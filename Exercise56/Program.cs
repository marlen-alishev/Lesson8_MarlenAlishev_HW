// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int[] findSum(int[,] arrayToCalc)
{
    int[] sumOfRows={};
    int sum=0; 
    for (int i=0; i<arrayToCalc.GetLength(0); i++)
    {
        for(int j=0; j<arrayToCalc.GetLength(1); j++)
        {
            sum = sum + arrayToCalc[i,j];
        }
        sumOfRows=sumOfRows.Append(sum).ToArray();
        sum=0;
    }
    return sumOfRows;
}

int findMin (int[] sampleArray)
{
    int min=sampleArray[0];
    for (int i=0; i<sampleArray.Length; i++)
    {
        if (min>sampleArray[i])
        {
            min = sampleArray[i];
        }
    }
    return min;
}

Console.Clear();
Console.Write("Please enter the matrix sizes: ");
int[] arraySize = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,] myArray = new int[arraySize[0], arraySize[1]];

int[,] filledArray = FillArray(myArray);
int[] arrayWithSums = findSum(filledArray);

ShowArray(filledArray);
Console.WriteLine();
Console.Write($"The array with all sums: [{string.Join(", ", findSum(filledArray))}]; ");
Console.WriteLine();
Console.WriteLine();
Console.Write("The line with min sum is: " + findMin(arrayWithSums));