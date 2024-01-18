using exercise.main;
using Moq;

namespace exercise.tests
{
    [TestFixture]
    public class ExtensionsTests
    {
        private CustomerBasket _customerBasket;
        private Bagel _bagel;
        private Inventory _inventory;
        private Mock<SMSNotifier> _smsNotifierMock;

        [SetUp]
        public void Setup()
        {
            _smsNotifierMock = new Mock<SMSNotifier>("accountSid" , "authToken" , "fromPhoneNumber");
            _customerBasket = new CustomerBasket { SmsNotifier = _smsNotifierMock.Object };
            _inventory = Inventory.Instance;
            _bagel = new Bagel(1 , "BGLO" , 0.49f , "Bagel" , "Onion");
            _inventory.UpdateInventory(_bagel);
        }
        #region Extension 1
        [Test]
        public void TestApplyDiscount()
        {
            _bagel.DiscountQuantity = 6;
            _bagel.DiscountPrice = 2.49f;
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
            _customerBasket.AddItem("COFB" , 0.99f , "Coffee" , "Black");
            _customerBasket.AddSpecialOffer("COFB" , 1.25f);
            Assert.AreEqual(1.25f , _customerBasket.CalculateTotalCost());
        }


        [Test]
        public void TestAddFillingToItem()
        {
            Assert.IsTrue(_bagel.AddFilling("Cheese" , 0.49f));
        }

        [Test]
        public void TestRemoveFillingFromItem()
        {
            _bagel.AddFilling("Cheese" , 0.49f);
            Assert.IsTrue(_bagel.RemoveFilling("Cheese"));
        }
        #endregion

        #region Extension 2
        [Test]
        public void TestPrintReceipt()
        {

            var _customerBasket = new CustomerBasket();
            _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            _customerBasket.AddItem("COFB" , 0.99f , "Coffee" , "Black");
            _customerBasket.AddSpecialOffer("COFB" , 1.25f);
            var receipt = new Receipt(_customerBasket);

            var writer = new StringWriter();
            Console.SetOut(writer);
            receipt.PrintReceipt();

            var output = writer.GetStringBuilder().ToString();
            Assert.IsNotEmpty(output , "Error: No receipt was printed");
        }
        #endregion

        #region Extension 3 

        [Test]
        public void TestCalculateSavings()
        {
            _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            _customerBasket.AddItem("COFB" , 0.99f , "Coffee" , "Black");
            _customerBasket.AddSpecialOffer("COFB" , 1.25f);
            float totalCost = _customerBasket.CalculateTotalCost();


            Assert.AreEqual(Math.Round(0.23f , 3) , Math.Round(_customerBasket.Savings , 3));
        }

        [Test]
        public void TestApplySpecialOffers()
        {
            _customerBasket.AddItem("BGLO" , 0.49f , "Bagel" , "Onion");
            _customerBasket.AddItem("COFB" , 0.99f , "Coffee" , "Black");
            _customerBasket.AddSpecialOffer("COFB" , 1.25f);
            float totalCost = _customerBasket.CalculateTotalCost();

            Assert.AreEqual(1.25f , totalCost);
        }
        #endregion

        #region Extension 4
        [Test]
        public void TestCompleteOrder()
        {
            _smsNotifierMock.Setup(m => m.SendSMS(It.IsAny<string>() , It.IsAny<string>()));
            _customerBasket.CompleteOrder();
            _smsNotifierMock.Verify(m => m.SendSMS(It.IsAny<string>() , It.IsAny<string>()) , Times.Once);
        }
        #endregion
    }
}
