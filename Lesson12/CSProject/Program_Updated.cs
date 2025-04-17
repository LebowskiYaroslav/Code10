using System;
using System.ComponentModel.DataAnnotations;

public delegate int StringComparison(string str1, string str2);
public delegate bool Predicate<T>(T item);

class Program
{
    public static int CompareByLength(string str1, string str2)
    {
        return str1.CompareTo(str2);
    }

    public static int CompareByAlphabetical(string str1, string str2)
    {
        int score = 0;
        int len;

        if (str1.Length > str2.Length){
            len = str2.Length;
        }
        else
        {
            len = str1.Length;
        }

        for (int i = 0; i < len; i++)
        {
            if (str1[i] > str2[i])
            {
                score++;
            }
            else
            {
                score--;
            }
        }
        return score;
    }

    public static string[] SortStrings(StringComparison comparison, string[] strings)
    {
        for (int i = 0; i < strings.Length - 1; i++)
        {
            for (int j = 0; j < strings.Length - i - 1; j++)
            {
                if (comparison(strings[i], strings[j]) > comparison(strings[j], strings[i]))
                {
                    string temp = strings[i];
                    strings[i] = strings[j];
                    strings[j] = temp;
                }
            }
        }
        return strings;
    }

    public static void Swap<T>(ref T x, ref T y)
    {
        T temp = x;
        x = y;
        y = temp;
    }

    public static void Finished()
    {
        System.Console.WriteLine("Завершение процесса успешно обработано");
    }

    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    public static bool IsLongString(string str)
    {
        return str.Length > 5;
    }

    public static T[] FilterCollection<T>(T[] collection, Predicate<T> predicate)
    {
        return Array.FindAll(collection, item => predicate(item));
    }

    public static void Main()
    {
        // practice B
        int[] numbers = { 1, 2, 3, 4, 5, 6 };
        string[] strings = { "short", "longerString", "tiny", "lengthyString" };

        // Filter even numbers
        int[] evenNumbers = FilterCollection(numbers, IsEven);
        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num);
        }

        // Filter long strings
        string[] longStrings = FilterCollection(strings, IsLongString);
        Console.WriteLine("Long Strings:");
        foreach (var str in longStrings)
        {
            Console.WriteLine(str);
        }

        // Existing sorting tests
        StringComparison del = CompareByLength;
        string[] test = { "abc", "bca", "asdsad", "asfdsdf", "sg", "fsdjkfsdf" };
        foreach (string testString in SortStrings(del, test))
        {
            Console.WriteLine(testString);
        }

        del = CompareByAlphabetical;
        foreach (string testString in SortStrings(del, test))
        {
            Console.WriteLine(testString);
        }

        // Practice C: Testing BankAccount
        BankAccount account = new BankAccount(1000);
        account.BalanceChanged += (oldBalance, newBalance) =>
        {
            Console.WriteLine($"Balance changed from {oldBalance} to {newBalance}");
        };

        account.Deposit(500);
        account.Withdraw(200);
        try
        {
            account.Withdraw(1300); // This will throw an exception
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

public delegate void Notify();

class Process
{
    public Notify OnCompleted;

    public void Start()
    {
        System.Console.WriteLine("Процесс запущен!");
        System.Threading.Thread.Sleep(1000);
        System.Console.WriteLine("Процесс успешно завершен!");

        OnCompleted?.Invoke();
    }
}

class Box<T>
{
    public T value { get; set; }

    public void Print()
    {
        System.Console.WriteLine($"В коробке: {value}");
    }
}

public class Animal {}
public class Dog : Animal {}

public class AnimalBox<T> where T : Animal
{
    public T value { get; set; }
}
