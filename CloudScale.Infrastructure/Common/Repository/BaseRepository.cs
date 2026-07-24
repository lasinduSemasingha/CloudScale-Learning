namespace CloudScale.Infrastructure.Common.Repository;
public class BaseRepository<TEntity> where TEntity : class
{
    protected readonly AppDbContext _context;

    public BaseRepository(AppDbContext context)
    {
        _context = context;
    }
}