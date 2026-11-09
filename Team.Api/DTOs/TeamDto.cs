namespace Team.Api.DTOs
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int StadiumCapacity { get; set; }
        public DateOnly EstablishedDate { get; set; }
        public string CrestUrl { get; set; } = string.Empty;
    }
}
