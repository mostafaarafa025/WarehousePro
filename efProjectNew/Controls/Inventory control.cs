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

namespace efProjectNew
{
    public partial class Inventory_control : UserControl
    {
        InventoryContext Context;
        public Inventory_control()
        {
            InitializeComponent();
            Context = new InventoryContext();
            SetupDataGridView();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
        }

        private void ValidateInputs()
        {
            buttonAdd.Enabled = !string.IsNullOrWhiteSpace(textBoxId.Text) &&
                             !string.IsNullOrWhiteSpace(textBoxName.Text);
        }
        private void Inventory_control_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxId.Text, out int inventoryId))
                {
                    Context.Inventories.Add(new Entities.Inventory()
                    {
                        InventoryId = inventoryId,
                        Name = textBoxName.Text,
                        ManagerName = textBoxManager.Text,
                        Address = richTextBoxAddress.Text
                    });
                    Context.SaveChanges();
                    MessageBox.Show("Inventory added successfully!");
                    loadData();
                    clearText();
                }
                else
                {
                    MessageBox.Show("Please enter a valid number for Inventory ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("can't added", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Context = new InventoryContext();
            }
        }
        private void loadData()
        {
            Context = new InventoryContext();
            var list = Context.Inventories.ToList();
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
        private void clearText()
        {
            textBoxId.Text = "";
            textBoxName.Text = "";
            textBoxManager.Text = "";
            richTextBoxAddress.Text = "";
        }

     
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateInputs();
        }


        private void SetupDataGridView()
        {
            // Ensure the DataGridView is empty before adding new columns
            dataGridView1.Columns.Clear();

            // Auto-generate columns for the data
            dataGridView1.AutoGenerateColumns = false;

          
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "InventoryId", 
                DataPropertyName = "InventoryId",
                HeaderText = "Inventory Id",
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
                Name = "Address", 
                DataPropertyName = "Address",
                HeaderText = "Address",
                ReadOnly = true,
                Width = 150
            });

           
            dataGridView1.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "ManagerName", // 👈 Add this
                DataPropertyName = "ManagerName",
                HeaderText = "ManagerName",
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
                Width = 100
            };

            // Create a custom button column for Delete
            DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn()
            {
                Name = "Delete",
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true, // 👈 This sets the button text
                Width = 100
            };

            dataGridView1.Columns.Add(editColumn);
            dataGridView1.Columns.Add(deleteColumn);

            // Load the data
            loadData();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) 
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int InventoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["InventoryId"].Value);
                   DeleteInventory(InventoryId);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int InventoryId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["InventoryId"].Value);
                    buttonedit.Enabled=true;
                    editInventory(InventoryId);
                }
            }
        }

        private void DeleteInventory(int inventoryId)
        {
           
                var Inventory = Context.Inventories.FirstOrDefault(p => p.InventoryId == inventoryId);
                if (Inventory != null)
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this Inventory?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                    try
                    {
                        Context.Inventories.Remove(Inventory);
                        Context.SaveChanges();
                        MessageBox.Show("Inventory deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch
                    {
                        MessageBox.Show("Inventory Can't deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    }
                }
                else
                {
                    MessageBox.Show("Inventory not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
          
        }
        private void editInventory(int id)
        {
            var Inventory = Context.Inventories.FirstOrDefault(p => p.InventoryId == id);
            if (Inventory != null)
            {
                textBoxId.Text = id.ToString();
                textBoxId.Enabled = false;
                textBoxName.Text = Inventory.Name;
                textBoxManager.Text = Inventory.ManagerName;
                richTextBoxAddress.Text = Inventory.Address;
            }
        }
        private void buttonedit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxId.Text, out int id))
            {
                Inventory Inventory = Context.Inventories.FirstOrDefault(p => p.InventoryId == id);
                if (Inventory != null)
                {
                   
                    Inventory.Name = textBoxName.Text;
                    Inventory.ManagerName = textBoxManager.Text;
                    Inventory.Address = richTextBoxAddress.Text;

                    Context.SaveChanges();
                    Context = new InventoryContext();
                    loadData();
                    MessageBox.Show("Product Edited successfully!");
                    clearText();
                    textBoxId.Enabled = true;
                    buttonedit.Enabled = false;
                }
            }
        }

    }
}
