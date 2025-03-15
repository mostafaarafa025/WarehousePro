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
using efProjectNew.Entities;
using Microsoft.EntityFrameworkCore;

namespace efProjectNew.Controls
{
    public partial class SupplierControl : UserControl
    {
        InventoryContext Context;
        public SupplierControl()
        {
            Context = new InventoryContext();
            InitializeComponent();
            SetupDataGridView();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void loadData()
        {
            Context.Suppliers.Load();
            var list = Context.Suppliers.Local.ToBindingList();
            dataGridView1.DataSource = list;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                DataGridViewButtonCell buttonCell1 = new DataGridViewButtonCell();

                
                buttonCell.Value = "✏️ Edit ";
                buttonCell1.Value = "🗑 Delete";
                row.Cells["Edit"] = buttonCell;
                row.Cells["Delete"] = buttonCell1;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
        }
        private void clearInput()
        {
            textBoxId.Text = string.Empty;
            textBoxName.Text = string.Empty;
            textBoxhoneNumber.Text = string.Empty;
            textBoxFax.Text = string.Empty;
            textBoxMail.Text = string.Empty;
            textBoxNumber.Text = string.Empty;
            textBoxWebsite.Text = string.Empty;
        }
        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "SupplierId",
                DataPropertyName = "SupplierId",
                HeaderText = "Id",
                ReadOnly = true,
                Width = 50
            });


            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Name",
                DataPropertyName = "Name",
                HeaderText = "Name",
                ReadOnly = true,
                Width = 130
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "PhoneNumber",
                DataPropertyName = "PhoneNumber",
                HeaderText = "PhoneNumber",
                ReadOnly = true,
                Width = 100
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Number",
                DataPropertyName = "Number",
                HeaderText = "Number",
                ReadOnly = true,
                Width = 150
            });
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "FaxNumber",
                DataPropertyName = "FaxNumber",
                HeaderText = "Fax Number",
                ReadOnly = true,
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Email",
                DataPropertyName = "Email",
                HeaderText = "Email",
                ReadOnly = true,
                Width = 150
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "WebSite",
                DataPropertyName = "WebSite",
                HeaderText = "WebSite",
                ReadOnly = true,
                Width = 150
            });
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn()
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Width = 110
            };
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Width = 110
            };
            dataGridView1.Columns.Add(editColumn);
            dataGridView1.Columns.Add(deleteColumn);
            loadData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
              
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);
                    DeleteSupplier(supplierId);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int supplierId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["SupplierId"].Value);
                    editSupplier(supplierId);
                    buttonedit.Enabled = true;
                    buttonAdd.Enabled = false;
                }
            }
        }
        private void SupplierControl_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void DeleteSupplier(int supplierId)
        {
            try
            {
                var supplier = Context.Suppliers.FirstOrDefault(p => p.SupplierId == supplierId);
                if (supplier != null)
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this Supplier?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        Context.Suppliers.Remove(supplier);
                        Context.SaveChanges();
                        MessageBox.Show("supplier deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                }
                else
                {
                    MessageBox.Show("Supplier not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("supplier Can't deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editSupplier(int id)
        {
            var supplier = Context.Suppliers.FirstOrDefault(p => p.SupplierId == id);
            if (supplier != null)
            {
                textBoxId.Text = id.ToString();
                textBoxName.Text = supplier.Name;
                textBoxNumber.Text = supplier.Number;
                textBoxhoneNumber.Text = supplier.PhoneNumber;
                textBoxFax.Text = supplier.FaxNumber;
                textBoxMail.Text = supplier.Email;
                textBoxWebsite.Text = supplier.WebSite;
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxId.Text, out int id))
                {
                    Supplier supplier = Context.Suppliers.FirstOrDefault(p => p.SupplierId == id);
                    if (supplier != null)
                    {

                        supplier.Name = textBoxName.Text;
                        supplier.Number = textBoxNumber.Text;
                        supplier.Email = textBoxMail.Text;
                        supplier.PhoneNumber = textBoxhoneNumber.Text;
                        supplier.FaxNumber = textBoxFax.Text;
                        supplier.WebSite = textBoxWebsite.Text;

                        Context.SaveChanges();
                        Context = new InventoryContext();
                        loadData();
                        MessageBox.Show("supplier Edited successfully!");
                        clearInput();
                        textBoxId.Enabled = true;
                        buttonedit.Enabled = false;
                        buttonAdd.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonAdd_Click_1(object sender, EventArgs e)
        {

            try
            {
                var supplier = new Entities.Supplier()
                {
                    Name = textBoxName.Text,
                    PhoneNumber = textBoxhoneNumber.Text,
                    Number = textBoxNumber.Text,
                    FaxNumber = textBoxFax.Text,
                    Email = textBoxMail.Text,
                    WebSite = textBoxWebsite.Text
                };

                Context.Suppliers.Add(supplier);
                Context.SaveChanges();
                Context.Suppliers.Load(); 
                loadData();

                clearInput();
                MessageBox.Show("Supplier added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
