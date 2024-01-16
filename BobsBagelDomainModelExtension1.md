Classes:

Bagel
Filling
CustomerBasket
Inventory
Discount
SpecialOffer

Properties:

Bagel: Id (int), SKU (string), Price (float), Name (string), Variant (string), Fillings (List of Filling)
Filling: SKU (string), Price (float), Name (string)
CustomerBasket: Items (List of Bagel), Capacity (int)
Inventory: Items (List of Bagel), Fillings (List of Filling)
Discount: Quantity (int), Price (float)
SpecialOffer: SKU (string), Price (float)

Methods:

Bagel: AddFilling(Filling filling) (bool), RemoveFilling(Filling filling) (bool), ViewCost() (float)
CustomerBasket: AddBagel(string sku) (Bagel), RemoveBagel(int id) (bool), ViewBasket() (List of Bagel), CalculateTotalCost() (float), IsFull() (bool), 
ChangeCapacity(int newCapacity) (bool)
Inventory: GetBagel(string sku) (Bagel), UpdateInventory(Bagel bagel) (bool), GetFilling(string sku) (Filling), UpdateInventory(Filling filling) (bool)
Discount: ApplyDiscount(int quantity, float price) (float)
SpecialOffer: ApplySpecialOffer(string sku, float price) (float)