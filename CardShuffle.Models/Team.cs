namespace CardShuffle.Models
{
    public class Team
    {
        public int TeamId { get; set; }
        public required string Name { get; set; }
        public IEnumerable<User>? Users { get; set; } = null;
    }
}
