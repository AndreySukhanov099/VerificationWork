Console.Write("Введите число элементов массива");
int numbers = Convert.ToInt32(Console.ReadLine());

string[] arrayStrings = new string[numbers];
for (int i = 0; i < numbers; i++)
{
    Console.WriteLine($"Введите {i+1} элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[numbers];
int pos = 0;

for (int j = 0; j < numbers; j++)
{
    if (arrayStrings[j].Length <= 3)
    {
        arrayFinal[pos] = arrayStrings[j];
        pos++;
    }
}
Console.WriteLine();
PrintArray(arrayFinal);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}