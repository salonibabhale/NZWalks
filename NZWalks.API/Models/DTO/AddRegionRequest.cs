namespace NZWalks.API.Models.DTO
{
    public class AddRegionRequest
    {
        public string Name { get; internal set; }
        public string Code { get; internal set; }
        public double Area { get; internal set; }
        public double Lat { get; internal set; }
        public double Long { get; internal set; }
        public long Population { get; set; }
    }
}
