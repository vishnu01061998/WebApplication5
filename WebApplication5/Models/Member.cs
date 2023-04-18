using System;
using System.Collections.Generic;

namespace WebApplication5.models;

public partial class Member
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Mobile { get; set; }

    public string? Duration { get; set; }

    public DateTime? JoiningDate { get; set; }

    public string? Gender { get; set; }
}
