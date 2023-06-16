// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Clear();
// string a ="Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.";
// Console.WriteLine(a);
// Console.WriteLine();


// int Imput (string message)
// {
//     Console.Write(message);
//     int peremen = Convert.ToInt32(Console.ReadLine());
//     return peremen;
// }

// int Rows = Imput("Введите количество строк > ");
// int Colomns = Imput("Введите количество столбцов > ");
// int [,] array = new int [Rows, Colomns];

// int [,] RandomMassiv(int max, int min)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(max, min+1);
//         }
//     }
//     return array; 
// }

// void OrderTheArray (int [,] number)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int d = 0; d < array.GetLength(1)-1; d++)
//             {
//                 if (array[i,d] < array[i, d +1])
//                 {
//                     int swap = array[i,d+1];
//                     array[i,d+1] = array[i,d];
//                     array[i,d] = swap;
//                 }
//             }       
//         }
//     }
// }


// void Print (int [,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }


// int Min = Imput ("Введите начальние min значение диапазона массива > ");
// int Max = Imput ("Введите max значение диапазона массива > ");
// Console.WriteLine();
// RandomMassiv(Min, Max);
// Console.WriteLine("Случайный массив:");
// Print(array);
// OrderTheArray(array);
// Console.WriteLine();
// Console.WriteLine("Упорядоченный массив:");
// Print(array);


//----------------------------------------------------------------------------------------------------------------------------------------

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Console.Clear();
// string a ="Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.";
// Console.WriteLine(a);
// Console.WriteLine();

// int Imput (string message)
// {
//     Console.Write(message);
//     int peremen = Convert.ToInt32(Console.ReadLine());
//     return peremen;
// }

// int Rows = Imput("Введите количество строк > ");
// int Colomns = Imput("Введите количество столбцов > ");
// int [,] array = new int [Rows, Colomns];

// int [,] RandomMassiv(int max, int min)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i,j] = new Random().Next(max, min+1);
//         }
//     }
//     return array; 
// }

// void Print (int [,] array)
// {
//     int x = 1;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i,j]}  ");
//         }
//         Console.WriteLine($" | {x} строка");
//         x = x+1; 
//     }
// }

// void MinSumRows (int [,] number)
// {
//     int sumLine1=0;
//     for (int i = 0; i < array.GetLength(1); i++)
//     {
//         sumLine1= sumLine1 + array[0,i];
//     }
//     int index = 1;
//     int sum = 0;
//     for (int i = 1; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
//         }
//         if (sumLine1>sum)
//         {
//             sumLine1=sum;
//             index = i+1;
//         }
//         sum=0;
//     }
//     Console.WriteLine($"Строка с наименьшей суммой элементов > {index} (сумма строки = {sumLine1})");
// }

// int Min = Imput ("Введите начальние min значение диапазона массива > ");
// int Max = Imput ("Введите max значение диапазона массива > ");
// Console.WriteLine();
// RandomMassiv(Min,Max);
// Console.WriteLine("Созданный массив:");
// Print(array);
// Console.WriteLine();
// MinSumRows(array);

//-----------------------------------------------------------------------------------------------------------------------------



// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// Console.Clear();
// string a ="Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц";
// Console.WriteLine(a);
// Console.WriteLine();

// int Imput (string message)
// {
//     Console.WriteLine(message+" ");
//     int peremen = Convert.ToInt32(Console.ReadLine());
//     return peremen;
// }

//                                 //Операция умножения двух матриц выполнима только 
//                                 //в том случае, если число столбцов в первом сомножителе равно числу строк во втором

// int Rows1= Imput($"Введите количество строк и столбцов первой матрицы:");  // строки
// int Colomns1 = Imput("");                                                  // столбцы
// int [,] array1 = new int [Rows1, Colomns1];

// int Rows2 = Imput($"Введите количество столбцов второй матрицы:");  
// int [,] array2 = new int [Colomns1, Rows2]; 
// int Min1 = Imput ("Введите начальние min и max значение диапазона массива матриц:");
// int Max1 = Imput ("");

// int [,] array3 = new int [Rows1, Rows2]; 

// int [,] RandomMassiv(int [,] massiv, int max, int min)
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             massiv[i,j] = new Random().Next(max, min+1);
//         }
//     }
//     return massiv; 
// }

