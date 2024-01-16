namespace exercise.main
{
    public class Inventory
    {
        private static Inventory _instance;
        public static Inventory Instance => _instance ??= new Inventory();

        public List<Bagel> Items { get; set; }

        public Inventory()
        {
            Items = new List<Bagel>();
        }

        public Bagel GetItem(string sku)
        {
            return Items.FirstOrDefault(b => b.SKU == sku);
        }

        public bool UpdateInventory(Bagel bagel)
        {
            if(!Items.Any(b => b.SKU == bagel.SKU))
            {
                Items.Add(bagel);
                return true;
            }
            return false;
        }
    }
}
