using System.ComponentModel.DataAnnotations;
namespace Team.Api.DTOs
{
    public class UpdateTeamDto
    {
        [Required]
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
}
