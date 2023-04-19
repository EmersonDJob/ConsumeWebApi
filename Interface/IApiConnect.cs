using ConsumeWebApi.Models;
using Refit;

namespace ConsumeWebApi.Interface
{
    public interface IApiConnect
    {
        [Get("/posts")]
        Task<List<SamplePost>> ConnectAsync();
    }
}
