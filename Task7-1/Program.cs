// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами

// Ввод числа пользователем
int GetNumberFromUser(string message)  //метод ввода числа
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

// Вывод массива в консоль
void WriteArrayToConsole(double[,] doubleArray)  //Метод вывода массива
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
double[,] GetArray(int m, int n, int minValue, int maxValue)    //Метод заполнения массива случайными вещественными числами
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

int rows = GetNumberFromUser("Введите количество строк: ");
int columns = GetNumberFromUser("Введите количество столбцов: ");

double[,] array = GetArray(rows, columns, -10, 10);
WriteArrayToConsole(array);


