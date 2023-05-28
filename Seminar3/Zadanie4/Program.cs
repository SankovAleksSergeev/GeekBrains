// Написать программу которая на вход принимает число и выдает 
// таблицу квадратных чисел 
// Например 5 = 1, 4, 9, 16, 25
//          2 = 1, 4

int Print (string Massange)
{
    Console.WriteLine(Massange);
    string Peremen = Console.ReadLine();
    int Peremen2 = Convert.ToInt32(Peremen);
    return Peremen2;

}
int num  = Print ("Введите число");
int count = 1;
while ( num> count)
{
    Console.Write($" {Math.Pow(count,2)},");
    count= count +1;
}