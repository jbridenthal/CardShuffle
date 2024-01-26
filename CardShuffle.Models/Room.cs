namespace CardShuffle.Models
{
    public class Room
    {
        public int ID { get; set; }
        public required string Name { get; set; }
        public Team Team { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
