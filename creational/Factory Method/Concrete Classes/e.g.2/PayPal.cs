using creational.Factory_Method.Abstract_Class.e.g._2;

namespace creational.Factory_Method.Concrete_Classes.e.g._2;

public class PayPal : ProcessPayment
{
    public override void Payment(decimal amount)
    {
        Console.WriteLine($"Paid {amount} using PayPal.");
    }
}
