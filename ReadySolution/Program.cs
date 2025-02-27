namespace ReadySolution;

class Program
{
    static void Main(string[] args)
    {
        //практика а
        /*Создайте программу на псевдоязыке, которая объявляет различные переменные разных типов данных (целочисленный, вещественный, строковый и логический) и выводит их значения на экран.*/
       /* int age = 18;
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
        
        if(answer == "да"){
            Console.WriteLine("Возьми зонтик");
        }
        else{
            Console.WriteLine("Иди без зонта");
        }
        Random random = new Random();
        int number12 = random.Next(1, 10);
        
        //ПРАКТИКА С СРАВНЕНИЕ ЧИСЕЛ
        int one = Convert.ToInt32(Console.ReadLine());
        int two = Convert.ToInt32(Console.ReadLine());
        if(one > two){
            Console.WriteLine(one);
        }
        else if(two > one){
            Console.WriteLine(two);
        }
        else{
            Console.WriteLine("Равны");
        }
        
        // вывод разрядов чисел
        int number = Convert.ToInt32(Console.ReadLine());
        int hundreads = number / 100;
        int tens = (number / 100) % 10;
        int units = number % 10;
        Console.WriteLine(hundreads,tens, units); */
        // практика Б
        Console.WriteLine("Введите свое имя");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}");
        // калькулятор возраста
        Console.WriteLine("Введите важу дату рождения(год)");
        int date = Convert.ToInt32(Console.ReadLine());
        int age = 2025 - date;
        Console.WriteLine($"Ваш возраст, {age}");
        //записная книжка
        Console.WriteLine("Введите ваш номер");
        int nomer = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите имя");
        string names = Console.ReadLine();
        Console.WriteLine($"Записанное имя, {names}");
        Console.WriteLine($"Записанный номер, {nomer}");


    }
}
