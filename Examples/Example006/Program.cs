﻿int nun1 = 2;
int nun2 = 3;
int nun3 = 6; 
int nun4 = 8;
int nun5 = 4; 

int max = nun1;

if (max < nun2) max = nun2;
if (max < nun3) max = nun3;
if (max < nun4) max = nun4;
if (max < nun5) max = nun5;

Console.Write("max = ");
Console.WriteLine(max);