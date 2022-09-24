using System.ComponentModel.DataAnnotations;

namespace Accounting.Model.Users.Dtos;
public class RegisterDto
{
    [Required]
    public string PhoneNumber { get; set; }

    public string? FullName { get; set; }

    public string? RefCode { get; set; }

    public int? PreferredCurrency { get; set; }
}
