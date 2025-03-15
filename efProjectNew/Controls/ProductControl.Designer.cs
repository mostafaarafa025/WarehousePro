namespace efProjectNew.Controls
{
    partial class ProductControl
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
            richTextBoxtype = new RichTextBox();
            textBoxPrice = new TextBox();
            textBoxName = new TextBox();
            textBoxId = new TextBox();
            labelprice = new Label();
            labelName = new Label();
            labeltype = new Label();
            itemLabelId = new Label();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // buttonedit
            // 
            buttonedit.Enabled = false;
            buttonedit.Location = new Point(198, 360);
            buttonedit.Name = "buttonedit";
            buttonedit.Size = new Size(94, 29);
            buttonedit.TabIndex = 22;
            buttonedit.Text = "Save";
            buttonedit.UseVisualStyleBackColor = true;
            buttonedit.Click += buttonedit_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Enabled = false;
            buttonAdd.Location = new Point(57, 360);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 21;
            buttonAdd.Text = "Add Product";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // richTextBoxtype
            // 
            richTextBoxtype.Location = new Point(60, 267);
            richTextBoxtype.Name = "richTextBoxtype";
            richTextBoxtype.Size = new Size(173, 64);
            richTextBoxtype.TabIndex = 20;
            richTextBoxtype.Text = "";
            // 
            // textBoxPrice
            // 
            textBoxPrice.Location = new Point(60, 183);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(170, 27);
            textBoxPrice.TabIndex = 19;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(57, 110);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(170, 27);
            textBoxName.TabIndex = 18;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(60, 35);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(170, 27);
            textBoxId.TabIndex = 17;
            textBoxId.TextChanged += textBoxId_TextChanged;
            // 
            // labelprice
            // 
            labelprice.AutoSize = true;
            labelprice.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelprice.Location = new Point(57, 156);
            labelprice.Name = "labelprice";
            labelprice.Size = new Size(104, 24);
            labelprice.TabIndex = 16;
            labelprice.Text = "Item Price";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelName.Location = new Point(57, 83);
            labelName.Name = "labelName";
            labelName.Size = new Size(123, 24);
            labelName.TabIndex = 15;
            labelName.Text = "Item Name *";
            // 
            // labeltype
            // 
            labeltype.AutoSize = true;
            labeltype.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltype.Location = new Point(57, 231);
            labeltype.Name = "labeltype";
            labeltype.Size = new Size(185, 24);
            labeltype.TabIndex = 14;
            labeltype.Text = "Measurement type";
            labeltype.Click += labeltype_Click;
            // 
            // itemLabelId
            // 
            itemLabelId.AutoSize = true;
            itemLabelId.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemLabelId.Location = new Point(57, 8);
            itemLabelId.Name = "itemLabelId";
            itemLabelId.Size = new Size(113, 24);
            itemLabelId.TabIndex = 13;
            itemLabelId.Text = "Item Code*";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(279, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(703, 313);
            dataGridView1.TabIndex = 12;
            // 
            // ProductControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonedit);
            Controls.Add(buttonAdd);
            Controls.Add(richTextBoxtype);
            Controls.Add(textBoxPrice);
            Controls.Add(textBoxName);
            Controls.Add(textBoxId);
            Controls.Add(labelprice);
            Controls.Add(labelName);
            Controls.Add(labeltype);
            Controls.Add(itemLabelId);
            Controls.Add(dataGridView1);
            Name = "ProductControl";
            Size = new Size(990, 473);
            Load += ProductControl_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonedit;
        private Button buttonAdd;
        private RichTextBox richTextBoxtype;
        private TextBox textBoxPrice;
        private TextBox textBoxName;
        private TextBox textBoxId;
        private Label labelprice;
        private Label labelName;
        private Label labeltype;
        private Label itemLabelId;
        private DataGridView dataGridView1;
    }
}
