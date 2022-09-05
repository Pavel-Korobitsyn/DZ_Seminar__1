Console.Write("Введите число: ");
string num = Console.ReadLine();

double doubleNum = double.Parse(num);

if (doubleNum % 2 == 0)
    {
        Console.WriteLine("Число чётное");
    }
else
    {
        Console.WriteLine("Число не чётное");
    }