// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// int Zapros (string message)
// {
//     Console.Write(message);
//     string value = Console.ReadLine();
//     int result = Convert.ToInt32(value);
//     return result;    
// }

// bool Rabota (int number)
// {
//     if (number<100)
//     {
//         Console.WriteLine("Ошибка, нет третьей цифры");
//         return false;
//     }
//     return true;
// }

// int Proverka (int number)
// {
//     while (number>999)
//     {
//         number/=10; 
//     }
//     return number%10;
// }

// int number = Zapros ("Введите число > ");
// if (Rabota(number))
// {
//     Console.WriteLine (Proverka(number));
// }


//---------------------------------------------------------------------------------------------------------------------------------


// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1


// int Vvod (string Message)
// {
//     Console.Write(Message);
//     string Peremen = Console.ReadLine();
//     int Peremen2 = Convert.ToInt32(Peremen);
//     return Peremen2;
// }
// int number = Vvod ("Введите трехзначное число > ");
// if (number < 100||number >=1000)
//     {
//         Console.WriteLine("Ошибка! Введите трехзначное число");
//         return;
//     }
// Console.WriteLine($"Введенное число > {number}");
// int number2 = (number / 10)%10;
// Console.WriteLine($"Вторая цифра > {number2}");


//---------------------------------------------------------------------------------------------------------------------------------

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет


// int Nedelay (string Message)
// {
//     Console.Write(Message);
//     string Peremen = Console.ReadLine();
//     int Peremen2 = Convert.ToInt32(Peremen);
//     return Peremen2;
// }
// bool Proverka (int number)
// {
//     if (number<=0||number>7)
//     {
//         Console.WriteLine("Не является днем недели > ");
//         return false;
//     }
//     return true;
// }

// bool Proverka2  (int number)
// {
//     if (number == 6||number==7)
//     {
//         Console.WriteLine("Ура, выходной");
//         return false;
//     }
    
//     else 
//     {
//         Console.WriteLine("Увы, нужно работать");
//         return true;
//     }
// }

// int number = Nedelay("Введите день недели > ");
// if (Proverka(number))
// {
//     Proverka2(number);
// }


//---------------------------------------------------------------------------------------------------------------------------------
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


// int Input1 (string message)
// {
//     Console.WriteLine(message);
//     string Peremen = Console.ReadLine();
//     int Peremen2 = Convert.ToInt32(Peremen);
//     return Peremen2;
// }
// int max1 = Input1 ("Введите первое число");
// int max2 = Input1 ("Введите второе число");
// if (max1>max2)
// {
//     Console.WriteLine($"max число = {max1}");

// }
// else 
// {
//     Console.WriteLine($"max число = {max2}");
// }


//---------------------------------------------------------------------------------------------------------------------------------
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22


// int Input (string message)
// {
//     Console.WriteLine(message);
//     string Peremen = Console.ReadLine();
//     int Peremen2= Convert.ToInt32(Peremen);
//     return Peremen2;
// }

// int max1 =  Input("Введите 1 число ");
// int max2 =  Input("Введите 2 число ");
// int max3 =  Input("Введите 3 число ");

// if (max1>max2)
//     {
//         if (max1>max3)
//         {
//             Console.WriteLine($"max число = {max1}");
//             return max1;
//         }
//         else
//         {
//             Console.WriteLine($"max число = {max3}");
//             return max3;
//         }
//     }
//     else
//     {
//         if (max2>max3)
//         {
//             Console.WriteLine($"max число = {max2}");
//             return max2;
//         }
//         else
//         {
//             Console.WriteLine($"max число = {max3}");
//             return max3;
//         }
//     }


//------------------------------------------------------------------------------------------------------------------------------

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет


// int Input (string message)
// {
//     Console.WriteLine(message);
//     string Peremen = Console.ReadLine();
//     int Peremen2= Convert.ToInt32(Peremen);
//     return Peremen2;
// }

// bool Honest (int Peremen)
// {
//     if (Peremen%2 == 0)
//     {
//         Console.WriteLine("Четное");
//         return false;
//     }
//     else
//     {
//         Console.WriteLine("Не четное");
//         return true;
//     }
// }

// int a = Input("Введите число");
// Honest(a); 


//------------------------------------------------------------------------------------------------------------------------------


// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// int Input (string message)
// {
//     Console.WriteLine(message);
//     string Peremen = Console.ReadLine();
//     int Peremen2= Convert.ToInt32(Peremen);
//     return Peremen2;
// }

// int Honest (int Peremen)
// {
//     int a = 0;
//     if (Peremen%2 == 0)
//     {
//         while(a < Peremen)
//         {
//             a = a + 2;
//             Console.Write($"{a} ");

//         }
//         return a;
//     }
//     else
//     {
//         Peremen = Peremen-1;
//         while(a < Peremen)
//         {
//             a = a+2;
//             Console.Write($"{a} ");

//         }
//         return a;
//     }  
    
// }

// int b = Input("Введите число");
// Honest(b);
