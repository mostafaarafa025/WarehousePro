using efProjectNew.context;
using efProjectNew.Controls;
using Microsoft.EntityFrameworkCore;

namespace efProjectNew
{
    public partial class Form1 : Form
    {
        private bool isMenuOpen = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"D:\iti\entityFramework\ashley-_ZRWgz-a60Q-unsplash.jpg");
            this.BackgroundImageLayout = ImageLayout.Stretch;
            panelMenu.Visible = false;
            panel1.Visible = false;
            //InventoryContext context = new InventoryContext();
            //context.Database.Migrate();


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            panelMenu.Visible = !panelMenu.Visible;
            panelMenu.BringToFront();
        }
        private void LoadUserControl(UserControl userControl)
        {
            panel1.Visible = true;
            panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            panel1.Controls.Add(userControl);
        }


        private void InventoryLabel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Inventory_control()); 
            panelMenu.Visible = false;
        }

        private void ProductsLabel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ProductControl());
            panelMenu.Visible = false;
        }

        private void suppliersLabel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SupplierControl());
            panelMenu.Visible = false;
        }

        private void clientLabel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ClientControl());
            panelMenu.Visible = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void InventoryItemLabel_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Inventory_Items());
            panelMenu.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new Entry_Vouchers());
            panelMenu.Visible = false;
        }
    }
}
