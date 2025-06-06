﻿namespace efProjectNew
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelNavbar = new Panel();
            lblTitle = new Label();
            btnMenu = new Button();
            panel1 = new Panel();
            panelMenu = new Panel();
            label1 = new Label();
            InventoryItemLabel = new Label();
            clientLabel = new Label();
            ProductsLabel = new Label();
            suppliersLabel = new Label();
            InventoryLabel = new Label();
            panelNavbar.SuspendLayout();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelNavbar
            // 
            panelNavbar.BackColor = Color.Blue;
            panelNavbar.Controls.Add(lblTitle);
            panelNavbar.Controls.Add(btnMenu);
            panelNavbar.Dock = DockStyle.Top;
            panelNavbar.Location = new Point(0, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(1068, 42);
            panelNavbar.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Arial", 13.8F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FloralWhite;
            lblTitle.Location = new Point(336, 7);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(285, 27);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Warehouse Management";
            lblTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnMenu
            // 
            btnMenu.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Bold);
            btnMenu.Location = new Point(1, 0);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(42, 40);
            btnMenu.TabIndex = 1;
            btnMenu.Text = "☰";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightCyan;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(1068, 528);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint_1;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlLightLight;
            panelMenu.Controls.Add(label1);
            panelMenu.Controls.Add(InventoryItemLabel);
            panelMenu.Controls.Add(clientLabel);
            panelMenu.Controls.Add(ProductsLabel);
            panelMenu.Controls.Add(suppliersLabel);
            panelMenu.Controls.Add(InventoryLabel);
            panelMenu.Location = new Point(0, 42);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(164, 528);
            panelMenu.TabIndex = 1;
            panelMenu.TabStop = true;
            panelMenu.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlLightLight;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(5, 233);
            label1.Name = "label1";
            label1.Size = new Size(155, 28);
            label1.TabIndex = 7;
            label1.Text = "Entry Vouchers";
            label1.Click += label1_Click;
            // 
            // InventoryItemLabel
            // 
            InventoryItemLabel.AutoSize = true;
            InventoryItemLabel.BackColor = SystemColors.ControlLightLight;
            InventoryItemLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            InventoryItemLabel.ForeColor = Color.Blue;
            InventoryItemLabel.Location = new Point(2, 194);
            InventoryItemLabel.Name = "InventoryItemLabel";
            InventoryItemLabel.Size = new Size(164, 28);
            InventoryItemLabel.TabIndex = 6;
            InventoryItemLabel.Text = "Inventory_Items";
            InventoryItemLabel.Click += InventoryItemLabel_Click;
            // 
            // clientLabel
            // 
            clientLabel.AutoSize = true;
            clientLabel.BackColor = SystemColors.ControlLightLight;
            clientLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            clientLabel.ForeColor = Color.Blue;
            clientLabel.Location = new Point(23, 151);
            clientLabel.Name = "clientLabel";
            clientLabel.Size = new Size(76, 28);
            clientLabel.TabIndex = 4;
            clientLabel.Text = "Clients";
            clientLabel.Click += clientLabel_Click;
            // 
            // ProductsLabel
            // 
            ProductsLabel.AutoSize = true;
            ProductsLabel.BackColor = SystemColors.ControlLightLight;
            ProductsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ProductsLabel.ForeColor = Color.Blue;
            ProductsLabel.Location = new Point(23, 61);
            ProductsLabel.Name = "ProductsLabel";
            ProductsLabel.Size = new Size(95, 28);
            ProductsLabel.TabIndex = 5;
            ProductsLabel.Text = "Products";
            ProductsLabel.Click += ProductsLabel_Click;
            // 
            // suppliersLabel
            // 
            suppliersLabel.AutoSize = true;
            suppliersLabel.BackColor = SystemColors.ControlLightLight;
            suppliersLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            suppliersLabel.ForeColor = Color.Blue;
            suppliersLabel.Location = new Point(23, 106);
            suppliersLabel.Name = "suppliersLabel";
            suppliersLabel.Size = new Size(99, 28);
            suppliersLabel.TabIndex = 3;
            suppliersLabel.Text = "Suppliers";
            suppliersLabel.Click += suppliersLabel_Click;
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.BackColor = SystemColors.ControlLightLight;
            InventoryLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            InventoryLabel.ForeColor = Color.Blue;
            InventoryLabel.Location = new Point(23, 16);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(104, 28);
            InventoryLabel.TabIndex = 2;
            InventoryLabel.Text = "Inventory";
            InventoryLabel.Click += InventoryLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1068, 570);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            Controls.Add(panelNavbar);
            Name = "Form1";
            Text = "Home page";
            Load += Form1_Load;
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            panelMenu.ResumeLayout(false);
            panelMenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNavbar;
        private Button btnMenu;
        private Label lblTitle;
        private Panel panelMenu;
        private Label InventoryLabel;
        private Label ProductsLabel;
        private Label suppliersLabel;
        private Label clientLabel;
        private Panel panel1;
        private Label InventoryItemLabel;
        private Label label1;
    }
}
