using Demo.Contracts;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace Demo.Proxies
{
    public class ProcessClient : ClientBase<IContract>, IContract
    {
        public ProcessClient()
        {
            
        }

        public ProcessClient(string endpoint)
            : base(endpoint)
        {
            
        }

        public ProcessClient(Binding binding, EndpointAddress endpoint)
            : base(binding, endpoint)
        {
            
        }

        public void Broadcast()
        {
            Channel.Broadcast();
        }

        public string DoSomething(string input)
        {
            return Channel.DoSomething(input);
        }
    }
}
