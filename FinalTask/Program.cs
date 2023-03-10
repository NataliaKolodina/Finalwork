// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
// длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int num = int.Parse(Console.ReadLine()!)!;
string[] arr = GetArray(num);
Console.Write("[");
PrintArray(arr);
Console.Write("] -> [");
ElementSelection(arr);
Console.Write("]");

string InputElelment(string message)
{
    Console.Write($"{message}: ");
    string res = Console.ReadLine()!;
    return res;
}

string[] GetArray(int size)
{
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = InputElelment("Введите элемент массива: ");
    }
    return result;
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"“{inArray[i]}” ");
    }
}

string[] ElementSelection(string[] Array)
{
    string[] res = new string[Array.Length];
    for (int i = 0; i < Array.Length; i++)
    {
        string element = Array[i];
        int count = element.Length;
        if (count < 4)
        {
            Console.Write($"“{Array[i]}” ");
        }
    }
    return res;
}
