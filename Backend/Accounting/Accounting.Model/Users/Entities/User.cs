﻿namespace Accounting.Model.Users.Entities;
public class User
{
    public int UserId { get; set; }

    public string? FullName { get; set; }

    public string PhoneNumber { get; set; }

    public string? RefCode { get; set; }

    public int? PreferredCurrency { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool? Isdeleted { get; set; }
}
