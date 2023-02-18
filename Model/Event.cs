namespace API_IPKISS.Model
{
    public class Event
    {
        public string? type { get; set; }
        public int amount { get; set; }
        public int? origin { get; set; }
        public int? destination { get; set; }
    }
}
