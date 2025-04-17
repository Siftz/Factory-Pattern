namespace FactoryPattern;

public class BigRig : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new BigRig!");
    }
}