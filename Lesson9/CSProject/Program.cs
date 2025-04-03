// See https://aka.ms/new-console-template for more information
using Microsoft.VisualBasic;

Console.WriteLine("Hello, World!");
class Program
{
    static void Main()
    {
        int x = 10;
        int y = 0;
        try
        {
            int result = x/y;
            Console.WriteLine($"Деление: {result}");
        }
        catch (DivideByZeroException ex) 
        {
            Console.WriteLine($"Ошибка: Деление на ноль невозможно. {ex.Message} ");
        }

        
    }

    static int GetValidNumber()
    {
        while (true)
        {
            try
            {
                return Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: Пожалуйста, введите корректное число.");
            }
        }
    }
}
