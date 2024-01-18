using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace exercise.main
{
    public class SMSNotifier
    {
        private string accountSid;
        private string authToken;
        private string fromPhoneNumber;

        public SMSNotifier(string accountSid , string authToken , string fromPhoneNumber)
        {
            this.accountSid = accountSid;
            this.authToken = authToken;
            this.fromPhoneNumber = fromPhoneNumber;
        }

        public virtual void SendSMS(string toPhoneNumber , string message)
        {
            TwilioClient.Init(accountSid , authToken);

            var messageOptions = new CreateMessageOptions(
                new Twilio.Types.PhoneNumber(toPhoneNumber));
            messageOptions.From = new Twilio.Types.PhoneNumber(fromPhoneNumber);
            messageOptions.Body = message;

            var messageResource = MessageResource.Create(messageOptions);
        }
    }
}
