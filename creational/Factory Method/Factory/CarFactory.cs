using creational.Factory_Method.Abstract_Class;
using creational.Factory_Method.Concrete_Classes;

namespace creational.Factory_Method.Factory;

public class CarFactory
{
    public static Car GetCar(string carType)
    {
        switch (carType)
        {
            case "Sedan":
                return new Sedan();
            case "SUV":
                return new SUV();
            case "Truck":
                return new Truck();
            default:
                return null;
        }
    }
}