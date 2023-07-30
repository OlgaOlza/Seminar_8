// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.
// { 1, 9, 9, 0, 2, 8, 0, 9 }
// 0 встречается 2 раза 
// 1 встречается 1 раз 
// 2 встречается 1 раз 
// 8 встречается 1 раз 
// 9 встречается 3 раза
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

void NumberDictionary(int[,] array, int dicLength)
{
    int[] dictionary = new int[dicLength + 1];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            dictionary[array[i, j]] += 1;
        }
    }
    for (int x = 0; x < dictionary.Length; x++)
    {
        if (dictionary[x] == 0) continue;

        if ((dictionary[x] % 10) > 1 && (dictionary[x] % 10) < 5)
            Console.WriteLine($"{x} встречается {dictionary[x]} раза");
        else
            Console.WriteLine($"{x} встречается {dictionary[x]} раз");
    }
}

void PrintDoubleMassive(int[,] massive)
{
    for (int i = 0; i < massive.GetLength(0); i++)
    {
        for (int j = 0; j < massive.GetLength(1); j++)
        {
            Console.Write($" {massive[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] DoDoubleMassive(int rows, int columns, int minValue, int maxValue)
{
    int[,] result = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

int GetInfo(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int rows = GetInfo("Введите количество строк массива: ");
int columns = GetInfo("Введите количество столбцов массива: ");
int maxNumber = GetInfo("Введите максимальное число: ");

int[,] massive = DoDoubleMassive(rows, columns, 0, maxNumber);
PrintDoubleMassive(massive);
System.Console.WriteLine();
NumberDictionary(massive, maxNumber);
