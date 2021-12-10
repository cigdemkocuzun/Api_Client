using System.Threading;
using System.Threading.Tasks;
using ChannelEngine.Core.Abstract.RestApi;
using Microsoft.Extensions.Configuration;
using RestSharp;

namespace ChannelEngine.Core.Concrete.RestApi
{
    public class RestApiService: IRestApiService
    {
        private readonly RestClient _client; 
        private readonly IConfiguration _configuration;
        private readonly string _apiKey;
        public RestApiService(IConfiguration configuration)
        {
            _configuration = configuration;
            _client = new RestClient(_configuration["ChannelEngineApi:ApiUrl"]);
            _apiKey = _configuration["ChannelEngineApi:ApiKey"];
        }

        public  Task<IRestResponse> ExecuteTask(RestRequest request)
        {
            var cancellationTokenSource = new CancellationTokenSource();
           
            request.AddQueryParameter("apiKey", _apiKey);
            return _client.ExecuteAsync(request, cancellationTokenSource.Token);
        }
    }
}
