using DatabankApi.Abstract;
using DatabankApi.Services;

namespace DatababankApi.Endpoint.UserEndpoint;

public sealed class GetAllUserEndpoint(IUserServices userServices) : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {

    }
}