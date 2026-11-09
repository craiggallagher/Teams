namespace Team.Api.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int StadiumCapacity { get; set; }
        public DateOnly EstablishedDate { get; set; }
        public string CreateUrl { get; set; } = string.Empty;
    }
}
