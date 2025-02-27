using DatabankApi.Abstract;

namespace DatabankApi.Endpoints;


public class RegisterUserEndpoint : IEndpoint
{
    public void Endpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("register", () => "Hello Shit"
       );
    }
}