using DatabankApi.Abstract;

namespace DatabankApi.Endpoint.UserEndpoint;


public class RegisterUserEndpoint : IEndpoint
{

    public void Endpoint(IEndpointRouteBuilder app)
    {
        app.MapPost("");
    }
}
