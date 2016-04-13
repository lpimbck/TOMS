
namespace TOMS
{
    partial class Home
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
        /// 
        private void addTableButtons()
        {
            int top = 34;
            int left = 142;
            int tabindex = 17;
            for (int i=0; i<System.Instance.getNumberofTables();i++)
            {
                global::System.Windows.Forms.Button button = new global::System.Windows.Forms.Button();
                button.Location = new global::System.Drawing.Point(top,left);
                button.Margin = new global::System.Windows.Forms.Padding(4);
                button.Name = "button"+i;
                button.Tag = System.Instance.getTable(i);
                button.Size = new global::System.Drawing.Size(183, 84);
                button.TabIndex = tabindex++;
                button.Text = "Table"+(i+1);
                if (System.Instance.getTable(i).getOccupiedStatus()) {
                    button.BackColor = global::System.Drawing.Color.Orange;
                } else {
                    button.BackColor = global::System.Drawing.Color.LightGreen;
                }
                button.UseVisualStyleBackColor = false;
                button.Click += new global::System.EventHandler(this.tableClick);
                this.tableLayout.Controls.Add(button);
                top = top + 220;
                if (top>600) { left = left + 275; top = 34; }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayout = new global::System.Windows.Forms.GroupBox();
            this.button10 = new global::System.Windows.Forms.Button();
            this.menuReload = new global::System.Windows.Forms.Button();
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label4 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.groupBox2 = new global::System.Windows.Forms.GroupBox();
            this.tableLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.Controls.Add(this.button10);
            this.tableLayout.Controls.Add(this.menuReload);
            this.tableLayout.Location = new global::System.Drawing.Point(24, 23);
            this.tableLayout.Margin = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.Padding = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayout.Size = new global::System.Drawing.Size(1174, 1417);
            this.tableLayout.TabIndex = 1;
            this.tableLayout.TabStop = false;
            this.tableLayout.Text = "Layout";
            // 
            // button10
            // 
            this.button10.Location = new global::System.Drawing.Point(474, 0);
            this.button10.Margin = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button10.Name = "button10";
            this.button10.Size = new global::System.Drawing.Size(254, 147);
            this.button10.TabIndex = 27;
            this.button10.Text = "Entrance";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // menuReload
            // 
            this.menuReload.Location = new global::System.Drawing.Point(728, 36);
            this.menuReload.Margin = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.menuReload.Name = "menuReload";
            this.menuReload.Size = new global::System.Drawing.Size(222, 75);
            this.menuReload.TabIndex = 26;
            this.menuReload.Text = "Menu Reload";
            this.menuReload.UseVisualStyleBackColor = true;
            this.menuReload.Click += new global::System.EventHandler(this.menuReloadClick);

            this.addTableButtons();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new global::System.Drawing.Point(1210, 819);
            this.groupBox1.Margin = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new global::System.Drawing.Size(1006, 622);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new global::System.Drawing.Point(183, 158);
            this.label3.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(29, 31);
            this.label3.TabIndex = 70;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new global::System.Drawing.Point(50, 158);
            this.label4.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(137, 31);
            this.label4.TabIndex = 71;
            this.label4.Text = "Occupied:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new global::System.Drawing.Point(183, 77);
            this.label2.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(66, 31);
            this.label2.TabIndex = 69;
            this.label2.Text = "7 / 9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new global::System.Drawing.Point(50, 77);
            this.label1.Margin = new global::System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(132, 31);
            this.label1.TabIndex = 69;
            this.label1.Text = "Available:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new global::System.Drawing.Point(1210, 23);
            this.groupBox2.Margin = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox2.Size = new global::System.Drawing.Size(1006, 783);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new global::System.Drawing.Size(2236, 1464);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayout);
            this.Margin = new global::System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Home";
            this.Text = "TOMS";
            this.Load += new global::System.EventHandler(this.Form1_Load);
            this.tableLayout.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private global::System.Windows.Forms.GroupBox tableLayout;
        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.Button button10;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.GroupBox groupBox2;
        private global::System.Windows.Forms.Button menuReload;
    }
}

