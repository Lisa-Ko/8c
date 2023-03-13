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
int MinNumber(int[,] table)
{  
    int min = table[0,0];
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table [i,j] < min)
        {
            min = table [i,j];
        }
        }
    }
    return min;   
}
int IndexMinNumberI(int[,] table, int min)
{ 
    int minI = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    { 
       
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table [i,j] == min)
            {
                minI = i;
            }
        }
        
    }
    return minI;
}
int IndexMinNumberJ(int[,] table, int min)
{ 
    int minJ = 0;
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table [i,j] == min)
            {
                minJ = j;
            }
        }
        
    }
    return minJ;

}
int[,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("матрица: ");
Printtable(numbers);
int min = MinNumber(numbers);
void Printtable2(int[,] table, int minI, int minJ)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {

        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (i != minI && j != minJ)
            {
            Console.Write(" " + table[i,j]);
            }
            
        }
     Console.WriteLine();
    }
}
Console. WriteLine($"матрица с удаленными строкой ({IndexMinNumberI(numbers, min)+1 }) и столбцом ({IndexMinNumberJ(numbers, min)+1}) соответствующие индексам минимального значения({min}) начальной матрицы");
Console.WriteLine();
Printtable2(numbers, IndexMinNumberI(numbers, min), IndexMinNumberJ(numbers, min));




