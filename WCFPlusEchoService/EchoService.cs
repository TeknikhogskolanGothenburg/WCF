namespace WCFPlusEchoService
{
    public class EchoService : IEchoService
    {
        public string GetData(int value)
        {
            return string.Format("You entered somethnig like: {0}", value);
        }
    }
}
