﻿// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число");
int num2 = Convert.ToInt32(Console.ReadLine());
if ((num1==num2*num2)||(num2 ==num1*num1 ))      // Символ " && " дает понять что выполняется оба условия
{                                                // и символ " || " дает понять что выпонятся должно одно из условий
    Console.WriteLine("Да");     
}
else
{
    Console.WriteLine("Нет");
}