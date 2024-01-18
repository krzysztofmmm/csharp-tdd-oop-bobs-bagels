using exercise.main;
using Moq;

namespace exercise.tests
{
    [TestFixture]
    public class SMSNotifierTests
    {
        private Mock<SMSNotifier> _smsNotifierMock;

        [SetUp]
        public void Setup()
        {
            _smsNotifierMock = new Mock<SMSNotifier>("accountSid" , "authToken" , "fromPhoneNumber");
        }

        [Test]
        public void TestSendSMS()
        {
            _smsNotifierMock.Setup(m => m.SendSMS(It.IsAny<string>() , It.IsAny<string>()));
            _smsNotifierMock.Object.SendSMS("toPhoneNumber" , "message");
            _smsNotifierMock.Verify(m => m.SendSMS(It.IsAny<string>() , It.IsAny<string>()) , Times.Once);
        }
    }
}
