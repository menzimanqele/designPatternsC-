namespace ChainOfResponsibility;

public class GeneralManager: Approver
{
    public override void ProcessRequest(PurchaseOrder purchaseOrder)
    {
        if (purchaseOrder.Price < 10000)
        {
            Console.WriteLine("{0} approved purchase request # {1}",this.GetType().Name, purchaseOrder.RequestNumber);
        }else 
        {
            Console.WriteLine(
                "Purchase request #{0} requires an executive meeting!",
            purchaseOrder.RequestNumber);
        }
    }
}