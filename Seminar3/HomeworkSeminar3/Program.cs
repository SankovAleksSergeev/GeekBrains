// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// int Input (string Message)
// {
//     Console.WriteLine(Message);
//     string Peremen = Console.ReadLine();
//     int Peremen2 = Convert.ToInt32(Peremen);
//     return Peremen2;
// }

// int Palynodrome = Input("Введите пятизначное число");
// int X1 = Palynodrome/10000;
// int X2 = Palynodrome%10;
// if ((Palynodrome<10000)||(Palynodrome>99999))
// {
//     Console.WriteLine("Ошибка! Введите пятизначное число");
// }
// else if (X1==X2)
// {
//     X1 = (Palynodrome/1000)%10;
//     X2 = (Palynodrome%100)/10;
//     if (X1==X2)
//     {
//         Console.WriteLine("Да");
//     }
//     else
//     {
//         Console.WriteLine("Нет");
//     }
// }
// else 
// {
//     Console.WriteLine("Нет");
// }


//------------------------------------------------------------------------------------------------------------------------------


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// int Input (string Message)
// {
//     Console.WriteLine(Message);
//     string Peremen = Console.ReadLine();
//     int Peremen2 = Convert.ToInt32(Peremen);
//     return Peremen2;
// }

// int x1 = Input ("Введите точку x1");
// int y1 = Input ("Введите точку y1");
// int c1 = Input ("Введите точку c1");

// int x2 = Input ("Введите точку x2");
// int y2 = Input ("Введите точку y2");
// int c2 = Input ("Введите точку c2");

// double D = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((c2-c1),2));
// Console.WriteLine($"Расстояние между точками = {D}"); 


//------------------------------------------------------------------------------------------------------------------------------


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int Input (string Message)
// {
//     Console.WriteLine(Message);
//     string Peremen = Console.ReadLine();
//     int Peremen2 = Convert.ToInt32(Peremen);
//     return Peremen2;
// }

// int N = Input("Введите число");
// int count = 1;
// Console.Write("Таблица кубов число N = ");
// while(count<=N)
// {
//     double x = Math.Pow(count,3);
//     Console.Write ($"{x}  ");
//     count++;
// }

