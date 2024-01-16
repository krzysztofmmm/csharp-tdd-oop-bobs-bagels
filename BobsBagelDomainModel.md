Classes
1. CustomerBasket
2. Bagel
3. Manager

Properties
1. CustomerBasket, items (List of Bagel), capacity (int), total_cost (float)
2. Bagel, SKU (string), price (float), name (string), variant (string), fillings (List of string)
3. Manager, inventory (List of Bagel)

Methods
1. CustomerBasket, 
    - addItem(sku, string), bool
    - removeItem(sku, string), bool
    - viewBasket(), List of Bagel
    - calculateTotal_cost(), float
    - isFull(), bool
2. Bagel, 
    - addFilling(filling, string), bool
    - removeFilling(filling, string), bool
    - viewCost(), float
3. Inventory, 
    - changeBasketCapacity(new_capacity, int), bool
    - updateInventory(sku, string), bool
//Previous Domain Model
    

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