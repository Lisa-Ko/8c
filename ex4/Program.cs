Console.WriteLine("Введите количество строк треугольника Паскаля:");
int n = int.Parse(Console.ReadLine());

void FillPascalArray (int n)
{

    for (int i = 0; i < n; i++)
    {
        int c = 1;
        for (int k = 0; k < n - i; k++)
        {
            Console.Write("   ");
        }
 
        for (int j = 0; j <= i; j++)
            {
                Console.Write(" {0:D}    ", c);
                c = c * (i - j) / (j + 1);
            }
        Console.WriteLine();
        Console.WriteLine();
    }
 }
FillPascalArray(n);

