﻿// int [] arr = {1,5,4,2,6,7,1,2};
// void PrintArray (int []array)
// {
//     int index = array.Length;
//     for (index = 0; index<array.Length; index++)
//     {
//         Console.Write($"{array[index]} ");
//     }
//     Console.WriteLine();
// }


// void Arr (int[] arrya)
// {
//     for (int count = 0; count<arrya.Length-1; count++)
//     {
//         int MinBol = count;
//         for (int j = count +1 ; j<arrya.Length; j++)
//         {
//             if ( arrya[j] < arrya[MinBol]) MinBol=j;
//         }
//     int swop = arrya[count];
//     arrya[count] = arrya[MinBol];
//     arrya[MinBol] = swop;
//     }
// }

// PrintArray(arr);
// Arr(arr);
// PrintArray(arr);


//------------------------------------------------------------------------------------------


// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Print (string number)
// {
//     Console.WriteLine(number); 
//     string peremen = Console.ReadLine();
//     int peremen2 =Convert.ToInt32(peremen);
//     return peremen2;

// }
// double NaturalDegree (int number, int degree)
// {
// if ((degree>0)&&(number>0))
// {
//     int peremen = 1;
//     for (int count = 0; count<degree; count++) 
//     {
//         peremen = peremen*number;
//     }
//     return peremen;
// }

// else if ((degree<0)&&(number<0))
// {
//     double peremen1 = 1;
//     for (int count = 0; count>degree; count--) 
//     {
//         peremen1 = peremen1*number;
//     }
//             double d = 1/peremen1;
//             return d;
//     }
// else if ((degree<0)&&(number>0))
//     {
//     double peremen2 = 1;
//     for (int count = 0; count>degree; count--) 
//     {
//         peremen2 = peremen2*number;
//     }
//     double d = 1/peremen2;
//     return d;
//     }
// else 
// {
//     int peremen4 = 1;
//     for (int count = 0; count<degree; count++) 
//     {
//         peremen4 = peremen4*number;
//     }
//         return peremen4;
    
// }
// }

// int x1 = Print ("Введите число");
// int x2 = Print ("Введите степень");
// double X = NaturalDegree(x1,x2);
// Console.WriteLine($"степень числа = {X}");



//------------------------------------------------------------------------------------------



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int Print (string number)
// {
//     Console.WriteLine(number); 
//     string peremen = Console.ReadLine();
//     int peremen2 =Convert.ToInt32(peremen);
//     return peremen2;
// }
// int n = Print ("Введите число");
// if (n>=0)
// {
//     int x = 0;
//     while(n > 0)
//     {
//         int q = (n % 10);
//         n = (n / 10);
//         x = x + q;
//     }
//     Console.WriteLine($"Сумма цифр числа = {x}");
// }
// else
// {
//     n = n * (-1);
//     int x = 0;
//     while(n > 0)
//     {
//         int q = (n % 10);
//         n = (n / 10);
//         x = x + q;
//     }
//     Console.WriteLine($"Сумма цифр числа = {x}");
// }



//------------------------------------------------------------------------------------------

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int Print (string number)
// {
//     Console.WriteLine(number); 
//     string peremen = Console.ReadLine();
//     int peremen2 =Convert.ToInt32(peremen);
//     return peremen2;
// }

// void PrintMassiv (int [] peremen)
// {
//     int Dlina = peremen.Length;
//     for (int i = 0; i<Dlina; i++)
//     {
//         peremen[i]= new Random().Next(-1000,1000);
//         Console.Write($"{peremen[i]}  ");
//     }
// }

// int x = Print ("Введите длинну массива");
// int [] array = new int [x];
// PrintMassiv(array);

//------------------------------------------------------------------------------------------

// Дан текст. В тексте нужно заменить все пробелы черточками,
// маленькие буквы "к" заменить большими "К", а большие "С"
// заменить маленькими "с"


// string Text = "Главное противоречие между Францией и "
// + "Китаем кроется в том, что на африканском континенте Китай " 
// +"выступает как гораздо более инициативный экономический игрок. "
// +"КНР давно стала первым экономическим партером Западной Африки, "
// +"где находится большинство бывших колоний Франции, которые та " 
// +"привыкла считать своей исторической сферой влияния.";

// string RebytText (string text, char peremen1, char peremen2)
// {
//     string result = String.Empty;
//     int Dlina = Text.Length;
//     for (int i = 0; i < Dlina; i++ )
//     {
//         if (text[i]==peremen1)
//         {
//             result = result + $"{peremen2}";
//         }
//         else
//         {
//             result = result +$"{text[i]}";
//         }
//     }return result;

// }

// string newText = RebytText(Text, 'к','*');
// Console.WriteLine(newText);
// Console.WriteLine();


//------------------------------------------------------------------------------------------


// int Prompt (string message)
// {
//     System.Console.Write(message);
//     string peremen = System.Console.ReadLine();
//     int result = int.Parse(peremen);
//     return result;
// }
// int [] GenerateArray (int Length, int  min , int max)
// {
//     int [] array =new int [Length];
//     // Random random = new Random();
//     for (int i=0; i<Length; i++)
//     {
//         array[i] = new Random().Next(min , max+1);
//     }
//     return array;
// }

// void PrinrArray (int [] array)
// {
//     System.Console.Write("[");
//     for (int i =0; i<array.Length-1; i++)
//     {
//         System.Console.Write($"{array[i]}, ");
//     }
//     System.Console.Write($"{array[array.Length-1]}");
//     System.Console.Write("]");
// }

// int Length = Prompt ("Введите длину массива ");
// int min  = Prompt ("Введите начальное значение, для диапазона случайного чисел ");
// int max = Prompt("Введите конечное значение, для диапазона случайного чисел ");
// int [] array = GenerateArray(Length, min, max);
// PrinrArray(array);
    



//------------------------------------------------------------------------------------------

// string Text (string text )
// {
//     Console.Write(text);
//     string peremen = Console.ReadLine();
//     return peremen;

// }

// string newText (string text, char x1 , char x2 )
// {
//     string result = String.Empty;
//     int Dlina = text.Length;
//     for (int i=0; i<Dlina; i++)
//     {
//         if (text[i]==x1)
//         {
//             result = result +$"{x2}";
//         }
//         else
//         {
//             result = result +$"{text[i]}";
//         }
        
//     }
//     return result;
// }

// string x = Text ("Введите текст ");
// Console.WriteLine();
// string x2 = newText(x,' ', '+');
// Console.WriteLine(x2);


//------------------------------------------------------------------------------------------


