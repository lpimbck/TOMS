namespace TOMS
{
    partial class TableDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.buttonAdd = new global::System.Windows.Forms.Button();
            this.label3 = new global::System.Windows.Forms.Label();
            this.fieldName = new global::System.Windows.Forms.TextBox();
            this.fieldQuan = new global::System.Windows.Forms.TextBox();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.fieldId = new global::System.Windows.Forms.TextBox();
            this.groupBox2 = new global::System.Windows.Forms.GroupBox();
            this.button1 = new global::System.Windows.Forms.Button();
            this.dataGridView1 = new global::System.Windows.Forms.DataGridView();
            this.ItemName = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quan = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new global::System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((global::System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fieldName);
            this.groupBox1.Controls.Add(this.fieldQuan);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fieldId);
            this.groupBox1.Location = new global::System.Drawing.Point(3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new global::System.Drawing.Size(734, 789);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Items";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new global::System.Drawing.Point(597, 103);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new global::System.Drawing.Size(83, 25);
            this.buttonAdd.TabIndex = 6;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new global::System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new global::System.Drawing.Point(328, 111);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // fieldName
            // 
            this.fieldName.Location = new global::System.Drawing.Point(379, 106);
            this.fieldName.Name = "fieldName";
            this.fieldName.Size = new global::System.Drawing.Size(212, 22);
            this.fieldName.TabIndex = 4;
            // 
            // fieldQuan
            // 
            this.fieldQuan.Location = new global::System.Drawing.Point(222, 108);
            this.fieldQuan.Name = "fieldQuan";
            this.fieldQuan.Size = new global::System.Drawing.Size(100, 22);
            this.fieldQuan.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new global::System.Drawing.Point(155, 113);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantity";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(28, 113);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(19, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id";
            // 
            // fieldId
            // 
            this.fieldId.Location = new global::System.Drawing.Point(53, 108);
            this.fieldId.Name = "fieldId";
            this.fieldId.Size = new global::System.Drawing.Size(96, 22);
            this.fieldId.TabIndex = 0;
            this.fieldId.Leave += new global::System.EventHandler(this.fieldId_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new global::System.Drawing.Point(768, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new global::System.Drawing.Size(584, 781);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Items";
            // 
            // button1
            // 
            this.button1.Location = new global::System.Drawing.Point(219, 612);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(211, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "Check Out";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new global::System.EventHandler(this.checkOutClick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = global::System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new global::System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.Quan,
            this.Price,
            this.Sum});
            this.dataGridView1.Location = new global::System.Drawing.Point(6, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new global::System.Drawing.Size(572, 501);
            this.dataGridView1.TabIndex = 0;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemName.HeaderText = "Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // Quan
            // 
            this.Quan.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quan.HeaderText = "Quan";
            this.Quan.Name = "Quan";
            this.Quan.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.AutoSizeMode = global::System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sum.HeaderText = "Sum";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // TableDetails
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new global::System.Drawing.Size(1364, 805);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TableDetails";
            this.Text = "Table Details";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((global::System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.GroupBox groupBox2;
        private global::System.Windows.Forms.Button button1;
        private global::System.Windows.Forms.DataGridView dataGridView1;
        private global::System.Windows.Forms.Button buttonAdd;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.TextBox fieldName;
        private global::System.Windows.Forms.TextBox fieldQuan;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.TextBox fieldId;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Quan;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private global::System.Windows.Forms.DataGridViewTextBoxColumn Sum;
    }
}