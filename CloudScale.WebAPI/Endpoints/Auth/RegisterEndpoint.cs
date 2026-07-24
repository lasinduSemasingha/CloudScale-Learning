namespace CloudScale.WebAPI.Endpoints.Auth;
public static class RegisterEndpoint
{
    public static void MapRegistrationEndpoint(this WebApplication app)
    {
        app.MapPost("/api/auth/register", async (UserRegistrationRequestDto request, IUserService userService) =>
        {
            await userService.RegisterAsync(request);
            return Results.Ok(new { Message = "User registered successfully." });
        })
        .WithName("Register")
        .ProducesProblem(StatusCodes.Status400BadRequest)
        .WithSummary("Create Product")
        .WithDescription("Create Product");
    }
}