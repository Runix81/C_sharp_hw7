// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет

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

double[,] AddArray(int row, int col)
{
    double[,] array = new double[row, col];
    return array;
}

//Метод заполнения массива

double[,] FillArray(double[,] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.NextDouble() * rnd.Next(-10, 11);
        }
    }
    return array;
}

// Метод вывода массива в консоль

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:f2} | ");
        }
        System.Console.WriteLine();
    }
}

//Метод ввода адресса в двухмерном массиве

(int i, int j) EnterAddress()
{
    System.Console.Write("Введите номер строки -> ");
    int i = Convert.ToInt32(Console.ReadLine())-1;
    System.Console.WriteLine();
    System.Console.Write("Введите номер столбца -> ");
    int j = Convert.ToInt32(Console.ReadLine())-1;
    System.Console.WriteLine();
    return (i, j);
}

// Метод проверки наличия значения по адрессу в двухмерном массиве.

void AddressExamination(double[,] array, int i, int j, int row, int col)
{
    if (i+1 <= row && j+1 <= col)
    {
        System.Console.Write($"По этому адресу в массиве находится значение {array[i, j]:f2}");
    }
    else
    {
        System.Console.WriteLine("Такого адреса в массиве нет.");
    }
}

(int row, int col) = InputSizeArray("Введите количество строк", "Введите количество столбцов");
double[,] array = AddArray(row, col);
FillArray(array);
PrintArray(array);
System.Console.WriteLine();
(int i, int j) = EnterAddress();
AddressExamination(array, i, j, row, col);