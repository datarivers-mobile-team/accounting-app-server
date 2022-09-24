using Accounting.BLL.Framework;
using Accounting.BLL.Icon.Interfaces;
using Accounting.DAL.DataContext;
using Accounting.Model.Icon.Dtos;
using Accounting.Model.Icon.Entities;
using Microsoft.EntityFrameworkCore;

namespace Accounting.BLL.Icon.Classes;
public class IconService : BaseApplicationService, IIconService
{
    public IconService(AccountingDbContext accountingDbContext)
        : base(accountingDbContext)
    {
    }

    public async Task AddIconAsync(IconDto iconDto)
    {
        Model.Icon.Entities.Icon icon = new()
        {
            FileName = iconDto.FileName,
            Title = iconDto.Title,
            IconType = (byte)iconDto.IconType,
            Oeder = iconDto.Oeder
        };

        await _accountingDbContext.Icons.AddAsync(icon);
        await _accountingDbContext.SaveChangesAsync();
    }

    public async IAsyncEnumerable<IconDto> GetIconsAsync()
    {
        foreach (var item in await _accountingDbContext.Icons.AsNoTracking().ToListAsync())
        {
            yield return new IconDto
            {
                FileName = item.FileName,
                Title = item.Title,
                IconType = (Model.Icon.IconType.Type)item.IconType,
                Oeder = item.Oeder
            };
        }
    }

    public async Task<bool> RemoveIconAsync(int iconId)
    {
        Model.Icon.Entities.Icon? icon = await _accountingDbContext.Icons.SingleOrDefaultAsync
                                                                  (i => i.IconId.Equals(iconId));

        if (icon == null) return false;

        _accountingDbContext.Icons.Remove(icon);
        await _accountingDbContext.SaveChangesAsync();

        return true;
    }

    public async Task<bool> UpdateIconAsync(int iconId, IconDto iconDto)
    {
        Model.Icon.Entities.Icon icon = new() { IconId = iconId, FileName = iconDto.FileName,
            Title = iconDto.Title, IconType = (byte)iconDto.IconType, Oeder = iconDto.Oeder };

        _accountingDbContext.Icons.Update(icon);
        await _accountingDbContext.SaveChangesAsync();

        return true;
    }
}
