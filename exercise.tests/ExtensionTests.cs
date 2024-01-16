using exercise.main;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionsTests
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
        public void TestAddFillingToItem()
        {
            Assert.IsTrue(_bagel.AddFilling("Cheese" , 0.12f));
        }

        [Test]
        public void TestRemoveFillingFromItem()
        {
            _bagel.AddFilling("Cheese" , 0.12f);
            Assert.IsTrue(_bagel.RemoveFilling("Cheese"));
        }

        [Test]
        public void TestApplyDiscount()
        {
            for(int i = 0;i < 6;i++)
            {
                _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            }
            Assert.AreEqual(2.49f , _customerBasket.CalculateTotalCost());
        }

        [Test]
        public void TestApplySpecialOffer()
        {
            _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            _customerBasket.AddSpecialOffer("COFB" , 0.99f);
            Assert.AreEqual(1.25f , _customerBasket.CalculateTotalCost());
        }
    }
}
