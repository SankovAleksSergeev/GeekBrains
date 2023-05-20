﻿Console.Write("ВВедите Ваше Имя ");
string username = Console.ReadLine();

if (username.ToLower() == "саша")
{
    Console.WriteLine("Ура, этоже Саша!");
}
else
{ 
    Console.Write("Привет, ");
    Console.WriteLine(username);
}