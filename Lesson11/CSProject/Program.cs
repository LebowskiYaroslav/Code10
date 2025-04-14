﻿﻿public delegate double MathOperation(double x, double y);

class TemperatureSensor
{
    private double _temperature;
    
    public double Temperature
    {
        return _temperature;
    }
    
    public event EventHandler TemperatureChanged;
    
    public void UpdateTemperature(double newTemperature)
    {
        if (newTemperature != _temperature)
        {
            _temperature = newTemperature;
            TemperatureChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}

class Stock
{
    private double _price;
    
    public double Price
    {
        return _price; 
    }
    
    public event EventHandler PriceChanged;
    
    public void ChangePrice(double newPrice)
    {
        if (newPrice != _price)
        {
            _price = newPrice;
            PriceChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
class Program
{
    public static double Add(double x, double y){
        return x + y;
    }

    public static double Multiply(double x, double y){
        return x * y;
    }

    public static void ExecuteOperation(MathOperation operation, double x, double y){
        operation(x, y);
    }
    static void Main()
    {
        MathOperation handler = Multiply;
        double i = ExecuteOperation(handler, 5, 5);
        Console.WriteLine(i);
        handler = Add;
        i = ExecuteOperation(handler, 5, 5);
        Console.WriteLine(i);
        
        var sensor = new TemperatureSensor();
        sensor.TemperatureChanged += (sender, args) => 
        {
            Console.WriteLine($"Температура изменилась на {sensor.Temperature}°C");
        };
        
        sensor.UpdateTemperature(20.5);
        sensor.UpdateTemperature(20.5); 
        sensor.UpdateTemperature(22.1);

        var stock = new Stock();
        
        stock.PriceChanged += (sender, args) => 
        {
            Console.WriteLine($"Цена изменилась на {stock.Price}$");
        };
        
        stock.PriceChanged += (sender, args) => 
        {
            Console.WriteLine($"Уведомление, цена изменилась на {stock.Price}$");
        };
        
        stock.ChangePrice(120.50);
        stock.ChangePrice(120.50); 
        stock.ChangePrice(125.75);
    }
}
