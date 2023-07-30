
// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

void ReverseRowsOnColumns(int[,] array)
{
    if (array.GetLength(1) == array.GetLength(0))
    {
        int temp = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < i; j++)
            {
                temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }
    else
    {
        Console.WriteLine("замена строк на столбцы невозможна");
    }

}

void OutputArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("| ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("|");
        Console.WriteLine("");
    }
}

void CreateRandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

Console.WriteLine("введите количество строк");
int numberLine = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int numberColumn = int.Parse(Console.ReadLine());

int[,] numbers = new int[numberLine, numberColumn];
CreateRandomArray(numbers);
OutputArray(numbers);
Console.WriteLine();
ReverseRowsOnColumns(numbers);
OutputArray(numbers);