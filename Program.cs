string[] CreatString(string[] strings)
{
    int count = 0;

    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            count++;
        }
    }

    string[] array_str = new string[count];
    int index = 0;

    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            array_str[index] = str;
            index++;
        }
    }
    return array_str;
}

Console.Write("Enter size: ");
int n = int.Parse(Console.ReadLine()!);

string[] new_array_str = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Enter string {i + 1}: ");
    new_array_str[i] = Console.ReadLine()!;
}

string[] array_str = CreatString(new_array_str);

Console.WriteLine("Array strings (size <= 3 elements):");
Console.Write("[");

foreach (string str in array_str)
{
    Console.Write($"{str}, ");
}
Console.WriteLine("]");