// void Print (int [,] massiv)
// {
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             Console.Write($"{massiv[i,j]}  ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.WriteLine();
// RandomMassiv(array1, Min1,Max1);
// Console.WriteLine("Первая матрица:"); 
// Print(array1);
// Console.WriteLine();
// RandomMassiv(array2, Min1,Max1);
// Console.WriteLine("Вторая матрица:");
// Print(array2);


// void WorkArray (int [,] array1, int [,] array2, int [,] array3 )
// {
//     for (int i = 0; i < array3.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3.GetLength(1); j++)
//         {
//             int sum =0; 
//             for (int x = 0; x < array1.GetLength(1); x++)
//             {
//                 sum = sum+(array1[i,x]*array2[x,j]);  
//             }
//             array3[i,j] = sum; 
//         }
//     }

// }

// Console.WriteLine("");
// Console.WriteLine("Произведение двух матриц:");
// WorkArray(array1, array2, array3);
// Print(array3);


//-----------------------------------------------------------------------------------------------------------------------------

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Console.Clear();
// string a ="Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. "
// +"Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.";
// Console.WriteLine(a);
// Console.WriteLine();
 
// int Imput (string message)
// {
//     Console.Write(message+" ");
//     int peremen = Convert.ToInt32(Console.ReadLine());
//     return peremen;
// }

// int RowsLength = Imput("Введите длинну массива > ");
// int height = Imput("Введите высоту массива > ");
// int width = Imput("Введите ширину массива > ");
// int [,,] array = new int [RowsLength, height, width];

// void PrintArray (int [,,] massiv)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(2); k++)
//             {
//                 Console.Write($"{array[i,j,k]}{(i,j,k)}  ");
//             }
//             Console.WriteLine("");
//         }
//     } 
// }


// int [,,] RandomMassiv(int [,,] massiv, int max, int min)
// {
    
//     for (int i = 0; i < massiv.GetLength(0); i++)
//     {
//         for (int j = 0; j < massiv.GetLength(1); j++)
//         {
//             for (int k = 0; k < massiv.GetLength(2); k++)
//             {
//                 massiv [i,j,k] = new Random().Next(max, min+1);
//             }
//         }
//     }
//     return massiv; 
// }


// int Min = Imput("Введите начальние min и max значение диапазона массива > ");
// int Max = Imput(">");
// Console.WriteLine();
// Console.WriteLine("Полученный массив и его индексы");
// RandomMassiv(array,Min,Max);
// PrintArray(array);


//-----------------------------------------------------------------------------------------------------------------------------


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
string a ="Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.";
Console.WriteLine(a);
Console.WriteLine();

int Imput (string message)
{
    Console.Write(message);
    int peremen = Convert.ToInt32(Console.ReadLine());
    return peremen;
}

int size = Imput("Введите размер квадратного массива > ");
Console.WriteLine();
int [,] array = new int [size , size];


void Print (int [,] massiv)
{
    for (int i = 0; i < massiv.GetLength(0); i++)
    {
        for (int j = 0; j < massiv.GetLength(1); j++)
        {
            if((massiv.GetLength(0)>4)&&(massiv.GetLength(0)<10))
            {
                if ((i==0)&&(j<=massiv.GetLength(1)))
                {
                    Console.Write($"0{massiv[i,j]} ");
                }
                else if((j==massiv.GetLength(1)-1) && (i<10-array.GetLength(0)))
                {
                    Console.Write($"0{massiv[i,j]} ");
                }
                else
                {
                    Console.Write($"{massiv[i,j]} ");
                }
            }

            if( massiv.GetLength(0)==4)
            {
                if ((i==0)&&(j<=massiv.GetLength(1)))
                {
                    Console.Write($"0{massiv[i,j]} ");
                }
                else if((j==massiv.GetLength(1)-1) && (i<array.GetLength(0)))
                {
                    Console.Write($"0{massiv[i,j]} ");
                }
                else if((i==massiv.GetLength(0)-1) && (j>=1))
                {
                    Console.Write($"0{massiv[i,j]} ");
                }
                else
                {
                    Console.Write($"{massiv[i,j]} ");
                }
            }

            if( massiv.GetLength(0)<4)
            {
                Console.Write($"0{massiv[i,j]} "); 
            }

            if( massiv.GetLength(0)>=10)
            {
                Console.Write($"{massiv[i,j]} "); 
            }

        }
        Console.WriteLine();
    } 
}
void RandomMassiv(int [,] massiv)
{
   int variable = 1;
   int i=0;
   int j=0;
   while(variable<= massiv.GetLength(0)* massiv.GetLength(1))
   {
    massiv[i,j]=variable;
    variable++;
    if ((i<=j+1)&&(j+i<massiv.GetLength(1)-1))
    {
        j++;
    }
    else if ((i<j)&&(i+j>=massiv.GetLength(0)-1))
    {
        i++;
    }
    else if ((i>=j)&&(i+j>massiv.GetLength(1)-1))
    {
        j--;
    }
    else
    {
        i--;
    }
   }
}

RandomMassiv(array);
Console.WriteLine("Полученный массив:");
Print(array);
