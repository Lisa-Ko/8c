int[,] CreateInttable()
{
    Console.Write("Введите длину  ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите ширину  ");
    int n = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[,] table = new int[m,n];
    return  table;
}
void Filltable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i,j] =new Random().Next(0, 10);
        }
    }
}
void Printtable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(" " + table[i,j]);
        }
     Console.WriteLine();
     }
}
void Product(int[,] table, int[,] table2, int [,] result)
{
    if (table.GetLength(1) == table2.GetLength(0))
    {
        for (int i = 0; i < result.GetLength(0); i++)
        {
            for (int j = 0; j < result.GetLength(1); j++)
            {
                int sum = 0;
                for (int k = 0; k < table.GetLength(1); k++)
                { 
                    sum += table[i,k] * table2[k,j];
                }
                result[i,j] = sum;
            }
        }
    }
    else Console.WriteLine("Матрицы не возможно перемножить так как перемножать можно только такие матрицы у которых число столбцов в первой матрице равно числу строк во второй матрице. ");
}

int[,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("массив: ");
Printtable(numbers);

int[,] numbers2 = CreateInttable();
Filltable(numbers2);
Console.WriteLine("массив: ");
Printtable(numbers2);
int [,] result = new int[numbers.GetLength(0),numbers2.GetLength(0)];
Product(numbers, numbers2, result);
Printtable(result);

