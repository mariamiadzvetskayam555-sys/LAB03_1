namespace LAB03_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите первое число: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Введите второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Введите 3 число: ");
            int c = int.Parse(Console.ReadLine());


            Console.WriteLine($"Сумма: {a + b}");
            Console.WriteLine($"Разность: {a - b}");
            Console.WriteLine($"Произведение: {a * b}");
            Console.WriteLine($"Среднее арифметическое: {((a + b + c)/3.0):F2}");
        }
    }
    // проверка работы с Git
}

