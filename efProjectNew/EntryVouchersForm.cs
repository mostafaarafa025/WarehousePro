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
using efProjectNew.Controls;
using efProjectNew.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace efProjectNew
{
    public partial class EntryVouchersForm : Form
    {
        InventoryContext Context;
        public EntryVouchersForm()
        {
            InitializeComponent();
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            SetupDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EntryVouchersForm_Load(object sender, EventArgs e)
        {
            Context = new InventoryContext();

            comboBoxInventory.DataSource = Context.Inventories
      .Select(i => new { i.InventoryId, i.Name })
      .ToList();
            comboBoxInventory.DisplayMember = "Name";
            comboBoxInventory.ValueMember = "InventoryId";

            comboBoxSupplier.DataSource = Context.Suppliers
                .Select(s => new { s.SupplierId, s.Name })
                .ToList();
            comboBoxSupplier.DisplayMember = "Name";
            comboBoxSupplier.ValueMember = "SupplierId";

            comboBoxProduct.DataSource = Context.Products
                .Select(p => new { p.ProductId, p.ProductName })
                .ToList();
            comboBoxProduct.DisplayMember = "ProductName";
            comboBoxProduct.ValueMember = "ProductId";
        }


        private void SetupDataGridView()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoGenerateColumns = false;

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductId",
                HeaderText = "Product ID",
                DataPropertyName = "ProductId",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName",
                HeaderText = "Product Name",
                DataPropertyName = "ProductName",
                ReadOnly = true
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Quantity",
                HeaderText = "Quantity",
                DataPropertyName = "Quantity"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductionDate",
                HeaderText = "Production Date",
                DataPropertyName = "ProductionDate"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ExpirationDate",
                HeaderText = "Expiration Date",
                DataPropertyName = "ExpirationDate"
            });

            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Price",
                HeaderText = "Price",
                DataPropertyName = "Price",
                ReadOnly = true
            });
        }

        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedValue is int productId)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ProductId"].Value != null && (int)row.Cells["ProductId"].Value == productId)
                    {
                        MessageBox.Show("This product is already added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                var selectedProduct = Context.Products.FirstOrDefault(p => p.ProductId == productId);
                if (selectedProduct != null)
                {
                    dataGridView1.Rows.Add(
                        selectedProduct.ProductId,
                        selectedProduct.ProductName,
                        0,
                        DateTime.Now,
                        DateTime.Now.AddYears(1),
                        0
                    );
                }
            }
        }
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Quantity"].Index)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                int quantity = 0;

                if (row.Cells["Quantity"].Value != null && int.TryParse(row.Cells["Quantity"].Value.ToString(), out quantity))
                {
                    var product = Context.Products.FirstOrDefault(p => p.ProductId == productId);
                    if (product != null)
                    {
                        row.Cells["Price"].Value = quantity * product.ProductPrice;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    row.Cells["Quantity"].Value = 0;
                }
            }
        }

        private void addToEntryVoucher()
        {
            try
            {
                if (!int.TryParse(textBoxReference.Text, out int referenceId))
                {
                    MessageBox.Show("Please enter a valid number for reference ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int InventoryId = Convert.ToInt32(comboBoxInventory.SelectedValue);
                int SupplierId = Convert.ToInt32(comboBoxSupplier.SelectedValue);

                if (!DateTime.TryParse(textBoxdate.Text, out DateTime entryDate))
                {
                    MessageBox.Show("Please enter a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Context.EntryVouchers.Add(new Entities.EntryVoucher()
                {
                    referenceNumber = referenceId,
                    InventoryId = InventoryId,
                    SupplierId = SupplierId,
                    Date = entryDate
                });

                Context.SaveChanges();
                MessageBox.Show("Entry Voucher added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("can't added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddToEntryVoucherDetails()
        {
            try
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ProductId"].Value != null && row.Cells["Quantity"].Value != null)
                    {
                        int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        DateTime productionDate = Convert.ToDateTime(row.Cells["ProductionDate"].Value);
                        DateTime expirationDate = Convert.ToDateTime(row.Cells["ExpirationDate"].Value);

                        int referenceId = int.Parse(textBoxReference.Text);
                        Context.EntryVoucherDetails.Add(new Entities.EntryVoucherDetail()
                        {
                            ReferenceNumber = referenceId,
                            ProductId = productId,
                            Quantity = quantity,
                            ProductionDate = productionDate,
                            ExpirationDate = expirationDate,

                        });
                    }
                }

                Context.SaveChanges();
                MessageBox.Show("Entry Voucher Details added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateInventoryItems()
        {
            try
            {
                int inventoryId = Convert.ToInt32(comboBoxInventory.SelectedValue);

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["ProductId"].Value != null && row.Cells["Quantity"].Value != null)
                    {
                        int productId = Convert.ToInt32(row.Cells["ProductId"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);

                        var inventoryItem = Context.InventoryItems
                            .FirstOrDefault(ii => ii.InventoryId == inventoryId && ii.ProductId == productId);

                        if (inventoryItem != null)
                        {
                            inventoryItem.Quantity += quantity;
                        }
                        else
                        {
                           
                            Context.InventoryItems.Add(new Entities.InventoryItems()
                            {
                                InventoryId = inventoryId,
                                ProductId = productId,
                                Quantity = quantity
                            });
                        }
                    }
                }

                Context.SaveChanges();
                MessageBox.Show("Inventory updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            addToEntryVoucher();
            AddToEntryVoucherDetails();
            UpdateInventoryItems();
        }


        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
           
        }
    }
}
