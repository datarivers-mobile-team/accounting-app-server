using System.ComponentModel.DataAnnotations;

namespace Accounting.Model.Icon.Dtos;
public class IconDto
{
    [Required]
    public string Title { get; set; }

    public string FileName { get; set; }

    public IconType.Type IconType { get; set; }

    public int Oeder { get; set; }
}
