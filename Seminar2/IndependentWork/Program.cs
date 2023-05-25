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