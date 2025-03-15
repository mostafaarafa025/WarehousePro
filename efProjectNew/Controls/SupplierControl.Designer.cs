namespace efProjectNew.Controls
{
    partial class SupplierControl
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
            textBoxWebsite = new TextBox();
            ClientWebsite = new Label();
            textBoxMail = new TextBox();
            ClientMail = new Label();
            textBoxFax = new TextBox();
            ClientFax = new Label();
            textBoxNumber = new TextBox();
            buttonedit = new Button();
            buttonAdd = new Button();
            textBoxhoneNumber = new TextBox();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            ClientPhoneNumber = new Label();
            SupplierName = new Label();
            ClientNumber = new Label();
            supplierLabelId = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(8, 382);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(170, 27);
            textBoxWebsite.TabIndex = 57;
            // 
            // ClientWebsite
            // 
            ClientWebsite.AutoSize = true;
            ClientWebsite.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientWebsite.Location = new Point(11, 355);
            ClientWebsite.Name = "ClientWebsite";
            ClientWebsite.Size = new Size(170, 24);
            ClientWebsite.TabIndex = 56;
            ClientWebsite.Text = "Supplier Website";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(8, 325);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(170, 27);
            textBoxMail.TabIndex = 55;
            // 
            // ClientMail
            // 
            ClientMail.AutoSize = true;
            ClientMail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientMail.Location = new Point(8, 298);
            ClientMail.Name = "ClientMail";
            ClientMail.Size = new Size(132, 24);
            ClientMail.TabIndex = 54;
            ClientMail.Text = "Supplier Mail";
            // 
            // textBoxFax
            // 
            textBoxFax.Location = new Point(8, 268);
            textBoxFax.Name = "textBoxFax";
            textBoxFax.Size = new Size(170, 27);
            textBoxFax.TabIndex = 53;
            // 
            // ClientFax
            // 
            ClientFax.AutoSize = true;
            ClientFax.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientFax.Location = new Point(11, 241);
            ClientFax.Name = "ClientFax";
            ClientFax.Size = new Size(208, 24);
            ClientFax.TabIndex = 52;
            ClientFax.Text = "Supplier Fax Number";
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(8, 211);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(170, 27);
            textBoxNumber.TabIndex = 51;
            // 
            // buttonedit
            // 
            buttonedit.Enabled = false;
            buttonedit.Location = new Point(183, 430);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(94, 29);
            buttonedit.TabIndex = 50;
            buttonedit.Text = "Save";
            buttonedit.UseVisualStyleBackColor = true;
            buttonedit.Click += buttonedit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(28, 430);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 49;
            buttonAdd.Text = "Add Product";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click_1;
            // 
            // textBoxhoneNumber
            // 
            textBoxhoneNumber.Location = new Point(8, 154);
            textBoxhoneNumber.Name = "textBoxhoneNumber";
            textBoxhoneNumber.Size = new Size(170, 27);
            textBoxhoneNumber.TabIndex = 48;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(8, 97);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(170, 27);
            textBoxName.TabIndex = 47;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(11, 40);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(170, 27);
            textBoxId.TabIndex = 46;
            // 
            // ClientPhoneNumber
            // 
            ClientPhoneNumber.AutoSize = true;
            ClientPhoneNumber.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientPhoneNumber.Location = new Point(8, 127);
            ClientPhoneNumber.Name = "ClientPhoneNumber";
            ClientPhoneNumber.Size = new Size(228, 24);
            ClientPhoneNumber.TabIndex = 45;
            ClientPhoneNumber.Text = "Supplier PhoneNumber";
            // 
            // SupplierName
            // 
            SupplierName.AutoSize = true;
            SupplierName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SupplierName.Location = new Point(8, 70);
            SupplierName.Name = "SupplierName";
            SupplierName.Size = new Size(153, 24);
            SupplierName.TabIndex = 44;
            SupplierName.Text = "Supplier Name ";
            // 
            // ClientNumber
            // 
            ClientNumber.AutoSize = true;
            ClientNumber.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientNumber.Location = new Point(8, 184);
            ClientNumber.Name = "ClientNumber";
            ClientNumber.Size = new Size(168, 24);
            ClientNumber.TabIndex = 43;
            ClientNumber.Text = "Supplier Number";
            // 
            // supplierLabelId
            // 
            supplierLabelId.AutoSize = true;
            supplierLabelId.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplierLabelId.Location = new Point(8, 13);
            supplierLabelId.Name = "supplierLabelId";
            supplierLabelId.Size = new Size(111, 24);
            supplierLabelId.TabIndex = 42;
            supplierLabelId.Text = "Supplier Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 32);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(745, 313);
            dataGridView1.TabIndex = 41;
            // 
            // SupplierControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textBoxWebsite);
            Controls.Add(ClientWebsite);
            Controls.Add(textBoxMail);
            Controls.Add(ClientMail);
            Controls.Add(textBoxFax);
            Controls.Add(ClientFax);
            Controls.Add(textBoxNumber);
            Controls.Add(buttonedit);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxhoneNumber);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(ClientPhoneNumber);
            Controls.Add(SupplierName);
            Controls.Add(ClientNumber);
            Controls.Add(supplierLabelId);
            Controls.Add(dataGridView1);
            Name = "SupplierControl";
            Size = new Size(990, 473);
            Load += SupplierControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxWebsite;
        private Label ClientWebsite;
        private TextBox textBoxMail;
        private Label ClientMail;
        private TextBox textBoxFax;
        private Label ClientFax;
        private TextBox textBoxNumber;
        private Button buttonedit;
        private Button buttonAdd;
        private TextBox textBoxhoneNumber;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label ClientPhoneNumber;
        private Label SupplierName;
        private Label ClientNumber;
        private Label supplierLabelId;
        private DataGridView dataGridView1;
    }
}
