## Теория

### Матрицы (двумерные массивы)

**Матрица** - двумерный массив, то есть массив, у которого есть строки и столбцы.

**Обьявление матрицы**
```
тип_данных[,] имя_массива = new тип_данных[строки, столбцы];
```
Например
```csharp
int[,] matrix = new int[3, 4]; // 3 строки, 4 столбца
```
Мы получим пустую матрицу 3 на 4 с нулями по умолчанию
```
0 0 0 0  
0 0 0 0  
0 0 0 0
```

**Инициализация матрицы**
```csharp
int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
```
Соответственно, мы получим матрицу такого типа:
```
1 2 3
4 5 6
7 8 9
```
**Доступ к элементам**

Для доступа к элементам указываем индексы [строка, столбец]:
```csharp
int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};
Console.WriteLine(matrix[1, 2]); // 6 (вторая строка, третий столбец)
matrix[2, 1] = 99; // Заменили 8 на 99
```
Теперь матрица выглядит так:
```
1  2  3  
4  5  6  
7 99  9  
```
Для того, чтобы пройтись по всем элементам матрицы используем вложенный цикл
```csharp
int[,] matrix = {
    { 1, 2, 3 },
    { 4, 5, 6 },
    { 7, 8, 9 }
};

for (int i = 0; i < matrix.GetLength(0); i++) // Строки
{
    for (int j = 0; j < matrix.GetLength(1); j++) // Столбцы
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine(); // Переход на новую строку
}

// Выведет:
// 1 2 3
// 4 5 6
// 7 8 9
```
`matrix.GetLength(0)` – количество строк\
`matrix.GetLength(1)` – количество столбцов

### ООП

**Объектно-ориентированное программирование (ООП)** — подход, в котором программа строится из объектов, взаимодействующих друг с другом

Основные принципы ООП:
1. **Инкапсуляция** – скрытие деталей реализации, доступ к данным через методы и свойства
2. **Наследование** – возможность одного класса унаследовать данные и методы другого
3. **Полиморфизм** – использование одного интерфейса для разных типов объектов
4. **Абстракция** – выделение только значимых характеристик объекта, скрытие деталей

**Классы** – основа объектно-ориентированного программирования (ООП) в C#. Они объединяют данные (поля) и действия (методы) в единый объект. Класс - это шаблон, по которому создаются объекты

Пример класса:
```csharp
class Car // Создаем класс с помощью class
{
   // Поля (данные)
   public string brand;
   public string model;
   public int year;

   // Метод (действие)
   public void ShowInfo()
   {
      Console.WriteLine($"Авто: {brand} {model}, {year} года");
   }
}
```
Важно понимать, что класс - это не объект, а только его описание. Для создания объекта используем `new`

**Объект (Object)** - это экземпляр класса. У него есть данные (поля) и поведение (методы).

Пример создания объекта:

```csharp
Car myCar = new Car();
myCar.brand = "Toyota";
myCar.model = "Camry";
myCar.year = "2022";
myCar.ShowInfo() // Выведет: "Авто: Toyota Camry, 2022 года"
```

**Поля** - переменные, которые хранят состояние объекта
Пример полей и их использования:
```csharp
class Person
{
    public string name; // Поле класса (открытое)
    private int age;    // Приватное поле (скрытое от других классов)
}

Person person1 = new Person();
person1.name = "Андрей"; // Можно менять, так как public
person1.age = 30; // Ошибка, age – private
```
Для добавления поля да и любых других вещей внутри класса необходимо указать **модификатор доступа**\
Модификаторы доступа:\
**public** – поле доступно извне.\
**private** – поле доступно только внутри класса.\
**protected** – доступно в наследниках.

Приватные поля используются для инкапсуляции, а доступ к ним дается через свойства (`get`/`set`)

**Методы (функции внутри класса)** - по сути являются функциями, которые уникальны для каждого класса. Методы определяют поведение объекта. Они могут:
- Принимать параметры
- Возвращать значения
- Быть static (не требовать объекта)

Пример метода
```csharp
class MathOperations
{
    public int Sum(int a, int b)
    {
        return a + b; // Возвращает сумму
    }
}
```

**Конструктор (инициализатор объекта)** - специальный метод, который вызывается при создании объекта\
Его задача – задать начальные значения полям

Пример конструктора
```csharp
class Car
{
    public string Brand;
    public string Model;
    public int Year;

    // Конструктор
    public Car(string brand, string model, int year)
    {
        Brand = brand;
        Model = model;
        Year = year;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Авто: {Brand} {Model}, {Year} года");
    }
}
// Создание объекта с конструктором
Car myCar = new Car("Toyota", "Camry", 2022);
myCar.ShowInfo(); // Авто: Toyota Camry, 2022 года
```
Использование конструктора позволяет сократить количество используемого кода при создании объекта

#### Разница между `static` и нестатическими методами
Обычные методы требуют создания объекта, `static` методы можно вызывать без объекта
```csharp
class MathOperations
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

// Вызов без создания объекта
int result = MathOperations.Multiply(3, 4); // 12
```

**Наследование** - Один из главных принципов ООП, позволяющий одному классу (потомку) наследовать свойства и методы другого класса (родителя). Это помогает избежать дублирования кода и упростить его поддержку

Пример наследования (базовый класс Animal и класс-наследник Dog):

```csharp
class Animal
{
    public string Name { get; set; }
    
    public void Eat()
    {
        Console.WriteLine($"{Name} ест.");
    }
}

// Наследуем `Animal`
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine($"{Name} лает: Гав-гав!");
    }
}

// Использование
class Program
{
    static void Main()
    {
        Dog myDog = new Dog();
        myDog.Name = "Шарик";
        myDog.Eat();  // Шарик ест.
        myDog.Bark(); // Шарик лает: Гав-гав!
    }
}
```
Здесь класс Dog унаследовал Animal, поэтому Dog может использовать методы Eat() и поле Name, как если бы они были его собственными

##

*Все задачи необходимо выполнять в одном проекте*

**Практика А:**


1. Определение класса:
   Создайте класс Person с двумя полями: name и age. Напишите код для создания экземпляра класса и установите эти поля через прямое обращение к ним.

2. Добавление метода:
   Добавьте в класс Person метод Introduce, который будет печатать сообщение в консоль, вроде "Привет, мое имя [имя]".

3. Использование конструктора:
   Добавьте конструктор в класс Person, который позволит установить name и age при создании объекта.

4. Работа с массивами объектов:
   Создайте массив из объектов Person и используйте цикл для вызова метода Introduce для каждого элемента массива.


**Практика B:**

1. Cоздайте функцию внутри класса Person которая устанаивалиает значения для age осуществляя проверку на отрицательное значение.


**Практика C:**

1. Создайте класс Employee, который наследуется от Person и добавляет поле position.