namespace Proxy;
public class Server :IServer
{
    private string  Order { get; set; }
    public void TakeOrder(string order)
    {
        Console.WriteLine("Server takes order for " + order + ".");
        Order = order;
    }

    public string DeliverOrder()
    {
        return Order;
    }

    public void ProcessPayment(string payment)
    {
        Console.WriteLine("Payment for order (" + payment + ") processed.");
    }
}