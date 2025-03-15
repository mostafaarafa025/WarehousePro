using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace efProjectNew.Entities
{
    [Table("Suppliers")]
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(11)]
        public string PhoneNumber { get; set; }
        public string Number { get; set; }
        public string FaxNumber { get; set; }
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string WebSite { get; set; }
    }
}
