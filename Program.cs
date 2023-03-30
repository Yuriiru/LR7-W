﻿abstract class Transport
{
    public abstract int speed { get; set; }
    public abstract int load_capacity { get; set; }
    public abstract int distance { get; set; }

    public abstract int speed2();
    public abstract int load_capacity2();
    public abstract int distance2();
}

abstract class Car : Transport
{
    public override int speed2() { return speed; }
    public override int distance2() { return load_capacity; }
    public override int load_capacity2() { return distance; }
}

abstract class Plane : Transport
{
    public override int speed2() { return speed; }
    public override int distance2() { return load_capacity; }
    public override int load_capacity2() { return distance; }
}
abstract class Ship : Transport
{
    public override int speed2() { return speed; }
    public override int distance2() { return load_capacity; }
    public override int load_capacity2() { return distance; }
}

class Porshe : Car
{
    public override int speed { get; set; }
    public override int load_capacity { get; set; }
    public override int distance { get; set; }

    public override int speed2()
    {
        Console.Write("скорость Porshe: ");
        return speed;

    }
    public override int load_capacity2()
    {
        Console.Write("грузоподъемность Porshe: ");
        return load_capacity;
    }

    public override int distance2()
    {
        Console.Write("дальность расстояния Porshe: ");
        return distance;
    }

}
class Boeing_777 : Plane
{
    public override int speed { get; set; }
    public override int load_capacity { get; set; }
    public override int distance { get; set; }

    public override int speed2()
    {
        Console.Write("скорость Boeing 777: ");
        return speed;

    }
    public override int load_capacity2()
    {
        Console.Write("грузоподъемность Boeing 777: ");
        return load_capacity;
    }

    public override int distance2()
    {
        Console.Write("дальность расстояния Boeing 777: ");
        return distance;
    }

}
class Mustai_Karim : Ship
{
    public override int speed { get; set; }
    public override int load_capacity { get; set; }
    public override int distance { get; set; }

    public override int speed2()
    {
        Console.Write("скорость Mustai Karim: ");
        return speed;

    }
    public override int load_capacity2()
    {
        Console.Write("грузоподъемность Mustai Karim: ");
        return load_capacity;
    }

    public override int distance2()
    {
        Console.Write("дальность расстояния Mustai Karim: ");
        return distance;
    }

}

internal class Program
{
    static void Main(string[] args)
    {
        Porshe volkswagen = new Porshe();
        volkswagen.speed = 160;

        Console.Write(volkswagen.speed2());
        Console.WriteLine(" км/ч");
        volkswagen.load_capacity = 120;
        Console.Write(volkswagen.load_capacity2());
        Console.WriteLine(" кг");
        volkswagen.distance = 800000;
        Console.Write(volkswagen.distance2());
        Console.WriteLine(" км \n");

        Boeing_777 airplane = new Boeing_777();
        airplane.speed = 600;
        Console.Write(airplane.speed2());
        Console.WriteLine(" км/ч");
        airplane.load_capacity = 10000;
        Console.Write(airplane.load_capacity2());
        Console.WriteLine(" кг");
        airplane.distance = 1000000;
        Console.Write(airplane.distance2());
        Console.WriteLine(" км \n");

        Mustai_Karim titanic = new Mustai_Karim();
        titanic.speed = 100;
        Console.Write(titanic.speed2());
        Console.WriteLine(" км/ч");
        titanic.load_capacity = 100000;
        Console.Write(titanic.load_capacity2());
        Console.WriteLine(" кг");
        titanic.distance = 100000;
        Console.Write(titanic.distance2());
        Console.WriteLine(" км \n");

    }
}
