namespace ChainOfResponsibility;


/// <summary>
/// The Handler abstract class.
/// Every class which inherits from this will be responsible
/// for a kind 
public abstract class Approver
{
    protected Approver nextApprover;

    public void SetNextApprover(Approver nextApprover)
    {
        this.nextApprover = nextApprover;
    }

    public abstract void ProcessRequest(PurchaseOrder purchaseOrder);
}