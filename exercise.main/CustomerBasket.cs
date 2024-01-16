namespace exercise.main
{
    public class CustomerBasket
    {
        public List<Bagel> Items { get; set; }
        public int Capacity { get; set; }

        public CustomerBasket()
        {
            Items = new List<Bagel>();
            Capacity = 10;  // Set a default capacity
        }

        public bool AddItem(string sku)
        {
            if(Items.Count < Capacity)
            {
                var bagel = Inventory.Instance.GetBagel(sku);
                if(bagel != null)
                {
                    Items.Add(bagel);
                    return true;
                }
            }
            return false;
        }

        public bool RemoveItem(string sku)
        {
            var bagel = Items.FirstOrDefault(b => b.SKU == sku);
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

        public float CalculateTotalCost()
        {
            return Items.Sum(b => b.ViewCost());
        }

        public bool IsFull()
        {
            return Items.Count >= Capacity;
        }
    }
}
