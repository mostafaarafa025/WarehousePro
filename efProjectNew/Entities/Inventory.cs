using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProjectNew.Entities
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string? Address { get; set; }
        public string? Name { get; set; }
        public string? ManagerName { get; set; }

        public virtual ICollection<InventoryItems>InventoryItems { get; set; }=new HashSet<InventoryItems>();
    }
}
