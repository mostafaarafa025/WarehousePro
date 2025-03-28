using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace efProjectNew.Entities
{
    public class EntryVoucher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int referenceNumber {  get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int InventoryId { get; set; }
        [Required]
        public virtual Inventory Inventory { get; set; }
        [Required]
        public int SupplierId { get; set; }
        [Required]
        public virtual  Supplier Supplier { get; set; }

        public virtual ICollection<EntryVoucherDetail> EntryVoucherDetails { get; set; } = new HashSet<EntryVoucherDetail>();

    }
}
