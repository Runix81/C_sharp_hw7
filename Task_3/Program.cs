// Задача 3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

//Метод ввода количества строк и столбцов

(int row, int col) InputSizeArray(string numrow, string numcol)
{
    System.Console.Write($"{numrow} -> ");
    int row = Convert.ToInt32(Console.ReadLine());
    System.Console.Write($"{numcol} -> ");
    int col = Convert.ToInt32(Console.ReadLine());
    return (row, col);
}

// Метод создания двухмерного массива

int[,] AddArray(int row, int col)
{
    int[,] array = new int[row, col];
    return array;
}

// Метод заполнения массива

int[,] FillArray(int[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

// Метод вывода массива в консоль

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}    | ");
        }
        System.Console.WriteLine();
    }
}


// Метод подсчета средне арифметического значения каждого столбца и вывод их на экран

void PrintAverageArithmetic(int[,] array, int row, int col)
{
    double sum = 0;
    double res = 0;
    for (int j = 0; j < col; j++)
    {
        for (int i = 0; i < row; i++)
        {
            sum = sum + array[i, j];
        }
        res = sum / row;
        System.Console.Write($"{res:f2} |");
        sum = 0;
        res = 0;
    }
}

(int row, int col) = InputSizeArray("Введите количество строк", "Введите количество столбцов");
int[,] array = AddArray(row, col);
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
PrintAverageArithmetic(array, row, col);
