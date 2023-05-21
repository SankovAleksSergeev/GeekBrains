void NapolnenieArray (int[] Collection)
{
    int Length = Collection.Length;
    int count = 0;
    while (count < Length)
    {
        Collection[count]= new Random().Next(0,10);
        count++;
    }    

}

void PrintArray (int[] Coll)

{
    int ind = Coll.Length;
    int index = 0;
    while(index < ind)
    {
        Console.WriteLine(Coll[index]);
        index++;
    }
}

int IndexOf (int[] collection, int find)
{
    int count = collection.Length;
    int index = 0; 
    int num = -1;
    while(index < count)
    {
        if (collection[index]==find)
        {
           num = index;
           break; 
        }

        index++;
    }
    return num;
}


int [] array = new int [10];

NapolnenieArray(array);
PrintArray (array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);

