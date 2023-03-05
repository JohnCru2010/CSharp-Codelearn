using System;

class Program
{
    static void Main(string[] args)
    {
        Vehicle vehicle1 = new Vehicle();
        Vehicle vehicle2 = new Vehicle();
        Vehicle vehicle3 = new Vehicle();
        Console.Write("Insert first vehicle brand: ");
        vehicle1.Brand = Console.ReadLine();
        Console.Write("Insert first vehicle color: ");
        vehicle1.Color = Console.ReadLine();
        Console.Write("Insert first vehicle model: ");
        vehicle1.Model = Console.ReadLine();
        Console.Write("Insert second vehicle brand: ");
        vehicle2.Brand = Console.ReadLine();
        Console.Write("Insert second vehicle color: ");
        vehicle2.Color = Console.ReadLine();
        Console.Write("Insert second vehicle model: ");
        vehicle2.Model = Console.ReadLine();
        Console.Write("Insert third vehicle brand: ");
        vehicle3.Brand = Console.ReadLine();
        Console.Write("Insert third vehicle color: ");
        vehicle3.Color = Console.ReadLine();
        Console.Write("Insert third vehicle model: ");
        vehicle3.Model = Console.ReadLine();

        if (vehicle1.Color == "Red") {
            Console.WriteLine("Vehicle information:");
            Console.WriteLine("Brand: " + vehicle1.Brand);
            Console.WriteLine("Model: " + vehicle1.Model);
            Console.WriteLine("Color: " + vehicle1.Color);
        } else if (vehicle2.Color == "Red") 
        {
            Console.WriteLine("Vehicle information:");
            Console.WriteLine("Brand: " + vehicle1.Brand);
            Console.WriteLine("Model: " + vehicle1.Model);
            Console.WriteLine("Color: " + vehicle1.Color);
        } else
        {
            Console.WriteLine("Vehicle information:");
            Console.WriteLine("Brand: " + vehicle1.Brand);
            Console.WriteLine("Model: " + vehicle1.Model);
            Console.WriteLine("Color: " + vehicle1.Color);
        }
    }
    public class Vehicle
    {
        private String brand;
        private String color;
        private String model;
        public String Brand
        {
            get {
                return brand;
            }
            set {
                brand = value;
            }
        }
        public String Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public String Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
    }
}