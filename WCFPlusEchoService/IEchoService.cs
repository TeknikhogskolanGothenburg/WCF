using System.ServiceModel;

namespace WCFPlusEchoService
{
    [ServiceContract]
    public interface IEchoService
    {
        [OperationContract]
        string GetData(int value);
    }
}
