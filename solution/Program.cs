// Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
//  и возвращает позицию этого элемента или же указание, что такого элемента нет. (первое вхождение), показывает не индексы, а позицию при обычном счете

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-10, 11);
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

string FindNumber(int[,] matr, int num)
{
    string answer = "Такого числа нет в массиве";

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] == num)  
            {
                answer = "ряд " + $"{i+1}" + "\t" + "столб " + $"{j+1}";
                break;
            }
        }
    }
    return answer;
}

Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

FillArray(array);
PrintArray(array);
Console.WriteLine(FindNumber(array, number));