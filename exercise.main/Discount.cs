namespace exercise.main
{
    public class Discount
    {
        public int Quantity { get; set; }
        public float Price { get; set; }

        public Discount(int quantity , float price)
        {
            Quantity = quantity;
            Price = price;
        }

        public static Discount SixFor249 = new Discount(6 , 2.49f);
        public static Discount TwelveFor399 = new Discount(12 , 3.99f);
        public static Discount CoffeeAndBagel = new Discount(2 , 1.25f);

    }

}
