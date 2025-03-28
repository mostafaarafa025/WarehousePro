using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using efProjectNew.context;

namespace efProjectNew
{
    public partial class formDetails : Form
    {
        public int referenceNumber;
        InventoryContext Context;
        public formDetails(int referenceNumber)
        {
            InitializeComponent();
            this.referenceNumber = referenceNumber;
            Context = new InventoryContext();

        }
        private void formDetails_Load(object sender, EventArgs e)
        {
            LoadEntryVoucherDetails();
        }
        private void LoadEntryVoucherDetails()
        {
            var details = Context.EntryVoucherDetails
                .Where(d => d.ReferenceNumber == referenceNumber).Select(d => new
                {
                    d.ProductId,
                    ProductName = d.Product.ProductName, 
                    d.Quantity,
                    d.ProductionDate,
                    d.ExpirationDate,
                })
              .ToList();

            dataGridView1.DataSource = details;
        }

    }
}
