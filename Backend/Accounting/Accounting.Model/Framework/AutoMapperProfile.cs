using Accounting.Model.Color.Dtos;
using AutoMapper;

namespace Accounting.Model.Framework;
public class AutoMapperProfile : Profile
{
	public AutoMapperProfile()
	{
		CreateMap<Color.Entities.Color, ColorDto>().ReverseMap();
	}
}
