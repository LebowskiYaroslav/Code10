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
        Person person1 = new Person();
        person1.name = "Yarik22";
        person1.age = 523;

        Person person2 = new Person();
        person2.name = "Yarik";
        person2.age = 52;

        Person[] array = new Person[2];
        array[0] = person1;
        array[1] = person2;

        for(int i = 0; i < 2; i++){
            array[i].Introduce();
        }

        System.Console.WriteLine(person.name);
        System.Console.WriteLine(person.age);
    }
}
class Employee:Person{
    public string position;
}