namespace exercise.main
{
    public class Receipt
    {
        public DateTime Date { get; set; }
        public List<Bagel> Items { get; set; }
        public float Total { get; set; }
        public float Savings { get; set; }

        public Receipt(CustomerBasket basket)
        {
            Date = DateTime.Now;
            Items = basket.Items;
            Total = basket.CalculateTotalCost();
            Savings = basket.Savings;
        }


        public void PrintReceipt()
        {
            Console.WriteLine("~~~ Bob's Bagels ~~~");
            Console.WriteLine(Date.ToString("yyyy-MM-dd HH:mm:ss"));
            Console.WriteLine("----------------------------");
            foreach(var item in Items.GroupBy(item => item.SKU))
            {
                Console.WriteLine($"{item.First().Name} {item.Count()} £{item.Sum(i => i.ViewCost()):0.00}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Total {Total:0.00}");
            Console.WriteLine($"You saved a total of {Savings:0.00} on this shop");
            Console.WriteLine("\nThank you\nfor your order!");
        }
    }
}
