namespace FinPlanner.Domain.Entities
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? Description { get; set; }
        public DateTime? StartDate { get; set; } 
        public DateTime? EndDate { get; set; }
        public virtual IEnumerable<Group> Groupes { get; set; } = new List<Group>();
    }
}
