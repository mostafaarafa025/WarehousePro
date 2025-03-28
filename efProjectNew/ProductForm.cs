using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using efProjectNew.Controls;

namespace efProjectNew
{
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
            efProjectNew.Controls.ProductControl p = new efProjectNew.Controls.ProductControl();

            this.Controls.Add(p);

            p.Dock = DockStyle.Fill;
        }
    }
}
