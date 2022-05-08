string[] array = new string[4] { "123", "var", "-123", "asdf" };
string[] arr = new string[array.Length];
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}" + " ");
    }
}
void FindArray(string[] array, string[] newArr)
{
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArr[j] = array[i];
            j++;
        }
    }
}
FindArray(array, arr);
PrintArray(arr);