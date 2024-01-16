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
            _bagel = new Bagel(1 , "BGLO" , 0.49f , "Bagel" , "Onion");
            _inventory.UpdateInventory(_bagel);
        }

        [Test]
        public void TestAddBagel()
        {
            _bagel = _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            Assert.IsNotNull(_bagel);
        }

        [Test]
        public void TestRemoveBagel()
        {
            _bagel = _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            Assert.IsTrue(_customerBasket.RemoveItem(_bagel.Id));
        }

        [Test]
        public void TestViewBasket()
        {
            _bagel = _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            CollectionAssert.Contains(_customerBasket.ViewBasket() , _bagel);
        }

        [Test]
        public void TestCalculateTotalCost()
        {
            _bagel = _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
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
            _customerBasket.ChangeCapacity(1);
            _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            Assert.IsTrue(_customerBasket.IsFull());
        }

        [Test]
        public void TestAddFilling()
        {
            Assert.IsTrue(_bagel.AddFilling("Cheese" , 0.19f));
        }

        [Test]
        public void TestRemoveFilling()
        {
            _bagel.AddFilling("Cheese" , 0.19f);
            Assert.IsTrue(_bagel.RemoveFilling("Cheese"));
        }
    }
}
