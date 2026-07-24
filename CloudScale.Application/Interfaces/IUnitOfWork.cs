namespace CloudScale.Application.Interfaces;
public interface IUnitOfWork
{
    IUserRepository Users { get; }
    Task SaveChangesAsync();
}