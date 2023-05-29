//Написать программу которая на вход принимает x и y , а выводит в какой четверти координатной плосклости находтся точка 
int Print (string Massange)
{
    Console.WriteLine(Massange);
    string Peremen = Console.ReadLine();
    int Peremen2 = Convert.ToInt32(Peremen);
    return Peremen2;
} 
int x = Print("Введите x");
int y = Print("Введите y");
if ((x>0)&&(y>0))
{
    Console.WriteLine("1");
}
else if ((x<0)&&(y>0))
{
     Console.WriteLine("2");
}
else if ((x<0)&&(y<0))
{
     Console.WriteLine("3");
}
else if ((x>0)&&(y<0))
{
     Console.WriteLine("4");
}
else if ((x==0)&&(y==0))
{
     Console.WriteLine("Начальная точка");
}