using System;
using System.Collections.Generic;
using System.IO;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        SetAge(age);
    }

    public void Introduce()
    {
        Console.WriteLine("Hello, my name is " + Name);
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            Age = newAge;
        }
        else
        {
            Console.WriteLine("Age cannot be negative.");
        }
    }
}

public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age, string position) : base(name, age)
    {
        Position = position;
    }
}

public class PersonFileService
{
    public person ReadPeopleFromFile(){
        const string person = "persons.txt"
        
        string[] lines = File.ReadAllLines("persons.txt");

        var people = new list<Person>();
        for(int i = 0; i < persons.Length; i++){
            people.Add(new Person(person[i], Convert.ToInt32(persons[i + 1])))
        }
        Person[] array = people.ToArray();
        return array;
    }
    public void WritePeopleToFile(Person[] people){
        string path = "persons.txt";
        for(int i = 0; i < persons.Length; i++){
            File.AppendAllText(path, array[i], array[i + 1]);
            Console.WriteLine("Файл записан!");
        }
        //записывает в файл
    }
}

public class Program
{ 
    // A
    static void readAndWrite(){
        string path = "Test.txt";
        string content = "ЭТО ЗАПИСЬ";
        File.WriteAllText(path, content);
        Console.WriteLine("Файл записан!");

        string text = File.ReadAllText("Test.txt");
        Console.WriteLine(text);
    }
    // С
    static void MD(string[] path)
    {
        string path = "File.MD";
        string content1 = "## Заголовок второго уровня";
        string content2 = "";
        string content3 = "Это пример текста в Markdown.";
        string content4 = "";
        string content5  = "* Это пример маркированного текста";
        string content6  = "### Заголовок третьего уровня";
        string content7  = "**Жирный текст** и *курсив*";
        string content8  = "![Альтернативный текст](путь_к_изображению)";
        string content9  = "[Текст ссылки](https://....)";
        File.WriteAllText(path, content1, content2, content3, content4, content5, content6, content7, content8, content9);
        path.Save("output.md", SaveFormat.Markdown);
    }
    public static void Main()
    {
        // Список людей для чтения и записи в файл
        var people = new List<Person>
        {
            new Person("Alice", 28),
            new Person("Bob", 35),
            new Employee("Charlie", 42, "Manager")
        };

        // Запись Person в файл
        //PersonFileService.WritePeopleToFile(people);

        // Чтение Person из файла
        //var peopleFromFile = PersonFileService.ReadPeopleFromFile();
        
        foreach (var person in peopleFromFile)
        {
            person.Introduce();
        }

    }
}

// Структура текущей программы
// +---------------------------------+
// |            Person               |
// +---------------------------------+
// | - name: string                  |
// | - age: int                      |
// +---------------------------------+
// | + Person(name: string, age: int)|
// | + Introduce(): void             |
// | - SetAge(newAge: int): void     |
// +---------------------------------+
//                  ▲
//                  |
// +---------------------------------+
// |            Employee             |
// +---------------------------------+
// | - position: string              |
// +---------------------------------+
// | + Employee(name: string,        |
// |            age: int,            |
// |            position: string)    |
// +---------------------------------+
// Для практики B необходимо добавить PersonFileService
//
//
// +---------------------------------+
// |        PersonFileService        |
// +---------------------------------+
// | + ReadPeopleFromFile(): Person[]|
// | + WritePeopleToFile(people: Person[]): void|
// +---------------------------------+