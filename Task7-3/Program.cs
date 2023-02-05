// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            result[i, j] = new Random().Next(minValue, maxValue); 
    return result;
}

// Вывод массива в консоль
void WriteArrayToConsole(int[,] intArray)
{
    for (int i = 0; i < intArray.GetLength(0); i++)
    {
        for (int j = 0; j < intArray.GetLength(1); j++)
        {
            Console.Write($"{intArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[] GetAverageInColumns(int[,] array)
{
    double[] averageArray = new double[array.GetLength(1)];

    for (int column = 0; column < averageArray.Length; column++)
    {
        for (int row = 0; row < array.GetLength(0); row++)
        {
            averageArray[column] += array[row, column];
        }
        averageArray[column] = Math.Round(averageArray[column] / array.GetLength(0), 1);
    }
    return averageArray;
}

int rows= 3;
int columns = 4;
int[,] array = GetArray(rows, columns, -10, 10);

WriteArrayToConsole(array);

double[] average = GetAverageInColumns(array);
Console.WriteLine($"Среднее арифметическое каждого столбца:\n {String.Join("\t", average)}");