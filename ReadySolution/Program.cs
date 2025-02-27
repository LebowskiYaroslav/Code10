namespace ReadySolution;

class Program
{
    static void Main(string[] args)
    {
        //практика а
        /*Создайте программу на псевдоязыке, которая объявляет различные переменные разных типов данных (целочисленный, вещественный, строковый и логический) и выводит их значения на экран.*/
        int age = 18;
        Console.WriteLine($"age: {age}");
        double pi = 3.14;
        Console.WriteLine($"pi: {pi}");
        string name = "Yarik";
        Console.WriteLine($"name: {name}");
        bool logic = false;
        Console.WriteLine($"logic: {logic}");
        
        Console.WriteLine("Введите 1 число а потом 2");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int summ = number1 + number2;
        int diff = number1 - number2;
        int um = number1 * number2;
        int del = number1 / number2;
        Console.WriteLine(summ);
        Console.WriteLine(diff);
        Console.WriteLine(um);
        Console.WriteLine(del);

        Console.WriteLine("Введите число!");
        int number3 = Convert.ToInt32(Console.ReadLine());
        int summa = number3 + 5;
        Console.WriteLine(summa);

        Console.WriteLine("Идет дождь? да/нет");
        string answer = Console.ReadLine();
        
        if(answer === "да"){
            Console.WriteLine("Возьми зонтик");
        }
        else{
            Console.WriteLine("Иди без зонта");
        }
    }
}
