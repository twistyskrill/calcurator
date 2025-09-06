using System;

class Calculator
{
    static int Main()
    {
        Console.Write("Введите действие: ");
        string? znak = Console.ReadLine();
        double? memory = 0;
        double? last = 0;

        while (znak != "0")
        {
            if (znak == "+" || znak == "-" || znak == "*" || znak == "/" || znak == "%")
            {
                memory = last;
                Console.Write("Введите первое число: ");
                double? chislo1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите второе число: ");
                double? chislo2 = Convert.ToDouble(Console.ReadLine());

                if (znak == "+")
                {
                    last = chislo1 + chislo2;
                    Console.WriteLine(last);
                }
                else if (znak == "-")
                {
                    last = chislo1 - chislo2;
                    Console.WriteLine(last);
                }
                else if (znak == "*")
                {
                    last = chislo1 * chislo2;
                    Console.WriteLine(last);
                }
                else if (znak == "/")
                {
                    if (chislo2 == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    else
                    {
                        last = chislo1 / chislo2;
                        Console.WriteLine(last);
                    }
                }
                else if (znak == "%")
                {
                    last = (chislo1 / 100) * chislo2;
                    Console.WriteLine(last);
                }
            }
            else if (znak == "1/x" || znak == "x^2" || znak == "sqrt")
            {
                memory = last;
                Console.Write("Введите значение х: ");
                double x = Convert.ToDouble(Console.ReadLine());

                if (znak == "1/x")
                {
                    if (x == 0)
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                    }
                    else
                    {
                        last = 1 / x;
                        Console.WriteLine(last);
                    }
                }
                else if (znak == "x^2")
                {
                    last = Math.Pow(x, 2);
                    Console.WriteLine(last);
                }
                else if (znak == "sqrt")
                {
                    if (x < 0)
                    {
                        Console.WriteLine("Ошибка: корень из отрицательного числа!");
                    }
                    else
                    {
                        last = Math.Sqrt(x);
                        Console.WriteLine(last);
                    }
                }
            }
            else if (znak == "m+" || znak == "m-" || znak == "mr" || znak == "mc")
            {
                if (znak == "m+")
                {
                    memory += last;
                    Console.WriteLine($"Memory: {memory}");
                }
                else if (znak == "m-")
                {
                    memory -= last;
                    Console.WriteLine($"Memory: {memory}");
                }
                else if (znak == "mr")
                {
                    Console.WriteLine($"Memory: {memory}");
                }
                else if (znak == "mc")
                {
                    memory = 0;
                    Console.WriteLine("Memory cleared");
                }
            }
            else
            {
                Console.WriteLine("Действие не найдено. Доступные команды: +, -, *, /, %, 1/x, x^2, sqrt, m+, m-, mr, mc");
            }
            
            Console.WriteLine("Для выхода введите 0");
            Console.Write("Введите действие: ");
            znak = Console.ReadLine();
        }
        
        return 0;
    }
}