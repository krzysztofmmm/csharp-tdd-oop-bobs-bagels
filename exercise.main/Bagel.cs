namespace exercise.main
{
    public class Bagel
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
        public Dictionary<string , float> Fillings { get; set; }
        public int DiscountQuantity { get; set; }
        public float DiscountPrice { get; set; }
        public List<Discount> Discounts { get; set; }

        public Bagel(int id , string sku , float price , string name , string variant)
        {
            Id = id;
            SKU = sku;
            Price = price;
            Name = name;
            Variant = variant;
            Fillings = new Dictionary<string , float>();
            Discounts = new List<Discount>();
        }

        public bool AddFilling(string filling , float cost)
        {
            if(!Fillings.ContainsKey(filling))
            {
                Fillings.Add(filling , cost);
                return true;
            }
            return false;
        }

        public bool RemoveFilling(string filling)
        {
            return Fillings.Remove(filling);
        }

        public float ViewCost()
        {
            return Price + Fillings.Values.Sum();
        }
    }
}
