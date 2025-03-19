using System;
//ПРАКТИКА А Б
/*class Person{
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
    public Person(string name, int age){
        Name = name;
        Age = age;
    }
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
}*/
int[] numbers = {1, 2, 3, 3, 3, 3, 4, 5};
int result = Homework.moda(numbers);
Console.WriteLine(result);
class Homework{
    public static int moda(int[] numbers){
        var most = numbers.GroupBy(x => x).OrderByDescending(x => x.Count()).First();
        return most.Count();

    }
    public static int[,] TransposeMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        
        int[,] result = new int[cols, rows];
        
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[j, i] = matrix[i, j];
            }
        }
        
        return result;
    }
}


