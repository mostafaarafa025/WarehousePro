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

namespace efProjectNew.Controls
{
    public partial class Entry_Vouchers : UserControl
    {
        InventoryContext Context;

        public Entry_Vouchers()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void Entry_Vouchers_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            Context = new InventoryContext();
            var list = Context.EntryVouchers.Select(ev => new
            {
                ev.referenceNumber,
                ev.Date,
                ev.SupplierId,
                ev.InventoryId,
            }).ToList();
            dataGridView1.DataSource = list;
        }

        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "referenceNumber",
                DataPropertyName = "referenceNumber",
                HeaderText = "Reference Number",
                ReadOnly = true,
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Date",
                DataPropertyName = "Date",
                HeaderText = "Date",
                ReadOnly = true,
                Width = 130
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SupplierId",
                DataPropertyName = "SupplierId",
                HeaderText = "Supplier Id",
                ReadOnly = true,
                Width = 70
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "InventoryId",
                DataPropertyName = "InventoryId",
                HeaderText = "Inventory Id",
                ReadOnly = true,
                Width = 70
            });
            DataGridViewButtonColumn viewColumn = new DataGridViewButtonColumn()
            {
                Name = "View",
                HeaderText = "View",
                Text = "👁️ View",
                UseColumnTextForButtonValue = true,
                Width = 100
            };

            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn()
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "✏️ Edit",
                UseColumnTextForButtonValue = true,
                Width = 100
            };

            dataGridView1.Columns.Add(viewColumn);
            dataGridView1.Columns.Add(editColumn);
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            EntryVouchersForm form = new EntryVouchersForm();
            form.ShowDialog();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dataGridView1.Columns[e.ColumnIndex].Name == "View")
            {
                int referenceNumber = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["referenceNumber"].Value);

                formDetails formd = new formDetails(referenceNumber);
                formd.ShowDialog();
            }
        }
    }
}
