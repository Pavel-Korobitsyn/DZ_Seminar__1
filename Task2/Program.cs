Console.WriteLine ("Введите число 1.");
string num1 = Console.ReadLine ();
Console.WriteLine ("Введите число 2.");
string num2 = Console.ReadLine ();

int intNum1 = int.Parse(num1);
int intNum2 = int.Parse(num2);

if (intNum1 > intNum2)
    {
        Console.WriteLine($"Максимальное число равно: {intNum1}");
    }
else
    {
        Console.WriteLine($"Максимальное число равно: {intNum2}");
    }