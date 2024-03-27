using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinPlanner.Domain.Entities
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;

        public int BudgetId { get; set; }
        public virtual IEnumerable<GroupItem> GroupItems { get; set; } = new List<GroupItem>();
    }
}
