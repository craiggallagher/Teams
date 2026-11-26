using System.ComponentModel.DataAnnotations;
using Team.Api.Validation;
namespace Team.Api.DTOs
{
    public class UpdateTeamDto
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Range(1, int.MaxValue)]
        public int StadiumCapacity { get; set; }

        [EstablishedDate]
        [DataType(DataType.Date)]
        public DateOnly EstablishedDate { get; set; }

        [Required]
        [Url]
        public string CrestUrl { get; set; } = string.Empty;
    }
}
