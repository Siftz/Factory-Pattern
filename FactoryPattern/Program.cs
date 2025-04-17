namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of tires on the vehicle. ");
            if (int.TryParse(Console.ReadLine(), out int numbernumberOfTires))
            {
                try
                {
                    IVehicle vehicle = VehicleFactory.GetVehicle(numbernumberOfTires);
                    vehicle.Drive();
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Invalid input. PLease enter a valid number.");
            }
        }
    }
}
