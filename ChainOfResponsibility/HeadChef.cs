namespace ChainOfResponsibility;

public class HeadChef : Approver
{
    public override void ProcessRequest(PurchaseOrder purchaseOrder)
    {
        ArgumentNullException.ThrowIfNull(purchaseOrder);
        if (purchaseOrder.Price < 1000)
        {
            Console.WriteLine("{0} approved purchase request # {1}",this.GetType().Name, purchaseOrder.RequestNumber);
        }else if (nextApprover != null)
        {
            nextApprover.ProcessRequest(purchaseOrder);
        }
    }
}