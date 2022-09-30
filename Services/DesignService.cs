using Buzz.Jewelcrafting.Data;
using Buzz.Jewelcrafting.Models;
using Buzz.Jewelcrafting.Utilities;
using Microsoft.EntityFrameworkCore;

namespace Buzz.Jewelcrafting.Services;

public class DesignService
{
    private readonly BuzzDbContext _dbContext;

    public DesignService(BuzzDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<DesignStatusSummary> GetDesignStatusSummary()
    {
        var summary = new DesignStatusSummary();
        var designs = await _dbContext.Designs
            .Include(x => x.Jewelry)
            .Include(x => x.GemCut)
            .ToListAsync();
        summary.GemCuts = designs
            .Where(x => x.GemCut != null)
            .OrderBy(x => x.GemCut.Hybrid)
            .ThenBy(x => x.GemCut.Color)
            .ThenBy(x => x.GemCut.Name)
            .Select(x => new GemCutItem
            {
                Id = x.Id,
                Cost = x.Cost,
                Name = x.GemCut.Name,
                ItemId = x.GemCut.ItemId,
                IconName = x.GemCut.IconName,
                DesignId = x.ItemId,
                DesignIconName = x.IconName,
                Color = x.GemCut.Color,
                Stat1 = x.GemCut.Stat1,
                Stat2 = x.GemCut.Stat2
            }).ToList();
        summary.Jewelry = designs
            .Where(x => x.Jewelry != null)
            .OrderBy(x => x.Jewelry.InventorySlot)
            .ThenBy(x => x.Jewelry.Name)
            .Select(x => new JewelryItem
            {
                Id = x.Id,
                Cost = x.Cost,
                Name = x.Jewelry.Name,
                ItemId = x.Jewelry.ItemId,
                IconName = x.Jewelry.IconName,
                DesignId = x.ItemId,
                DesignIconName = x.IconName,
                InventorySlot = x.Jewelry.InventorySlot
            }).ToList();
        summary.UserStatusList = await _dbContext.Users
            .OrderBy(x => x.Name)
            .Select(x => new UserStatus
            {
                UserId = x.Id,
                Username = x.Name,
                PendingItems = x.UserDesigns
                    .Where(d => d.Status == UserDesignStatus.Pending)
                    .Select(d => d.Design.ItemId)
                    .ToList(),
                OwnedItems = x.UserDesigns
                    .Where(d => d.Status == UserDesignStatus.Owned)
                    .Select(d => d.Design.ItemId)
                    .ToList(),
            })
            .ToListAsync();
        return summary;
    }
}