namespace efProjectNew
{
    partial class EntryVouchersForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxInventory = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            comboBoxSupplier = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBoxReference = new TextBox();
            textBoxdate = new TextBox();
            label5 = new Label();
            comboBoxProduct = new ComboBox();
            buttonAddProduct = new Button();
            dataGridView1 = new DataGridView();
            buttonSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // comboBoxInventory
            // 
            comboBoxInventory.FormattingEnabled = true;
            comboBoxInventory.Location = new Point(12, 27);
            comboBoxInventory.Name = "comboBoxInventory";
            comboBoxInventory.Size = new Size(151, 28);
            comboBoxInventory.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 1;
            label1.Text = "Inventory";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 3;
            label2.Text = "Supplier";
            // 
            // comboBoxSupplier
            // 
            comboBoxSupplier.FormattingEnabled = true;
            comboBoxSupplier.Location = new Point(12, 84);
            comboBoxSupplier.Name = "comboBoxSupplier";
            comboBoxSupplier.Size = new Size(151, 28);
            comboBoxSupplier.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(133, 20);
            label3.TabIndex = 4;
            label3.Text = "Reference Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 5;
            label4.Text = "Date";
            // 
            // textBoxReference
            // 
            textBoxReference.Location = new Point(12, 143);
            textBoxReference.Name = "textBoxReference";
            textBoxReference.Size = new Size(125, 27);
            textBoxReference.TabIndex = 6;
            // 
            // textBoxdate
            // 
            textBoxdate.Location = new Point(12, 203);
            textBoxdate.Name = "textBoxdate";
            textBoxdate.Size = new Size(125, 27);
            textBoxdate.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 4);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 9;
            label5.Text = "Product";
            // 
            // comboBoxProduct
            // 
            comboBoxProduct.FormattingEnabled = true;
            comboBoxProduct.Location = new Point(302, 27);
            comboBoxProduct.Name = "comboBoxProduct";
            comboBoxProduct.Size = new Size(151, 28);
            comboBoxProduct.TabIndex = 8;
            comboBoxProduct.SelectedIndexChanged += comboBoxProduct_SelectedIndexChanged;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = SystemColors.MenuHighlight;
            buttonAddProduct.Location = new Point(459, 26);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(35, 28);
            buttonAddProduct.TabIndex = 10;
            buttonAddProduct.Text = "+";
            buttonAddProduct.UseVisualStyleBackColor = false;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(216, 84);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(667, 365);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.MenuHighlight;
            buttonSave.Location = new Point(742, 464);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(99, 31);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // EntryVouchersForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(895, 507);
            Controls.Add(buttonSave);
            Controls.Add(dataGridView1);
            Controls.Add(buttonAddProduct);
            Controls.Add(label5);
            Controls.Add(comboBoxProduct);
            Controls.Add(textBoxdate);
            Controls.Add(textBoxReference);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxSupplier);
            Controls.Add(label1);
            Controls.Add(comboBoxInventory);
            Name = "EntryVouchersForm";
            Text = "EntryVouchersForm";
            Load += EntryVouchersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxInventory;
        private Label label1;
        private Label label2;
        private ComboBox comboBoxSupplier;
        private Label label3;
        private Label label4;
        private TextBox textBoxReference;
        private TextBox textBoxdate;
        private Label label5;
        private ComboBox comboBoxProduct;
        private Button buttonAddProduct;
        private DataGridView dataGridView1;
        private Button buttonSave;
    }
}