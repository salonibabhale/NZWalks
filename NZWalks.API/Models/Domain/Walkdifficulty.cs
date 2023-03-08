namespace NZWalks.API.Models.Domain
{
    public class Walkdifficulty
    {
        public Guid Id { get; set; }
        public string? Code { get; set; }
        public double Length { get; set; }
        public Guid RegionId { get; set; }
        public Guid WalkdifficultyId { get; set; }

        //Navigation property 
        public IEnumerable<Walk>? Walks { get; set; }

    }
}
