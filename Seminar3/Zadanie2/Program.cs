//Обратная задача, написать программу которая при вводе числа от 1 до 4 выдает какие могут быть x и y 
int Print (string Massange)
{
    Console.WriteLine(Massange);
    string Peremen = Console.ReadLine();
    int Peremen2 = Convert.ToInt32(Peremen);
    return Peremen2;
} 
int x = Print("Введите номер координатной плоскости");

switch (x)
{
    case 1:
    {
        Console.WriteLine("(x>0)&&(y>0)");
        break;
    }
    case 2:
    {
        Console.WriteLine("(x<0)&&(y>0)");
        break;
    }
    case 3:
    {
        Console.WriteLine("(x<0)&&(y<0)");
        break;
    }
    case 4:
    {
        Console.WriteLine("(x>0)&&(y<0)");
        break;
    }
    default:
    {
        Console.WriteLine("Ошибка. Неверное число");
        break;
    }
}
    
// }
// if (x==1)
// {
//     Console.WriteLine("(x>0)&&(y>0)");
// }
// else if (x==2)
// {
//      Console.WriteLine("(x<0)&&(y>0)");
// }
// else if (x==3)
// {
//      Console.WriteLine("(x<0)&&(y<0)");
// }
// else if (x==4)
// {
//      Console.WriteLine("(x>0)&&(y<0)");
// }
// else if (x==0)
// {
//      Console.WriteLine("Начальная точка (x==0)&&(y==0)");
// }
// else if ((x>4)&&(x<0))
// {
//      Console.WriteLine("Ошибка. Неверное число");
// }