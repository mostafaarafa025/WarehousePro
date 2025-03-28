using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProjectNew.Entities
{
    public class InventoryItems
    {
        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
        public int Quantity {  get; set; }

        public int InventoryId {  get; set; }
        public virtual Inventory Inventory { get; set; }
        public int ProductId {  get; set; }
        public virtual Product Product { get; set; }
    }
}
