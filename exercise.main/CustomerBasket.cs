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

        public Bagel AddBagel(string sku , float price , string name , string variant)
        {
            if(Items.Count < Capacity)
            {
                var bagel = new Bagel(Items.Count + 1 , sku , price , name , variant);
                Items.Add(bagel);
                return bagel;
            }
            return null;
        }

        public bool RemoveBagel(int id)
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

        public float CalculateTotalCost()
        {
            return Items.Sum(b => b.ViewCost());
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
    }
}
