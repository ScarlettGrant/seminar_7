//  Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-30, 31);
        }
    }
}

void PrintArray(int[,] arr)
{
     for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],3}   ");
        }
        System.Console.WriteLine();    
    }
}
double count = 0;
string FindAverage(int[,] arr)
{
    string answer = "";
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            count += arr[j, i];
        }
        answer += $"{i + 1} столб = {count / arr.GetLength(0)}    ";
        count = 0;    
    }
    return answer;
}
System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
System.Console.WriteLine(FindAverage(array));