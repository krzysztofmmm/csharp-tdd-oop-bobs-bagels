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

_____________________________________________________________________________________________________________________________________________________________________________________
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

_____________________________________________________________________________________________________________________________________________________________________________________
Extension 3

Class: Bagel

Properties: Id (int), SKU (string), Price (float), Name (string), Variant (string), Fillings (Dictionary<string, float>), Discounts (List<Discount>)
Methods:
AddFilling(string filling, float price): Adds a filling to the bagel. Returns true if the filling was successfully added, false otherwise.
RemoveFilling(string filling): Removes a filling from the bagel. Returns true if the filling was successfully removed, false otherwise.
ViewCost(): Returns the cost of the bagel as a float.
Class: CustomerBasket

Properties: Items (List<Bagel>), Capacity (int), SpecialOffers (Dictionary<string, float>), Savings (float)
Methods:
AddItem(string sku, float price, string name, string variant): Adds an item to the basket. Returns the added Bagel object.
RemoveItem(int id): Removes an item from the basket by its id. Returns true if the item was successfully removed, false otherwise.
ViewBasket(): Returns a list of Bagel objects representing the items in the basket.
CalculateTotalCost(): Returns the total cost of the items in the basket as a float.
IsFull(): Returns true if the basket is full, false otherwise.
ChangeCapacity(int newCapacity): Changes the capacity of the basket. Returns true if the capacity was successfully changed, false otherwise.
AddSpecialOffer(string sku, float price): Adds a special offer to the basket. Returns true if the special offer was successfully added, false otherwise.
ApplySpecialOffers(float totalCost): Applies special offers to the total cost. Returns the total cost after applying the special offers.
Class: Inventory

Properties: Items (List<Bagel>)
Methods:
GetItem(string sku): Returns a Bagel object representing the item with the given SKU.
UpdateInventory(Bagel bagel): Updates the inventory with a new bagel. Returns true if the inventory was successfully updated, false otherwise.
Class: Discount

Properties: Quantity (int), Price (float)
Class: Receipt

Properties: Date (DateTime), Items (List<Bagel>), Total (float), Savings (float)
Methods:
PrintReceipt(): Prints the receipt. Does not return a value.
_____________________________________________________________________________________________________________________________________________________________________________________

Extension 4


Class: Bagel

Properties: Id (int), SKU (string), Price (float), Name (string), Variant (string), Fillings (Dictionary<string, float>), Discounts (List<Discount>)
Methods:
AddFilling(string filling, float price): Adds a filling to the bagel. Returns true if the filling was successfully added, false otherwise.
RemoveFilling(string filling): Removes a filling from the bagel. Returns true if the filling was successfully removed, false otherwise.
ViewCost(): Returns the cost of the bagel as a float.

Class: CustomerBasket

New Properties: SmsNotifier (SMSNotifier), CustomerPhoneNumber (string)
Properties: Items (List<Bagel>), Capacity (int), SpecialOffers (Dictionary<string, float>), Savings (float)

New Methods: CompleteOrder() -> returns true or false wheter the action was succesfull
Methods:
AddItem(string sku, float price, string name, string variant): Adds an item to the basket. Returns the added Bagel object.
RemoveItem(int id): Removes an item from the basket by its id. Returns true if the item was successfully removed, false otherwise.
ViewBasket(): Returns a list of Bagel objects representing the items in the basket.
CalculateTotalCost(): Returns the total cost of the items in the basket as a float.
IsFull(): Returns true if the basket is full, false otherwise.
ChangeCapacity(int newCapacity): Changes the capacity of the basket. Returns true if the capacity was successfully changed, false otherwise.
AddSpecialOffer(string sku, float price): Adds a special offer to the basket. Returns true if the special offer was successfully added, false otherwise.
ApplySpecialOffers(float totalCost): Applies special offers to the total cost. Returns the total cost after applying the special offers.

Class: Inventory

Properties: Items (List<Bagel>)
Methods:
GetItem(string sku): Returns a Bagel object representing the item with the given SKU.
UpdateInventory(Bagel bagel): Updates the inventory with a new bagel. Returns true if the inventory was successfully updated, false otherwise.
Class: Discount

Properties: Quantity (int), Price (float)
Class: Receipt

Properties: Date (DateTime), Items (List<Bagel>), Total (float), Savings (float)
Methods:
PrintReceipt(): Prints the receipt. Does not return a value.

Class: 

SMSNotifier: This class is responsible for sending SMS notifications. It uses the Twilio API to send SMS messages.

Properties: accountSid (string), authToken (string), fromPhoneNumber (string)
Methods: SendSMS(toPhoneNumber: string, message: string)