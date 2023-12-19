using System;

class Vehicle
{
    public string Name { get; set; }

    public Vehicle(string name)
    {
        Name = name;
    }

    public virtual void StartEngine()
    {
        Console.WriteLine($"Заводим~ мотор транспорта: {Name}");
    }
}

class LandVehicle : Vehicle
{
    public LandVehicle(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Сухопутный транспорт готов к движению!");
    }
}

class WaterVehicle : Vehicle
{
    public WaterVehicle(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Водный транспорт готов к плаванию.");
    }
}

class Submarine : WaterVehicle
{
    public Submarine(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Подводный транспорт погружается в воду моей будущей курсовой работы.");
    }
}

class AirVehicle : Vehicle
{
    public AirVehicle(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Воздушный транспорт готов к взлету!");
    }
}

class UndergroundVehicle : Vehicle
{
    public UndergroundVehicle(string name) : base(name)
    {
    }

    public override void StartEngine()
    {
        base.StartEngine();
        Console.WriteLine("Подземный транспорт начинает движение под землей.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[]
        {
            new LandVehicle("Автомобиль KEKW"),
            new WaterVehicle("Лодка"),
            new Submarine("Подводная лодка"),
            new AirVehicle("Самолет"),
            new UndergroundVehicle("Поезд KEKW метро")
        };

        foreach (var vehicle in vehicles)
        {
            vehicle.StartEngine();
            Console.WriteLine();
        }

        Console.ReadLine();
    }
}
