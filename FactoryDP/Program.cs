
// Amir Moeini Rad
// September 2025

// The Factory Method Design Pattern

// In this pattern, we create objects without exposing the instantiation logic to the client.
// The client uses a common interface to create new types of objects.

namespace FactoryDP
{    
    // Product
    abstract class Product
    {
        public abstract void ShowInfo();
    }

        
    class ConcreteProductA : Product
    {
        public override void ShowInfo() => Console.WriteLine("I am Product A.\n");
    }

    
    class ConcreteProductB : Product
    {
        public override void ShowInfo() => Console.WriteLine("I am Product B.\n");
    }


    // Factory
    abstract class Creator
    {
        public abstract Product CreateProduct();
    }


    class CreatorA : Creator
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("CreatorA is creating ProductA...");
            return new ConcreteProductA();
        }
    }


    class CreatorB : Creator
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("CreatorB is creating ProductB...");
            return new ConcreteProductB();
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("The Factory Method Design Pattern in C#.NET.");
            Console.WriteLine("--------------------------------------------\n");                        

            Console.WriteLine("In Client...\n");

            Creator creator = new CreatorA();
            Product productA = creator.CreateProduct();
            productA.ShowInfo();

            creator = new CreatorB();
            Product productB = creator.CreateProduct();
            productB.ShowInfo();

            Console.WriteLine("Done.");
        }
    }
}
