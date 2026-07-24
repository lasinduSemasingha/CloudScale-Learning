namespace CloudScale.Application.Interfaces.Services;
public interface IUserService
{
    Task RegisterAsync(UserRegistrationRequestDto request);
}