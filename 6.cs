using System;

class Program
{

    static void Main()
    {
        //переменные и массивы задаем 
        Random random = new Random();
        int[] zarplata = new int[12];
        int maxZarplata = int.MinValue;
        int minZarplata = int.MaxValue;
        int minMonth = 0;
        int maxMonth = 0;
        int totalSum = 0;
        double[] Otcl = new double[12];

        //генерируем рандом зп 
        for (int i = 0; i < 12; i++)
        {
            zarplata[i] = random.Next(1000, 5001);
            totalSum += zarplata[i];

            if (zarplata[i] > maxZarplata)
            {
                maxZarplata = zarplata[i];
                maxMonth = i + 1;
            }

            if (zarplata[i] < minZarplata)
            {
                minZarplata = zarplata[i];
                minMonth = i + 1;
            }
        }
        double nowY =  totalSum *0.02;

        double nowX = totalSum / 12;
        for ( int i = 0; i <= 11; i++)
        {
            Otcl[i] = zarplata[i] - nowX;
        }
        Console.WriteLine("Зарплаты по месяцам:");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Месяц {i + 1}: {zarplata[i]} руб.");
        }

        Console.WriteLine("Отклонение от средней: ");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Месяц {i + 1}: {Otcl[i]}");
        }

        Console.WriteLine($"\nОбщая сумма выплат за год: {totalSum} руб.");

        Console.WriteLine("\nОтчисления в пенсионный фонд по месяцам:");
        for (int i = 0; i < 12; i++)
        {
            int pensia = (int)(zarplata[i] * 0.02);
            Console.WriteLine($"Месяц {i + 1}: {pensia} руб.");
        }

        Console.WriteLine($"\nМаксимальная зарплата: {maxZarplata} руб. в месяце {maxMonth}");
        Console.WriteLine($"Минимальная зарплата: {minZarplata} руб. в месяце {minMonth}");
        Console.WriteLine($"Отчисления за год: {nowY:F2} руб");
        Console.WriteLine($"Средняя зарплата: {nowX} руб");
    }
}
