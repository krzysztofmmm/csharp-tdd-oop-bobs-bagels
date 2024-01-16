namespace exercise.main
{
    public class Bagel
    {
        public string SKU { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
        public List<string> Fillings { get; set; }

        public Bagel(string sku , float price , string name , string variant)
        {
            SKU = sku;
            Price = price;
            Name = name;
            Variant = variant;
            Fillings = new List<string>();
        }

        public bool AddFilling(string filling)
        {
            Fillings.Add(filling);
            return true;
        }

        public bool RemoveFilling(string filling)
        {
            return Fillings.Remove(filling);
        }

        public float ViewCost()
        {
            return Price;
        }
    }
}
