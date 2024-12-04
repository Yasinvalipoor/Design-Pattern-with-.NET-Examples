using creational.Factory_Method.Abstract_Class;

namespace creational.Factory_Method.Concrete_Classes;

public class Truck : Car
{
    public override string GetType()
    {
        return "Truck";
    }
}
