namespace ConsoleApp12
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("КАЛЬКУЛЯТОР\n");

            Console.WriteLine("Введите первое число:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Выберите операцию: +, -, /, *");
            string operation = Console.ReadLine();

            Console.WriteLine("Введите второе число: ");
            double b = Convert.ToDouble(Console.ReadLine());

            switch (operation)
            {
                case "+":
                    {
                        double c = Add(a, b);
                        Console.WriteLine($"Результат сложения: {c}");
                        break;
                    }
                case "-":
                    {
                        double c = Sub(a, b);
                        Console.WriteLine($"Результат вычитания: {c}");
                        break;
                    }
                case "*":
                    {
                        double c = Mul(a, b);
                        Console.WriteLine($"Результат умножения: {c}");
                        break;
                    }
                case "/":
                    {
                        double c = Div(a, b);
                        Console.WriteLine($"Результат деления: {c}");
                        break;
                    }
            }

            static double Add(double a, double b)
            {
                return a + b;
            }

            static double Sub(double a, double b)
            {
                return a - b;
            }

            static double Mul(double a, double b)
            {
                return (a * b);
            }

            static double Div(double a, double b)
            {
                return (a / b);
            }
        }
    }
}