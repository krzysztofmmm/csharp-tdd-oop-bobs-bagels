namespace exercise.main
{
    public class CustomerBasket
    {
        public List<Bagel> Items { get; set; }
        public int Capacity { get; set; }
        public Dictionary<string , float> SpecialOffers { get; set; }
        public float Savings { get; private set; }

        public CustomerBasket()
        {
            Items = new List<Bagel>();
            Capacity = 10;
            SpecialOffers = new Dictionary<string , float>();
        }

        public Bagel AddItem(string sku , float price , string name , string variant)
        {
            if(Items.Count < Capacity)
            {
                var bagel = new Bagel(Items.Count + 1 , sku , price , name , variant);
                if(sku == "BGLO" || sku == "BGLE") // Add other SKUs as needed
                {
                    bagel.Discounts.Add(Discount.SixFor249);
                    bagel.Discounts.Add(Discount.TwelveFor399);
                }
                if(sku == "COFB")
                {
                    bagel.Discounts.Add(Discount.CoffeeAndBagel);
                }
                Items.Add(bagel);
                return bagel;
            }
            return null;
        }


        public bool RemoveItem(int id)
        {
            var bagel = Items.FirstOrDefault(b => b.Id == id);
            if(bagel != null)
            {
                Items.Remove(bagel);
                return true;
            }
            return false;
        }

        public List<Bagel> ViewBasket()
        {
            return Items;
        }

        #region private helpers
        private float ApplyDiscounts(Bagel bagel , int quantity)
        {
            float totalCost = 0;
            if(bagel.Discounts.Any())
            {
                foreach(var discount in bagel.Discounts.OrderByDescending(d => d.Quantity))
                {
                    if(quantity >= discount.Quantity)
                    {
                        int discountBundles = quantity / discount.Quantity;
                        totalCost += discountBundles * discount.Price;
                        quantity %= discount.Quantity;
                    }
                }
                totalCost += quantity * (bagel.Price + bagel.Fillings.Values.Sum());
            }
            else
            {
                totalCost += quantity * (bagel.Price + bagel.Fillings.Values.Sum());
            }
            return totalCost;
        }

        public float ApplySpecialOffers(float totalCost)
        {
            float originalCost = totalCost;
            // Check for "Coffee & Bagel for 1.25" special offer
            if(SpecialOffers.ContainsKey("COFB") && Items.Any(b => b.SKU == "BGLO" || b.SKU == "BGLE") && Items.Any(b => b.SKU == "COFB"))
            {
                totalCost = Math.Min(totalCost , SpecialOffers["COFB"]);
            }
            Savings = originalCost - totalCost; // Calculate savings
            return totalCost;
        }

        #endregion

        public float CalculateTotalCost()
        {
            float totalCost = 0;
            var groupedItems = Items.GroupBy(b => b.SKU);
            foreach(var group in groupedItems)
            {
                var bagel = group.First();
                int quantity = group.Count();
                totalCost += ApplyDiscounts(bagel , quantity);
            }
            totalCost = ApplySpecialOffers(totalCost);
            return totalCost;
        }




        public bool IsFull()
        {
            return Items.Count >= Capacity;
        }

        public bool ChangeCapacity(int newCapacity)
        {
            if(newCapacity >= 0)
            {
                Capacity = newCapacity;
                return true;
            }
            return false;
        }

        public bool AddSpecialOffer(string sku , float price)
        {
            if(!SpecialOffers.ContainsKey(sku))
            {
                SpecialOffers.Add(sku , price);
                return true;
            }
            return false;
        }

        public float CalculateSavings()
        {
            float totalSavings = 0;
            var groupedItems = Items.GroupBy(b => b.SKU);
            foreach(var group in groupedItems)
            {
                var bagel = group.First();
                int quantity = group.Count();
                float originalCost = quantity * (bagel.Price + bagel.Fillings.Values.Sum());
                float discountedCost = ApplyDiscounts(bagel , quantity);
                totalSavings += originalCost - discountedCost;
            }
            float totalCostAfterSpecialOffers = ApplySpecialOffers(totalSavings);
            totalSavings += totalSavings - totalCostAfterSpecialOffers;
            return totalSavings;
        }

    }
}
