namespace Team.Api.DTOs;

using System.ComponentModel.DataAnnotations;

public class CreateTeamDto
{
    [Required]
    [StringLength(100, MinimumLength = 2)]
    public string Name { get; set; } = string.Empty;

    [Range(1, int.MaxValue)]
    public int StadiumCapacity { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateOnly EstablishedDate { get; set; }

    [Required]
    [Url]
    public string CrestUrl { get; set; } = string.Empty;
}
