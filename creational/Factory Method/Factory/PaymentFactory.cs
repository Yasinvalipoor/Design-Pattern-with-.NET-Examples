using creational.Factory_Method.Abstract_Class.e.g._2;
using creational.Factory_Method.Concrete_Classes.e.g._2;

namespace creational.Factory_Method.Factory;

public class PaymentFactory 
{
    public static ProcessPayment GetInstancePayment(string paymentType)
    {
        return paymentType.ToLowerInvariant() switch
        {
            "creditcard" => new CreditCard(),
            "paypal" => new PayPal(),
            "cashondelivery" => new CashOnDelivery(),
            "cryptocurrency" => new CryptoCurrency(),
            _ => throw new ArgumentException($"Invalid payment type: {paymentType}")
        };
    }
}