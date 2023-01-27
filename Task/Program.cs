string[] NewReduseArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            array2[count] = array[i];
            count++;
        }
    }
    return array2;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


string[] array = new string[5] { "33", "Lo", "666", "wizard", "42" };
string[] array2 = new string[array.Length];

string[] newArray = NewReduseArray(array, array2);
PrintArray(array2);
