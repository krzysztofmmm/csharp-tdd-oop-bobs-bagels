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
