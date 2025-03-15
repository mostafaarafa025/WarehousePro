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
    public partial class ProductControl : UserControl
    {
        InventoryContext Context;
        public ProductControl()
        {
            InitializeComponent();
            Context = new InventoryContext();
            SetupDataGridView();
           dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void ProductControl_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void ValidateInputs()
        {
            buttonAdd.Enabled = !string.IsNullOrWhiteSpace(textBoxId.Text) &&
                             !string.IsNullOrWhiteSpace(textBoxName.Text);
        }

        private void labeltype_Click(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            Context.Products.Load();
            var list = Context.Products.Local.ToBindingList();
            dataGridView1.DataSource = list;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                DataGridViewButtonCell buttonCell1 = new DataGridViewButtonCell();

                // Create custom text for buttons (Edit & Delete)
                buttonCell.Value = "✏️ Edit ";
                buttonCell1.Value = "🗑 Delete";
                row.Cells["Edit"] = buttonCell;
                row.Cells["Delete"] = buttonCell1;
            }
        }
        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxId.Text, out int id) && double.TryParse(textBoxPrice.Text, out double price))
                {
                    Context.Products.Add(new Entities.Product()
                    {
                        ProductId = id,
                        ProductName = textBoxName.Text,
                        ProductPrice = price,
                        MeasurementType = richTextBoxtype.Text
                    });
                    clearInput();
                    MessageBox.Show("Item added successfully!");
                    loadData();
                    Context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Please enter a valid Product ID and price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't added", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Context = new InventoryContext();
            }
        }
        private void clearInput()
        {
            textBoxId.Text = string.Empty;
            textBoxPrice.Text = string.Empty;
            textBoxName.Text = string.Empty;
            richTextBoxtype.Text = string.Empty;
        }
        private void SetupDataGridView()
        {
            // Ensure the DataGridView is empty before adding new columns
            dataGridView1.Columns.Clear();

            // Auto-generate columns for the data
            dataGridView1.AutoGenerateColumns = false;

            // Create a column for Product ID
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductId", // 👈 Add this
                DataPropertyName = "ProductId",
                HeaderText = "Code",
                ReadOnly = true,
                Width = 50
            });

            // Create a column for Product Name
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductName", // 👈 Add this
                DataPropertyName = "ProductName",
                HeaderText = "Name",
                ReadOnly = true,
                Width = 130
            });

            // Create a column for Product Price
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ProductPrice", // 👈 Add this
                DataPropertyName = "ProductPrice",
                HeaderText = "Price",
                ReadOnly = true,
                Width = 100
            });

            // Create a column for Measurement Type
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "MeasurementType", // 👈 Add this
                DataPropertyName = "MeasurementType",
                HeaderText = "Measurement Type",
                ReadOnly = true,
                Width = 150
            });

            // Create a custom button column for Edit
            DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn()
            {
                Name = "Edit",
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true, // 👈 This sets the button text
                Width = 110
            };

            // Create a custom button column for Delete
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true, // 👈 This sets the button text
                Width = 110
            };

            dataGridView1.Columns.Add(editColumn);
            dataGridView1.Columns.Add(deleteColumn);

            // Load the data
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure it's not the header row
            {
                // Ensure the column names match what we defined in SetupDataGridView
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);
                    DeleteProduct(productId);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int productId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProductId"].Value);
                    editProduct(productId);
                    buttonedit.Enabled=true;
                }
            }
        }

        private void DeleteProduct(int productId)
        {
            try
            {
                var product = Context.Products.FirstOrDefault(p => p.ProductId == productId);
                if (product != null)
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this product?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                        Context.Products.Remove(product);
                        Context.SaveChanges();
                        MessageBox.Show("Product deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();  // ✅ Refresh DataGridView
                    }
                }
                else
                {
                    MessageBox.Show("Product not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Product Can't deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void editProduct(int id)
        {
            var product = Context.Products.FirstOrDefault(p => p.ProductId == id);
            if (product != null)
            {
                textBoxId.Text = id.ToString();
                textBoxId.Enabled = false;
                textBoxName.Text = product.ProductName;
                textBoxPrice.Text = product.ProductPrice.ToString();
                richTextBoxtype.Text = product.MeasurementType;
            }
        }
        private void buttonedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxId.Text, out int id))
                {
                    Product product = Context.Products.FirstOrDefault(p => p.ProductId == id);
                    if (product != null)
                    {
                        double.TryParse(textBoxPrice.Text, out double price);
                        product.ProductName = textBoxName.Text;
                        product.ProductPrice = price;
                        product.MeasurementType = richTextBoxtype.Text;

                        Context.SaveChanges();
                        Context = new InventoryContext();
                        loadData();
                        MessageBox.Show("Product Edited successfully!");
                        clearInput();
                        textBoxId.Enabled = true;
                        buttonedit.Enabled = false;
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
    }
}
