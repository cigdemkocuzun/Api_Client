using System.Threading.Tasks;
using RestSharp;

namespace ChannelEngine.Core.Abstract.RestApi
{
    public interface IRestApiService
    {
        Task<IRestResponse> ExecuteTask(RestRequest request);
    }
}
