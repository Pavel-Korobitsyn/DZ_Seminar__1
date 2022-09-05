Console.WriteLine("Введие число 1");
string num1 = Console.ReadLine ();
Console.WriteLine("Введие число 2");
string num2 = Console.ReadLine ();
Console.WriteLine("Введие число 3");
string num3 = Console.ReadLine ();

int intNum1 = int.Parse(num1);
int intNum2 = int.Parse(num2);
int intNum3 = int.Parse(num3);

int max = 0;

if(intNum1 > max)
    {
        max = intNum1;
    }
if(intNum2 > max)
    {
        max = intNum2;
    }
if(intNum3 > max)
    {
        max = intNum3;
    }

Console.WriteLine($"Максимальное число равно: {max}");