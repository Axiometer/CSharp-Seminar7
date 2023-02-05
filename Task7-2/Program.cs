// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет

// Вывод массива в консоль
void WriteArrayToConsole(double[,] doubleArray)
{
    for (int i = 0; i < doubleArray.GetLength(0); i++)
    {
        for (int j = 0; j < doubleArray.GetLength(1); j++)
        {
            Console.Write($"{doubleArray[i, j]}\t");
        }
        Console.WriteLine();
    }
}

// Заполнение массива
double[,] GetRandomArray(int m, int n, int minValue=-10, int maxValue=10)
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2); 
         }
    }
    return result;
}

// Ввод числа пользователем
int GetNumberFromUser(string message)
{
    while(true)     
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect)       
            return userNumber;
        Console.WriteLine("Ошибка ввода!");
    }
}

// Вывод результата
void PrintResult(double[,] array, int A, int B)
{
    if (A<array.GetLength(0) && B<array.GetLength(1)) 
    {
        double result = array[A, B];
        Console.WriteLine($"В {A+1} строке {B+1} столбце расположено число {result}.");
    }
    else Console.WriteLine("Такого элемента нет.");
}

int rows= 3;
int columns = 4;
double[,] array = GetRandomArray(rows, columns);

WriteArrayToConsole(array);
int row = GetNumberFromUser("Введите номер строки нужного элемента: ") - 1;
int col = GetNumberFromUser("Введите номер столбца нужного элемента: ") - 1;

Console.WriteLine();
PrintResult(array, row, col);