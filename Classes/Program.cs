namespace Classes
{

    
    
    public class Program
    {
        static void Main(string[] args)
        {
            Car someCar = new Car();

            someCar.Make = "Toyota";
            someCar.Model = "Camry";
            someCar.Year = 2000;
            
            Console.WriteLine(someCar.Make);
            Console.WriteLine(someCar.Model);
            Console.WriteLine(someCar.Year);
        }
    }
}
