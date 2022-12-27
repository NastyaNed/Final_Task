// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// 
string[] sourceArray = GetStringArray();
int count = HowManyElementsAreLessThanThreeLetters(sourceArray);

string[] newArray = LessThanThreeLettersPartArray(sourceArray, count);
Console.WriteLine($"[{String.Join(", ", sourceArray)}] -> [{String.Join(", ", newArray)}]");

string[] GetStringArray()
{
    Console.WriteLine("Сколько будет элементов массива?");
    int strLength = int.Parse(Console.ReadLine()!);
    Console.WriteLine("Введите элементы: ");
    string[] sourceArray = new string[strLength];
    for (int i = 0; i < strLength; i++)
    {
        sourceArray[i] = Console.ReadLine()!;
    }
    return sourceArray;
}

int HowManyElementsAreLessThanThreeLetters(string[] sourceArray)
{
    int count = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <4)
        {
            count++;
        }
    }
    return count;
}

string[] LessThanThreeLettersPartArray(string[] originArray, int newLenght)
{
    string[] newPartArray = new string[newLenght];
    int Z = 0;
    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= 3)
        {
            newPartArray[Z] = sourceArray[i];
            Z++;
        }
    }
    return newPartArray;
}