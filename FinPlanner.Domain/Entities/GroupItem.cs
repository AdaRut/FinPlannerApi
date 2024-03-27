using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinPlanner.Domain.Entities
{
    public class GroupItem
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public decimal PlannedAmount { get; set; }
        public decimal SpendAmount { get; set; }
        public string Notes { get; set; }
        public bool IsPaid { get; set; }
        public int GroupId { get; set; }
    }
}
