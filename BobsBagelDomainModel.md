Classes:
Bagel
CustomerBasket
Inventory

Structs:
BagelData

Properties:
Bagel: Id (int), Data (BagelData), Fillings (List of BagelData)
CustomerBasket: Items (List of Bagel), Capacity (int)
Inventory: Items (List of BagelData)

Methods:
Bagel: AddFilling(BagelData filling) (bool), RemoveFilling(BagelData filling) (bool), ViewCost() (float)
CustomerBasket: AddBagel(BagelData data) (Bagel), RemoveBagel(int id) (bool), ViewBasket() (List of Bagel), 
CalculateTotalCost() (float), IsFull() (bool), ChangeCapacity(int newCapacity) (bool)
Inventory: GetBagel(string sku) (BagelData), UpdateInventory(BagelData bagel) (bool)
//Updated Domain Model