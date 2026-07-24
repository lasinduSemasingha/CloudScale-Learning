namespace CloudScale.WebAPI.Endpoints.Auth;
public static class LoginEndpoint
{
    public static void MapLoginEndpoint(this WebApplication app)
    {
        app.MapPost("/api/auth/login", async (UserLoginRequestDto request, IUserService userService) =>
        {
            var isAuthenticated = await userService.LoginAsync(request);
            if (!isAuthenticated)
            {
                return Results.Unauthorized();
            }
            return Results.Ok(new { Success = true, Message = "Logged in successfully." });
        })
        .WithName("Login")
        .ProducesProblem(StatusCodes.Status401Unauthorized)
        .WithSummary("User Login")
        .WithDescription("Authenticate user and return a token.");
    }
}