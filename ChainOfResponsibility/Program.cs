//create the chain links

using ChainOfResponsibility;

Approver headChef = new HeadChef();
Approver purchasingManager = new PurchasingManager();
Approver generalManager = new GeneralManager();

//create the chains

headChef.SetNextApprover(purchasingManager);
purchasingManager.SetNextApprover(generalManager);

//generate and process the purchase requests 

PurchaseOrder purchaseOrder = new PurchaseOrder(1, 20, 69,
"Spices");
headChef.ProcessRequest(purchaseOrder);

purchaseOrder = new PurchaseOrder(2, 300, 1389,
    "Veggies");
headChef.ProcessRequest(purchaseOrder);

purchaseOrder = new PurchaseOrder(3, 500, 4889,
    "Beef");    
    
headChef.ProcessRequest(purchaseOrder);

purchaseOrder = new PurchaseOrder(4, 500, 12099,
    "Oven");    
headChef.ProcessRequest(purchaseOrder);

Console.ReadKey();