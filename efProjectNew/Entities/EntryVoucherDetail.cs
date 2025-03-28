using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProjectNew.Entities
{
    public class EntryVoucherDetail
    {
        [Key]
        [Required]
        public int ReferenceNumber { get; set; }  

        [Key]
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public DateTime ProductionDate { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }

        public virtual EntryVoucher EntryVoucher { get; set; }
        public virtual Product Product { get; set; }
    }
}
