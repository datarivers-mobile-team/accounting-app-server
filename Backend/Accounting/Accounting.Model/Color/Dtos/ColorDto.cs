using Accounting.Model.Color.Type;

namespace Accounting.Model.Color.Dtos;
public class ColorDto
{
    public int ColorId { get; set; }
    public string Value { get; set; }
    public string Title { get; set; }
    public ColorType ColorType { get; set; }
}
