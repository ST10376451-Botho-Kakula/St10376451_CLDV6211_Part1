public class EventOrganizer
{
    public int EventOrganizerId { get; set; }
    public string Name { get; set; }
    public ICollection<Event> Events { get; set; }
}
