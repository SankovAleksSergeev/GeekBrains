// Напишите программу которая на вход от пользователя принимает два числа и проверяет является ли оно квадратом второго 
Console.WriteLine("Введеите число один");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введеите число один");
int b = Convert.ToInt32(Console.ReadLine()); 

if (a == b*b)
{
    Console.Write("Да");
}
else 
{
    Console.Write("Нет");
}

