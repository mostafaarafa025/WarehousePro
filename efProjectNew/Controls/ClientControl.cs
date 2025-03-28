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
    public partial class ClientControl : UserControl
    {
        InventoryContext Context;
        public ClientControl()
        {
            Context = new InventoryContext();
            InitializeComponent();
            SetupDataGridView();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;

        }


        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            // ValidateInputs();
        }
        private void loadData()
        {
          
            var list = Context.Clients.ToList();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new Entities.Client()
                {
                    Name = textBoxName.Text,
                    PhoneNumber = textBoxhoneNumber.Text,
                    Number = textBoxNumber.Text,
                    FaxNumber = textBoxFax.Text,
                    Email = textBoxMail.Text,
                    WebSite = textBoxWebsite.Text
                };

                Context.Clients.Add(client);
                Context.SaveChanges();
                Context.Clients.Load(); // Force refresh
                loadData();

                clearInput();
                MessageBox.Show("Client added successfully!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void clearInput()
        {
            textBoxId.Text =string.Empty;
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
                Name = "ClientId",
                DataPropertyName = "ClientId",
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
            if (e.RowIndex >= 0) // Ensure it's not the header row
            {
                // Ensure the column names match what we defined in SetupDataGridView
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
                {
                    int clientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ClientId"].Value);
                    DeleteClient(clientId);
                }
                else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
                {
                    int clientId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ClientId"].Value);
                    editClient(clientId);
                    buttonedit.Enabled = true;
                    buttonAdd.Enabled = false;
                }
            }
        }

        private void textBoxId_TextChanged(object sender, EventArgs e)
        {
            //ValidateInputs();
        }

        private void ClientControl_Load(object sender, EventArgs e)
        {
            loadData();
        }
        private void DeleteClient(int clientId)
        {
            
                var client = Context.Clients.FirstOrDefault(p => p.ClientId == clientId);
                if (client != null)
                {
                    var confirm = MessageBox.Show("Are you sure you want to delete this client?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                    try
                    {
                        Context.Clients.Remove(client);
                        Context.SaveChanges();
                        MessageBox.Show("client deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadData();
                    }
                    catch
                    {
                        MessageBox.Show("client Can't deleted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                }
                else
                {
                    MessageBox.Show("client not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
           
          
        }
        private void editClient(int id)
        {
            var client = Context.Clients.FirstOrDefault(p => p.ClientId == id);
            if (client != null)
            {
                textBoxId.Text = id.ToString();
                textBoxName.Text = client.Name;
                textBoxNumber.Text = client.Number;
                textBoxhoneNumber.Text = client.PhoneNumber;
                textBoxFax.Text = client.FaxNumber;
                textBoxMail.Text = client.Email;
                textBoxWebsite.Text = client.WebSite;
            }
        }

        private void buttonedit_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(textBoxId.Text, out int id))
                {
                    Client client = Context.Clients.FirstOrDefault(p => p.ClientId == id);
                    if (client != null)
                    {
                     
                        client.Name=textBoxName.Text;
                        client.Number=textBoxNumber.Text;
                        client.Email=textBoxMail.Text;
                        client.PhoneNumber=textBoxhoneNumber.Text;
                        client.FaxNumber=textBoxFax.Text;
                        client.WebSite=textBoxWebsite.Text;

                        Context.SaveChanges();
                        Context = new InventoryContext();
                        loadData();
                        MessageBox.Show("client Edited successfully!");
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
    }
}
