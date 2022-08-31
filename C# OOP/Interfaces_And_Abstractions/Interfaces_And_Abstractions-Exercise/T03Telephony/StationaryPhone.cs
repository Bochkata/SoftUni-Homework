


namespace Telephony
{
    public class StationaryPhone : ICallable
    {
        public string CanCall(string phoneNumber)
        {
            return $"Dialing... {phoneNumber}";
        }
    }
}
