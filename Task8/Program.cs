Console.Write("Введите число: ");
string N = Console.ReadLine();

int intN = int.Parse(N);

Console.Write($"Чётные числа в промежутке от 1 до {intN}: " );
 
for(int i = 1; i < intN; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }