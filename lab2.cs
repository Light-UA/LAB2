using System;

class Lab2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Шевченко Олексій\n");

        double z = 0.654;
        double a = 1.13;
        double b = 9.07;


        // Введення значень x та y
        Console.Write("Введіть значення x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введіть значення y: ");
        double y = double.Parse(Console.ReadLine());

        // Обчислення значень q, j, m та f
        double q = Math.Exp(Math.Abs(x - y)) * Math.Pow(Math.Tan(z * z) + 1, x);
        double j = Math.Exp(a * z) / Math.Sqrt(1 + Math.Exp(a * z));
        double m = Math.Pow(Math.Log(b * z * z), 2) / (1 - a * z * z);
        double f = Math.Pow(Math.Tan(y / 2), 2);

        // Виведення на екран результатів обчислень
        Console.WriteLine("q = {0}", q);
        Console.WriteLine("j = {0}", j);
        Console.WriteLine("m = {0}", m);
        Console.WriteLine("f = {0}", f);

        Console.ReadKey();
    }
}
