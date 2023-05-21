int Max (int arg1 , int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 635;
int a2 = 745;
int a3 = 455;
int b1 = 623;
int b2 = 4826;
int b3 = 142;
int c1 = 22212;
int c2 = 848;
int c3 = 869;

// int max1 = Max (a1 , a2 , a3);       
// int max2 = Max (b1 , b2 , b3);
// int max3 = Max (c1 , c2 , c3);
// int max = Max(max1, max2, max3);
// Console.Write(max);                  Эту часть кода можно записать компактнее:

int max = Max (Max(a1, a2, a3),Max (b1, b2, b3), Max(c1, c2, c3)); 
Console.Write(max); 