using System;
using System.ServiceModel;

namespace Demo.Contracts
{
    [ServiceContract]
    public interface IContract
    {
        /// <summary>
        /// "xxx" will play the crucial role in the
        /// later added CustomFilter :-)
        /// in the routing host
        /// </summary>
        /// <param name="xxx"></param>
        /// <returns></returns>
        [OperationContract]
        string DoSomething(string xxx);

        /// <summary>
        /// this is going to be the operation for the multicast
        /// </summary>
        [OperationContract(IsOneWay = true, Action = "http://pingo/multicast")]
        void Broadcast();
    }
}
