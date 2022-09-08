string[] StringArrayCreation()
{
    Console.Write("Введите количество элементов массива: ");
    int q = Convert.ToInt32(Console.ReadLine());

    string[] array = new string [q];

    for (int count = 0; count < array.Length; count++)
    {
        Console.Write($"Введите {count+1}й элемент массива: ");
        array[count] = Console.ReadLine();
    }

    return array;
}

void ShowArray(string[] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
     {
        Console.Write("[" + array[i] + "] ");
     }
     Console.WriteLine();
}

string[] LessThan3Array(string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) count++;
    }

    string[] newArray = new string[count];

    count = 0;
    for (int j = 0; j < newArray.Length; j++)
    {
        while (array[count].Length > 3) count++;
        newArray[j] = array[count];
        count++;
    }

    return newArray;
}

string[] userArray = StringArrayCreation();
Console.WriteLine();
Console.WriteLine("Введенный с клавиатуры массив: ");
ShowArray(userArray);
Console.WriteLine();
string[] modArray = LessThan3Array(userArray);
Console.WriteLine("Модифицированный массив, состоящий из тех элементов первого массива, в которых кол-во символов не превышает 3: ");
ShowArray(modArray);
Console.WriteLine();