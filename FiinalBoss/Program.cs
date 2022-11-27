// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// пример 

// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "compter science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.Clear();
int DigitSize = 3;
int NewStringArraySize = 0;

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] stringArray = new string[size];

Console.WriteLine();

Console.WriteLine("Введите значение элемента массива: ");

Console.WriteLine();

// заполняем массив
void FillArray(string[] stringArray)
{
    for (int i = 0; i < size; i++)
    {
        stringArray[i] = Console.ReadLine()!;
    }
}
// печатаем массив
void PrintArray(string[] stringArray)
{
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{stringArray[i]} ");
    }
}
// определяем размер нового массива
void FindNewArraySize(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= DigitSize)
        {
            NewStringArraySize = NewStringArraySize + 1;
        }
    }
}

FillArray(stringArray);

Console.WriteLine();

PrintArray(stringArray);

FindNewArraySize(stringArray);

Console.WriteLine($"-> {NewStringArraySize}");

string[] NewStringArray = new string[NewStringArraySize];

Console.WriteLine();

Console.Write($"-> ");

// заполняем новый массив
void FillNewArray(string[] NewStringArray)
{
    for (int i = 0; i < NewStringArray.Length; i++)
    {
        if (stringArray[i].Length <= DigitSize)
        {
            NewStringArray[i] = stringArray[i];
        }

    }
}
FillNewArray(NewStringArray);

// печатаем новый массив
void PrintNewArray(string[] NewStringArray)
{
    for (int i = 0; i < NewStringArray.Length; i++)
    {
        Console.Write($"{NewStringArray[i]} ");
    }
}
PrintNewArray(NewStringArray);

