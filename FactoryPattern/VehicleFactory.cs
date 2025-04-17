namespace FactoryPattern;

public class VehicleFactory
{
    public static IVehicle GetVehicle(int numberOfTires)
    {
        return numberOfTires switch
        {
            2 => new Motorcycle(),
            4 => new Car(),
            18 => new BigRig(),
            _ => throw new ArgumentException("Invalid number of tires provided.")
        };
    }
}