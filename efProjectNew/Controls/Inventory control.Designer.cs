namespace efProjectNew
{
    partial class Inventory_control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            InventoryLabel = new Label();
            labelAdress = new Label();
            labelName = new Label();
            labelManager = new Label();
            textBoxId = new TextBox();
            textBoxName = new TextBox();
            textBoxManager = new TextBox();
            richTextBoxAddress = new RichTextBox();
            buttonAdd = new Button();
            buttonedit = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(257, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(728, 313);
            dataGridView1.TabIndex = 0;
            // 
            // InventoryLabel
            // 
            InventoryLabel.AutoSize = true;
            InventoryLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InventoryLabel.Location = new Point(22, 1);
            InventoryLabel.Name = "InventoryLabel";
            InventoryLabel.Size = new Size(193, 24);
            InventoryLabel.TabIndex = 2;
            InventoryLabel.Text = "Inventory Number *";
            // 
            // labelAdress
            // 
            labelAdress.AutoSize = true;
            labelAdress.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAdress.Location = new Point(22, 224);
            labelAdress.Name = "labelAdress";
            labelAdress.Size = new Size(170, 24);
            labelAdress.TabIndex = 3;
            labelAdress.Text = "Inventory Adress";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(22, 76);
            labelName.Name = "labelName";
            labelName.Size = new Size(172, 24);
            labelName.TabIndex = 4;
            labelName.Text = "Inventory Name *";
            // 
            // labelManager
            // 
            labelManager.AutoSize = true;
            labelManager.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelManager.Location = new Point(22, 149);
            labelManager.Name = "labelManager";
            labelManager.Size = new Size(187, 24);
            labelManager.TabIndex = 5;
            labelManager.Text = "Inventory Manager";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(25, 28);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(170, 27);
            textBoxId.TabIndex = 6;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(22, 103);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(170, 27);
            textBoxName.TabIndex = 7;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxManager
            // 
            textBoxManager.Location = new Point(25, 176);
            textBoxManager.Name = "textBoxManager";
            textBoxManager.Size = new Size(170, 27);
            textBoxManager.TabIndex = 8;
            // 
            // richTextBoxAddress
            // 
            richTextBoxAddress.Location = new Point(25, 260);
            richTextBoxAddress.Name = "richTextBoxAddress";
            richTextBoxAddress.Size = new Size(173, 64);
            richTextBoxAddress.TabIndex = 9;
            richTextBoxAddress.Text = "";
            // 
            // buttonAdd
            // 
            buttonAdd.Enabled = false;
            buttonAdd.Location = new Point(56, 355);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 10;
            buttonAdd.Text = "Add Product";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonedit
            // 
            buttonedit.Enabled = false;
            buttonedit.Location = new Point(223, 355);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(94, 29);
            buttonedit.TabIndex = 11;
            buttonedit.Text = "Save";
            buttonedit.UseVisualStyleBackColor = true;
            buttonedit.Click += buttonedit_Click;
            // 
            // Inventory_control
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonedit);
            Controls.Add(buttonAdd);
            Controls.Add(richTextBoxAddress);
            Controls.Add(textBoxManager);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(labelManager);
            Controls.Add(labelName);
            Controls.Add(labelAdress);
            Controls.Add(InventoryLabel);
            Controls.Add(dataGridView1);
            Name = "Inventory_control";
            Size = new Size(990, 473);
            Load += Inventory_control_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label InventoryLabel;
        private Label labelAdress;
        private Label labelName;
        private Label labelManager;
        private TextBox textBoxId;
        private TextBox textBoxName;
        private TextBox textBoxManager;
        private RichTextBox richTextBoxAddress;
        private Button buttonAdd;
        private Label label3;
        private Label label4;
        private Button buttonedit;
    }
}
