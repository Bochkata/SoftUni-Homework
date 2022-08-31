
namespace Telephony
{
    public class SmartPhone : ICallable, IBrowseable
    {
        public string CanCall(string phoneNumber)
        {
            return $"Calling... {phoneNumber}";
        }

        public string CanBrowse(string url)
        {
            return $"Browsing: {url}!";
        }
    }
}
