// Написать программу которая принемает на вход координату двух точек
// и находит между ними расстояние в 2d пространтсве 

int Print (string Massange)
{
    Console.WriteLine(Massange);
    string Peremen = Console.ReadLine();
    int Peremen2 = Convert.ToInt32(Peremen);
    return Peremen2;

}

int x1 = Print("Введите число");
int y1 = Print("Введите число");
int x2 = Print("Введите число");
int y2 = Print("Введите число");

double d = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2));
Console.WriteLine(d);