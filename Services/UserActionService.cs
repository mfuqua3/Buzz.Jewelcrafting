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

    public async Task SetStatus(string userId, int designId, string status)
    {
        var userDesign = await _dbContext.UserDesigns.FindAsync(userId, designId);
        if (userDesign == null)
        {
            userDesign = new UserDesign() { UserId = userId, DesignId = designId };
            await _dbContext.UserDesigns.AddAsync(userDesign);
        }
        userDesign.Status = status;
        await _dbContext.SaveChangesAsync();
    }

}