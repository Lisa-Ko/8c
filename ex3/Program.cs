int[,,] CreateInttable()
{
    Console.Write("Введите высоту  ");
    int m = int.Parse(Console.ReadLine()!);

    Console.Write("Введите длину  ");
    int n = int.Parse(Console.ReadLine()!);

    Console.Write("Введите ширину  ");
    int p = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
    int[,,] table = new int[m,n,p];
    return  table;
}
void Filltable(int[,,] table)
{
    int count = 10;
    for (int i = 0; i < table.GetLength(0); i++)
        {
            for (int j = 0; j < table.GetLength(1); j++)
            {             

                for (int k = 0; k < table.GetLength(2); k++)
                {     
                    table[i, j, k] = count;
                    count++;
                } 
            }
        }
} 

void Printtable(int[,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {                
            Console.WriteLine();
           for (int k = 0; k < table.GetLength(2); k++)
            {
                if (table[i, j, k]< 100)
                {
                    Console.Write(" " + table[i,j,k] + $"({i};{j};{k})");
                }
            }
        }
     Console.WriteLine();
     }
}

int[,,] numbers = CreateInttable();
Filltable(numbers);
Console.WriteLine("массив: ");
Printtable(numbers);

