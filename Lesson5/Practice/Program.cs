using System;
//ПРАКТИКА А Б
class Person{
    public string name;
    public int age;
    public void Introduce(){
        Console.WriteLine($"Привет мое имя {name}");
    }
    public int ages(int age){
        if(age < 0){
            return;
        }
        else{
            Person.age = age;
        }
    }
    public Person(string name int age){
        Name = name;
        Age = age;
    }
string[] person = new Person[2];
person.name = "yarik";
person.age = 10;

}
class Programm{
    static void Main(string[] args){
        Person person = new Person();
        person.name = "Yarik";
        person.age = 52;
        string[] person = new Person[2];
        person.name = "yarik";
        person.age = 10;
        public void Introduce(){
            Console.WriteLine($"Привет мое имя {name}");
        }
        public void Introduce(){
            Console.WriteLine($"Привет мой возраст {age}");
        }

        System.Console.WriteLine(person.name);
        System.Console.WriteLine(person.age);
    }
}
class Employee:Person{
    public string position;
}