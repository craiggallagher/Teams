namespace Team.Api.DTOs;

using System.ComponentModel.DataAnnotations;
using Team.Api.Validation;
public class CreateTeamDto
{
    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Range(1, int.MaxValue)]
    public int StadiumCapacity { get; set; }

    [EstablishedDate]
    public DateOnly EstablishedDate { get; set; }

    [Required]
    [Url]
    public string CrestUrl { get; set; } = string.Empty;
}
