namespace efProjectNew.Controls
{
    partial class ClientControl
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
            buttonedit = new Button();
            buttonAdd = new Button();
            textBoxhoneNumber = new TextBox();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            ClientPhoneNumber = new Label();
            ClientName = new Label();
            ClientNumber = new Label();
            ClientLabelId = new Label();
            dataGridView1 = new DataGridView();
            textBoxNumber = new TextBox();
            textBoxFax = new TextBox();
            ClientFax = new Label();
            textBoxMail = new TextBox();
            ClientMail = new Label();
            textBoxWebsite = new TextBox();
            ClientWebsite = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonedit
            // 
            buttonedit.Enabled = false;
            buttonedit.Location = new Point(187, 422);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(94, 29);
            buttonedit.TabIndex = 33;
            buttonedit.Text = "Save";
            buttonedit.UseVisualStyleBackColor = true;
            buttonedit.Click += buttonedit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(32, 422);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 32;
            buttonAdd.Text = "Add Product";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // textBoxhoneNumber
            // 
            textBoxhoneNumber.Location = new Point(12, 146);
            textBoxhoneNumber.Name = "textBoxhoneNumber";
            textBoxhoneNumber.Size = new Size(170, 27);
            textBoxhoneNumber.TabIndex = 30;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(12, 89);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(170, 27);
            textBoxName.TabIndex = 29;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(15, 32);
            textBoxId.Name = "textBoxId";
            textBoxId.ReadOnly = true;
            textBoxId.Size = new Size(170, 27);
            textBoxId.TabIndex = 28;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // ClientPhoneNumber
            // 
            ClientPhoneNumber.AutoSize = true;
            ClientPhoneNumber.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientPhoneNumber.Location = new Point(12, 119);
            ClientPhoneNumber.Name = "ClientPhoneNumber";
            ClientPhoneNumber.Size = new Size(204, 24);
            ClientPhoneNumber.TabIndex = 27;
            ClientPhoneNumber.Text = "Client PhoneNumber";
            // 
            // ClientName
            // 
            ClientName.AutoSize = true;
            ClientName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientName.Location = new Point(12, 62);
            ClientName.Name = "ClientName";
            ClientName.Size = new Size(129, 24);
            ClientName.TabIndex = 26;
            ClientName.Text = "Client Name ";
            // 
            // ClientNumber
            // 
            ClientNumber.AutoSize = true;
            ClientNumber.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientNumber.Location = new Point(12, 176);
            ClientNumber.Name = "ClientNumber";
            ClientNumber.Size = new Size(144, 24);
            ClientNumber.TabIndex = 25;
            ClientNumber.Text = "Client Number";
            // 
            // ClientLabelId
            // 
            ClientLabelId.AutoSize = true;
            ClientLabelId.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientLabelId.Location = new Point(12, 5);
            ClientLabelId.Name = "ClientLabelId";
            ClientLabelId.Size = new Size(87, 24);
            ClientLabelId.TabIndex = 24;
            ClientLabelId.Text = "Client Id";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(242, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(745, 313);
            dataGridView1.TabIndex = 23;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(12, 203);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(170, 27);
            textBoxNumber.TabIndex = 34;
            // 
            // textBoxFax
            // 
            textBoxFax.Location = new Point(12, 260);
            textBoxFax.Name = "textBoxFax";
            textBoxFax.Size = new Size(170, 27);
            textBoxFax.TabIndex = 36;
            // 
            // ClientFax
            // 
            ClientFax.AutoSize = true;
            ClientFax.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientFax.Location = new Point(15, 233);
            ClientFax.Name = "ClientFax";
            ClientFax.Size = new Size(184, 24);
            ClientFax.TabIndex = 35;
            ClientFax.Text = "Client Fax Number";
            // 
            // textBoxMail
            // 
            textBoxMail.Location = new Point(12, 317);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(170, 27);
            textBoxMail.TabIndex = 38;
            // 
            // ClientMail
            // 
            ClientMail.AutoSize = true;
            ClientMail.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientMail.Location = new Point(12, 290);
            ClientMail.Name = "ClientMail";
            ClientMail.Size = new Size(108, 24);
            ClientMail.TabIndex = 37;
            ClientMail.Text = "Client Mail";
            // 
            // textBoxWebsite
            // 
            textBoxWebsite.Location = new Point(12, 374);
            textBoxWebsite.Name = "textBoxWebsite";
            textBoxWebsite.Size = new Size(170, 27);
            textBoxWebsite.TabIndex = 40;
            // 
            // ClientWebsite
            // 
            ClientWebsite.AutoSize = true;
            ClientWebsite.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ClientWebsite.Location = new Point(15, 347);
            ClientWebsite.Name = "ClientWebsite";
            ClientWebsite.Size = new Size(146, 24);
            ClientWebsite.TabIndex = 39;
            ClientWebsite.Text = "Client Website";
            // 
            // ClientControl
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
            Controls.Add(ClientName);
            Controls.Add(ClientNumber);
            Controls.Add(ClientLabelId);
            Controls.Add(dataGridView1);
            Name = "ClientControl";
            Size = new Size(990, 473);
            Load += ClientControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonedit;
        private Button buttonAdd;
        private TextBox textBoxhoneNumber;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label ClientPhoneNumber;
        private Label ClientName;
        private Label ClientNumber;
        private Label ClientLabelId;
        private DataGridView dataGridView1;
        private TextBox textBoxNumber;
        private TextBox textBoxFax;
        private Label ClientFax;
        private TextBox textBoxMail;
        private Label ClientMail;
        private TextBox textBoxWebsite;
        private Label ClientWebsite;
    }
}
