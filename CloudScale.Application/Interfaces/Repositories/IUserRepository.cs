namespace CloudScale.Application.Interfaces.Repositories;
public interface IUserRepository
{
    Task<User> AddUser(User user);
    Task<bool> ExistsAsync(string email);
    Task<User?> GetUserDetailsByEmailOrId(string? email, Guid? Id);
}