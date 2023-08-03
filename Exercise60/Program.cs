// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void ShowArray(int[,,] arrayToShow)
{
    for (int i=0; i<arrayToShow.GetLength(0); i++)
    {
        for(int j=0; j<arrayToShow.GetLength(1); j++)
        {
            for(int k=0; k<arrayToShow.GetLength(2); k++)
            {
                Console.Write($"{string.Join(", ", arrayToShow[i,j,k])} {(i,j,k)} ");    
            }
            Console.WriteLine();
        }
    }
}

int[,,] CheckAndCreateArray(int[,,] sampleArray)
{
    int [] tempArray = new int[sampleArray.GetLength(0)*sampleArray.GetLength(1)*sampleArray.GetLength(2)];
    int newArrayIndex = 0;
    
    for (int i=0; i<tempArray.GetLength(0); i++)
    {
        tempArray[i] = new Random().Next(10,100);
        if (i>=1)
        {
            for (int j=0; j<i; j++)
            {
                while (tempArray[i] == tempArray[j])
                {
                    tempArray[i] = new Random().Next(10,100);
                    j=0;
                }
            }
        }
    }
 
    for (int i=0; i<sampleArray.GetLength(0); i++)
    {
        for(int j=0; j<sampleArray.GetLength(1); j++)
        {
            for(int k=0; k<sampleArray.GetLength(2); k++)
            {
                sampleArray[i,j,k] = tempArray[newArrayIndex];
                newArrayIndex++;
            }
        }
    }
    return sampleArray;
}

Console.Clear();
Console.Write("Please enter the matrix sizes: ");
int[] arraySize = Console.ReadLine().Split(" ").Select(x=>int.Parse(x)).ToArray();
int[,,] myArray = new int[arraySize[0], arraySize[1], arraySize[2]];

int[,,] filledArray = CheckAndCreateArray(myArray);
ShowArray(filledArray);