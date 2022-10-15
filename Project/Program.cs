string[] CreateArray()
{
    int size = 0;
    System.Console.Write("Enter size of array: ");
    while (!int.TryParse(Console.ReadLine(), out size))
    {
        System.Console.Write("Enter size of array: ");
        if (size >= 1)
            return new string[size];
        else
        {
            System.Console.WriteLine("Size of array must be greater than 0");
            System.Console.Write("Enter size of array: ");
        }
    }
    return new string[size];
}

void FillArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"Enter string[{i}]: ");
        array[i] = Console.ReadLine() ?? String.Empty;
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.WriteLine($"\t{array[i]}");
    }
    if (array.Length == 0)
        System.Console.WriteLine("\tElements are absent");
    System.Console.WriteLine();
}

string[] FilterArray(string[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            counter++;
        }
    }
    string[] resultArray = new string[counter];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[resultArray.Length - counter] = array[i];
            counter--;
        }
    }
    return resultArray;
}

string[] sourceArray = CreateArray();
FillArray(sourceArray);
System.Console.WriteLine("Source array:");
PrintArray(sourceArray);
System.Console.WriteLine("Result array:");
PrintArray(FilterArray(sourceArray));

