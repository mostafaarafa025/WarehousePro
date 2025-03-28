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
using Microsoft.EntityFrameworkCore;

namespace efProjectNew.Controls
{
    public partial class Inventory_Items : UserControl
    {
        InventoryContext Context;
        public Inventory_Items()
        {
            InitializeComponent();
            Context = new InventoryContext();
            LoadAllInventoryItems();

        }
        private void LoadAllInventoryItems()
        {
            var inventoryItemsList = Context.InventoryItems
                .Select(ii => new
                {
                    ii.InventoryId,
                    InventoryName = ii.Inventory.Name,
                    ii.ProductId,
                    ProductName = ii.Product.ProductName,
                    ii.Quantity
                })
                .ToList();

            dataGridView1.DataSource = inventoryItemsList;
        }


        private void SearchByProductId(int productId)
        {
            var filteredList = Context.InventoryItems
                .Where(ii => ii.ProductId == productId)
                .Select(ii => new
                {
                    ii.InventoryId,
                    InventoryName = ii.Inventory.Name,
                    ii.ProductId,
                    ProductName = ii.Product.ProductName,
                    ii.Quantity
                })
                .ToList();

            dataGridView1.DataSource = filteredList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int productId))
            {
                SearchByProductId(productId);
            }
            else if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                LoadAllInventoryItems(); 
            }
        }
    }
}
