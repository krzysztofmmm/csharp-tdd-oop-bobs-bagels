Extension 1 

Classes:

Bagel
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

Extension 2

Classes:

Bagel
CustomerBasket
Inventory
Discount
Receipt
Properties:

Bagel: Id (int), SKU (string), Price (float), Name (string), Variant (string), 
Fillings (Dictionary<string, float>), Discounts (List<Discount>)
CustomerBasket: Items (List<Bagel>), Capacity (int), 
SpecialOffers (Dictionary<string, float>)
Inventory: Items (List<Bagel>), Fillings (List<Filling>)
Discount: Quantity (int), Price (float)
Receipt: Date (DateTime), Items (List<Bagel>), Total (float)
Methods:

Bagel: AddFilling(string filling, float price) (bool), RemoveFilling(string filling) (bool), ViewCost() (float)
CustomerBasket: AddItem(string sku, float price, string name, string variant) (Bagel), RemoveItem(int id) (bool), ViewBasket() (List<Bagel>), CalculateTotalCost() (float), IsFull() (bool), ChangeCapacity(int newCapacity) (bool), AddSpecialOffer(string sku, float price) (bool)
Inventory: GetItem(string sku) (Bagel), UpdateInventory(Bagel bagel) (bool), GetFilling(string sku) (Filling), UpdateInventory(Filling filling) (bool)
Receipt: PrintReceipt()


Extension 3

Classes: 

Bagel
CustomerBasket
Inventory
Discount
Receipt
Savings

Properties:

Bagel: Id (int), SKU (string), Price (float), Name (string), Variant (string), 
Fillings (Dictionary<string, float>), Discounts (List<Discount>)
CustomerBasket: Items (List<Bagel>), Capacity (int), SpecialOffers (Dictionary<string, float>)
Inventory: Items (List<Bagel>)
Discount: Quantity (int), Price (float)
Receipt: Date (DateTime), Items (List<Bagel>), Total (float)
Savings: TotalSavings (float), ItemSavings (Dictionary<string, float>)
Methods:
Bagel: AddFilling(string filling, float price) (bool), RemoveFilling(string filling) (bool), ViewCost() (float)
CustomerBasket: AddItem(string sku, float price, string name, string variant) (Bagel),
RemoveItem(int id) (bool), ViewBasket() (List<Bagel>), 
CalculateTotalCost() (float), IsFull() (bool), ChangeCapacity(int newCapacity) (bool), 
AddSpecialOffer(string sku, float price) (bool)
Inventory: GetItem(string sku) (Bagel), UpdateInventory(Bagel bagel) (bool)
Receipt: PrintReceipt()
Savings: CalculateTotalSavings() (float), CalculateItemSavings(string sku) (float)
