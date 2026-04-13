
// Amir Moeini Rad
// September 2025

// Main Concept: The Factory Method Design Pattern

// In this pattern, we create objects without exposing the instantiation logic to the client.
// The client uses a common interface to create new types of objects.
// This design pattern can be implemented using both interfaces or abstract classes.


namespace FactoryDP
{
    // The 'Product' abstract class
    abstract class Product
    {
        public abstract void ShowInfo();
    }

    
    // The 'ConcreteProduct' class
    class ConcreteProductA : Product
    {
        public override void ShowInfo() => Console.WriteLine("I am Product A.\n");
    }


    // The 'ConcreteProduct' class
    class ConcreteProductB : Product
    {
        public override void ShowInfo() => Console.WriteLine("I am Product B.\n");
    }


    /////////////////////////////////////////////////


    // Factory Class and Method
    abstract class Creator
    {
        public abstract Product CreateProduct();
    }


    // Concrete Creators
    class CreatorA : Creator
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("CreatorA is creating ProductA...");

            return new ConcreteProductA();
        }
    }


    // Concrete Creators
    class CreatorB : Creator
    {
        public override Product CreateProduct()
        {
            Console.WriteLine("CreatorB is creating ProductB...");

            return new ConcreteProductB();
        }
    }


    /////////////////////////////////////////////////


    // The Main Program
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("The Factory Method Design Pattern in C#.NET.");
            Console.WriteLine("--------------------------------------------\n");


            // The Factory Method lets subclasses decide which object to create.
            // In fact, the client doesn't directly instantiate or create products.
            // CreatorA produces ProductA, CreatorB produces ProductB.
            // Client code (Main) doesn’t care about the concrete class — just calls the factory.
            // This promotes loose coupling and adheres to the Open/Closed Principle (SOLID).

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
