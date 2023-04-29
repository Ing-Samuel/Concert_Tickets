namespace Concert.Shared.Entities
{
    public class Ticket
    {
        public int Id { get; set; }

        public DateTime? UseDate { get; set; } = null;

        public bool Used { get; set; } = false;

        public string? EntrySite { get; set; } = null!;

    }
}
