using System;

namespace AbstractFactoryDesignPattern
{
    class Program
    {
        public static void Main(string[] args)
        {
           AbstractFactory factory1 = new ConcreteFactory1();
           Cliente cliente1 = new Cliente(factory1);
           cliente1.Run();

           AbstractFactory factory2 = new ConcreteFactory2();
           Cliente cliente2 = new Cliente(factory2);
           cliente2.Run();

           Console.ReadKey();
        }
    }
}
