using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class BasketTest
    {
        private CustomerBasket _customerBasket;
        private Bagel _bagel;
        private Inventory _inventory;

        [SetUp]
        public void Setup()
        {
            _customerBasket = new CustomerBasket();
            _inventory = Inventory.Instance;
            _bagel = new Bagel("BGLO" , 0.49f , "Bagel" , "Onion");
            _inventory.UpdateInventory(_bagel);
        }

        [TestCase("BGLO" , 0.49f , "Bagel" , "Onion")]
        [TestCase("BGLP" , 0.39f , "Bagel" , "Plain")]
        [TestCase("BGLE" , 0.49f , "Bagel" , "Everything")]
        [TestCase("BGLS" , 0.49f , "Bagel" , "Sesame")]
        [TestCase("COFB" , 0.99f , "Coffee" , "Black")]
        public void TestAddItem(string sku , float price , string name , string variant)
        {
            _bagel = new Bagel(sku , price , name , variant);
            _inventory.UpdateInventory(_bagel);
            Assert.IsTrue(_customerBasket.AddItem(_bagel.SKU));
        }

        [Test]
        public void TestRemoveItem()
        {
            _customerBasket.AddItem(_bagel.SKU);
            Assert.IsTrue(_customerBasket.RemoveItem(_bagel.SKU));
        }

        [Test]
        public void TestViewBasket()
        {
            _customerBasket.AddItem(_bagel.SKU);
            CollectionAssert.Contains(_customerBasket.ViewBasket() , _bagel);
        }


        [Test]
        public void TestCalculateTotalCost()
        {
            _customerBasket.AddItem(_bagel.SKU);
            Assert.AreEqual(0.49f , _customerBasket.CalculateTotalCost());
        }

        [Test]
        public void TestIsFullWhenNotFull()
        {
            Assert.IsFalse(_customerBasket.IsFull());
        }

        [Test]
        public void TestIsFullWhenFull()
        {
            _customerBasket.Capacity = 1;
            _customerBasket.AddItem(_bagel.SKU);
            Assert.IsTrue(_customerBasket.IsFull());
        }


        [Test]
        public void TestAddFilling()
        {
            Assert.IsTrue(_bagel.AddFilling("Cheese"));
        }

        [Test]
        public void TestRemoveFilling()
        {
            _bagel.AddFilling("Cheese");
            Assert.IsTrue(_bagel.RemoveFilling("Cheese"));
        }

        [Test]
        public void TestRemoveFillingNotInBagel()
        {
            Assert.IsFalse(_bagel.RemoveFilling("Cheese"));
        }

        [Test]
        public void TestViewCost()
        {
            Assert.AreEqual(0.49f , _bagel.ViewCost());
        }
    }
}