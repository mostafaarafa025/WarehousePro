using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProjectNew.Entities
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        [MaxLength(50)]
        [Required]
        public string ProductName { get; set; }
        [Column(TypeName = "money")]
        [Required]
        public double ProductPrice { get; set; }

        public string MeasurementType { get; set; }

        public virtual ICollection<InventoryItems> InventoryItems { get; set; }=new HashSet<InventoryItems>();

        public virtual ICollection<EntryVoucherDetail> EntryVoucherDetails { get; set; } = new HashSet<EntryVoucherDetail>();

    }
}
