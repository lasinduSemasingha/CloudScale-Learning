namespace CloudScale.Application.Services;
public class UserService : IUserService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordHasherService _passwordHasher;
    public UserService(IUnitOfWork unitOfWork, IPasswordHasherService passwordHasher)
    {
        _unitOfWork = unitOfWork;
        _passwordHasher = passwordHasher;
    }
    public async Task RegisterAsync(UserRegistrationRequestDto request)
    {
        var exists = await _unitOfWork.Users.ExistsAsync(request.Email);

        if (exists)
            throw new Exception("Email already exists.");

        var user = new User();
        user.SetEmail(request.Email);
        user.SetPasswordHash(_passwordHasher.HashPassword(request.PasswordHash));
        user.SetDisplayName(request.DisplayName);
        user.SetCreatedAtUtc(DateTime.UtcNow);

        await _unitOfWork.Users.AddUser(user);
    }
}
