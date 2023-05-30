// Вид 1. Метод. Ничего не возвращают и не принемают аргументы

// void Method1()
// {
//     Console.WriteLine("Автор");
// }
// Method1();

// Вид 2. Метод. Ничего не возвращают, но могут принемать аргументы

// void Method2 (string mds)
// {
//     Console.WriteLine(mds);

// }     
// Method2(mds:"Текст сообщения");

// void Method21 (string mds, int count)
// {
//     int ind = 0;
//     while (ind<count)
//     {
//         Console.WriteLine(mds);
//         ind++;
//     }
// }

// Method21 (count:4, mds:"Какое-то сообщение");


//Вид 3. Метод. Методы которые что возвращают, но ничего не принимают

// int Method3 ()
// {
//     return DateTime.Now.Year;
// }
// int year = Method3();
// Console.WriteLine(year); 



//Вид 4. Метод. Методы которые что-то принимают и что-то возвращают

// string Method4(int count, string c)
// {
//     int i =0;
//     string result = String.Empty;
//     while(i<count )
//     {
//         result = result + c;
//         i++;

//     }
//     return result;
    
// }
// string res = Method4(c: "Какой-то текст ", count: 3);
// Console.WriteLine(res);


// Цикл for 

// string Method4(int count, string c)
// {
//     string result = String.Empty;
//     for (int i= 0;i<count; i++)   //  в первой части идет иницилизаци счетчика, далее проверка условия, и далее инкримент(увеличиение счетчика)
//     {
//         result = result + c;
//     }
//     return result;
    
// }
// string res = Method4(c: "Какой-то текст ", count: 3);
// Console.WriteLine(res);


// Цикл в цикле 

// for (int i=2; i<=10;i++)
// {
//     for(int j=2; j<=10;j++)
//     {
//         Console.WriteLine($"{i} * {j} = {i*j}");
    
//     }
//     Console.WriteLine();
// }


//=== Работа с текстом
// Дан текст. В тексте нужно заменить все пробелы черточками,
// маленькие буквы "к" заменить большими "К", а большие "С"
// заменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбнись, - что,"
                +"ежели вам послали вместо нашего милого Винцегероде,"
                +"вы бы взяли приступом согласия прусского короля."
                +"Вы так красноречивы. Вы дадите мне чаю?";

// strindg s = "qwerty"
//              012
//s[3] // r       

string Replace(string text, char oldValue, char newValie )  // char - это какойто конкретный символ (char oldValue - это переменная символа в тескте, 
                                                                      // char newValie - это переменная на которую мы будем менять символ в тексте 

{
    string result = String.Empty;    //String.Empty -это иницилизация пустой строки
     
    int length = text.Length;
    for (int i =0; i < length; i++)
    {
        if (text[i]==oldValue)
        result = result + $"{newValie}";
        else 
        result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace (text, ' ', '|'  );
Console.WriteLine (newText); 
Console.WriteLine();

newText = Replace (newText, 'к', 'К'  );
Console.WriteLine (newText);
Console.WriteLine();

newText = Replace (newText, 'С', 'с'  );
Console.WriteLine (newText);
Console.WriteLine();

