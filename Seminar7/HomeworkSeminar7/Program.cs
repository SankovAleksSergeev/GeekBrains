// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


int Imput (string message)
{
    Console.WriteLine(message);
    string peremen1 = Console.ReadLine();
    int peremen2 = Convert.ToInt32(peremen1);
    return peremen2;
}

// double [,] RandomPrintArrayDouble (int rows, int columns, int min, int max)
// {
//     double [,] array = new double [rows, columns];
//     Random x = new Random();
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = Convert.ToDouble(x.Next(min*10, (max*10)+1)/10.00);
//             Console.Write($"{array[i,j]}   ");
//         }
//         Console.WriteLine();  
//     }
//     return array;
// }


// int Rows = Imput("Введите количество строк ");
// int Columns = Imput("Введите количество столбцов ");
// int Min = Imput ("Введите начальние min значение диапазона массива ");
// int Max = Imput ("Введите max значение диапазона массива ");
// Console.WriteLine();
// RandomPrintArrayDouble(Rows, Columns, Min, Max);


//-----------------------------------------------------------------------------------

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Создайте рандомный двумерный массив. Для этого ");
int Rows = Imput("введите количество строк ");
int Columns = Imput("Введите количество столбцов ");
int [,] array = new int [Rows, Columns];

int [,] RandomPrintArray (int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(min, (max+1));
            Console.Write($"{array[i,j]}   ");
        }
        Console.WriteLine();  
    }
    return array;
}

void ElementPosition (int rows, int colomns)
{
    if ((rows>array.GetLength(0)) || (colomns>array.GetLength(1)) || (rows<0)|| (colomns<0))
        {
            Console.WriteLine ($"Такого элемента нет");
        }
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if ((i==rows-1)&&(j==colomns-1))
                {
                    Console.WriteLine ($"Значение запрашиваемого элемента > {array[i,j]}");
                }
            }
        } 
    }
}


int Min = Imput ("Введите начальние min значение диапазона массива ");
int Max = Imput ("Введите max значение диапазона массива ");
Console.WriteLine();
Console.WriteLine("Полученный массив:");
Console.WriteLine();
RandomPrintArray(Min, Max);
Console.WriteLine();
Console.Write("Для того чтобы вывести значение конкретного элемента массива ");
int PositionRows= Imput("введите номер строки. ");
int PositionColumns = Imput("Введите номер столбца ");
ElementPosition(PositionRows,PositionColumns);


//----------------------------------------------------------------------------------

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Write("Создайте рандомный двумерный массив. Для этого ");
// int Rows = Imput("введите количество строк ");
// int Columns = Imput("Введите количество столбцов ");
// int [,] array = new int [Rows, Columns];

// int [,] RandomPrintArray (int min, int max)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(min, (max+1));
//             Console.Write($"{array[i,j]}   ");
//         }
//         Console.WriteLine();  
//     }
//     return array;
// }

// void Average (int rows)
// {
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         double sum = 0;
//         for (int j = 0; j < array.GetLength(0); j++)
//         {
//             sum = sum + array[j,i];
//         }
//         Console.WriteLine($"Среднее арифметическое {i+1} столбец = {sum/rows}");
//     }    
// }

// int Min = Imput ("Введите начальние min значение диапазона массива ");
// int Max = Imput ("Введите max значение диапазона массива ");
// Console.WriteLine();
// Console.WriteLine("Полученный массив:");
// Console.WriteLine();
// RandomPrintArray(Min, Max);
// Console.WriteLine();
// Average(Rows);