using System.Threading.Tasks;

namespace PocServiceBusApi.Service
{
    public interface IMessagePublisher
    {
        Task PublisherAsync<T>(T request);
    }
}
