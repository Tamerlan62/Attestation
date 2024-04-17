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
