namespace exercise.main
{
    public class Bagel
    {
        public int Id { get; set; }
        public string SKU { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }
        public string Variant { get; set; }
        public List<string> Fillings { get; set; }

        public Bagel(int id , string sku , float price , string name , string variant)
        {
            Id = id;
            SKU = sku;
            Price = price;
            Name = name;
            Variant = variant;
            Fillings = new List<string>();
        }

        public bool AddFilling(string filling)
        {
            if(!Fillings.Contains(filling))
            {
                Fillings.Add(filling);
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
            return Price;
        }
    }
}

