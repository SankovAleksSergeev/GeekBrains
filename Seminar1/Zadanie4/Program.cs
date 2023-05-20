// Напишите программу, которая на вход принимает одно число (N), а на выход выдает все целые числа в промежутке от -N до N
Console.WriteLine("Введите N");
int n = Convert.ToInt32(Console.ReadLine());

int n1 = -1*n ;

while (n1<=n)
{
    Console.Write(n1+ ",");
    n1 = n1+1 ;
}
