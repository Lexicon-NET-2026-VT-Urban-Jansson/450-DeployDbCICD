namespace DeployDbCICD.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string Description { get; set; } = default!;
        public int ModelYear { get; set; }
    }
}
