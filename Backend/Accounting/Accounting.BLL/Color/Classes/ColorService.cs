using Accounting.BLL.Color.Interfaces;
using Accounting.BLL.Framework;
using Accounting.DAL.DataContext;
using Accounting.Model.Color.Dtos;
using AutoMapper;
using Microsoft.EntityFrameworkCore;

namespace Accounting.BLL.Color.Classes;
public class ColorService : BaseApplicationService, IColorService
{
    private readonly IMapper _mapper;

    public ColorService(AccountingDbContext accountingDbContext, IMapper mapper) : base(accountingDbContext)
    {
        _mapper = mapper;
    }

    public async Task<ColorDto> AddColorAsync(ColorDto colorDto)
    {
        Model.Color.Entities.Color color = _mapper.Map<Model.Color.Entities.Color>(colorDto);
        await _accountingDbContext.Colors.AddAsync(color);
        await _accountingDbContext.SaveChangesAsync();

        colorDto.ColorId = color.ColorId;
        return colorDto;
    }

    public async Task<IReadOnlyList<ColorDto>> GetIconsAsync()
    {
        List<Model.Color.Entities.Color> colors = await _accountingDbContext.Colors.AsNoTracking().ToListAsync();

        IReadOnlyList<ColorDto> colorDtos = _mapper.Map<IReadOnlyList<ColorDto>>(colors);
        return colorDtos;
    }

    public async Task<bool> RemoveColorAsync(int colorId)
    {
        Model.Color.Entities.Color? color = await _accountingDbContext.Colors.FindAsync(colorId);
        if(color != null)
        {
            _accountingDbContext.Colors.Remove(color);
            await _accountingDbContext.SaveChangesAsync();

            return true;
        }
        else
        {
            Model.Color.Entities.Color? color2 = await _accountingDbContext.Colors.FirstOrDefaultAsync(c=>c.ColorId==colorId);
            if (color2 != null)
            {
                _accountingDbContext.Colors.Remove(color2);
                await _accountingDbContext.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public async Task<bool> UpdateColorAsync(ColorDto colorDto)
    {
        Model.Color.Entities.Color? color = await _accountingDbContext.Colors.FindAsync(colorDto.ColorId);
        if (color != null)
        {
            Model.Color.Entities.Color updatedColor = _mapper.Map<Model.Color.Entities.Color>(colorDto);
            _accountingDbContext.Colors.Update(updatedColor);
            await _accountingDbContext.SaveChangesAsync();

            return true;
        }
        else
        {
            Model.Color.Entities.Color? color2 = await _accountingDbContext.Colors.FirstOrDefaultAsync(c => c.ColorId == colorDto.ColorId);
            if (color2 != null)
            {
                Model.Color.Entities.Color updatedColor = _mapper.Map<Model.Color.Entities.Color>(colorDto);
                _accountingDbContext.Colors.Update(updatedColor);
                await _accountingDbContext.SaveChangesAsync();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
