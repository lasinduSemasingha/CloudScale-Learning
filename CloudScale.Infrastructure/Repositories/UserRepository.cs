namespace CloudScale.Infrastructure.Repositories;
public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context)
        : base(context)
    {
    }
    public async Task<bool> ExistsAsync(string email)
    {
        return await _context.Users.AnyAsync(u => u.Email == email);
    }
    public async Task<User> AddUser(User user)
    {
        _context.Users.Add(user);
        await _context.SaveChangesAsync();
        return user;
    }

    public async Task<User?> GetUserDetailsByEmailOrId(string? email, Guid? Id)
    {
        if (email != null)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
        else if (Id != null)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Id == Id);
        }
        return null;
    }
}