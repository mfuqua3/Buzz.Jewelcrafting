using Buzz.Jewelcrafting.Data;
using Buzz.Jewelcrafting.Data.Entities;
using Buzz.Jewelcrafting.Utilities;

namespace Buzz.Jewelcrafting.Services;

public class UserActionService
{
    private readonly BuzzDbContext _dbContext;

    public UserActionService(BuzzDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task SetAsPending(string userId, int designId)
    {
        var userDesign = await _dbContext.UserDesigns.FindAsync(userId, designId) ??
                         new UserDesign { UserId = userId, DesignId = designId };
        _dbContext.UserDesigns.Attach(userDesign);
        userDesign.Status = UserDesignStatus.Pending;
        await _dbContext.SaveChangesAsync();
    }

    public async Task SetAsOwned(string userId, int designId)
    {
        var userDesign = await _dbContext.UserDesigns.FindAsync(userId, designId) ??
                         new UserDesign { UserId = userId, DesignId = designId };
        _dbContext.UserDesigns.Attach(userDesign);
        userDesign.Status = UserDesignStatus.Owned;
        await _dbContext.SaveChangesAsync();
    }

    public async Task SetAsUnowned(string userId, int designId)
    {
        var userDesign = await _dbContext.UserDesigns.FindAsync(userId, designId) ??
                         new UserDesign { UserId = userId, DesignId = designId };
        _dbContext.UserDesigns.Attach(userDesign);
        userDesign.Status = UserDesignStatus.Unowned;
        await _dbContext.SaveChangesAsync();
    }
}