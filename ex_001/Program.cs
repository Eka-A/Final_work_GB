int size = 4;
string[] array = new string[size];
int maxLength = 3;
array[0] = "Ru";
array[1] = "321";
array[2] = "Kazan";
array[3] = "LA";

PrintArray(array);


void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < size; i++)
    {
        Console.Write($"'{array[i]}',");
    }
    Console.Write("\b");
    Console.Write("]");
    Console.WriteLine();
}