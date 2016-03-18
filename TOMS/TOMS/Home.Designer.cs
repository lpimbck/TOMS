
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
        private void addButton()
        {
            System singleInstance = System.Instance; //220/275
            int top = 34;
            int left = 142;
            int tabindex = 17;
            for (int i=0; i<singleInstance.getNumberofTables();i++)
            {
                global::System.Windows.Forms.Button button = new global::System.Windows.Forms.Button();
                button.Location = new global::System.Drawing.Point(top,left);
                button.Margin = new global::System.Windows.Forms.Padding(4);
                button.Name = "button" + i;
                button.Size = new global::System.Drawing.Size(183, 84);
                button.TabIndex = tabindex++;
                button.Text = "Table"+(i+1);
                button.BackColor = global::System.Drawing.Color.Red;
                button.UseVisualStyleBackColor = false;
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
            System singleInstance = System.Instance;
            this.tableLayout = new global::System.Windows.Forms.GroupBox();
            this.button10 = new global::System.Windows.Forms.Button();
            this.button9 = new global::System.Windows.Forms.Button();
            this.button8 = new global::System.Windows.Forms.Button();
            this.button7 = new global::System.Windows.Forms.Button();
            this.button6 = new global::System.Windows.Forms.Button();
            this.button5 = new global::System.Windows.Forms.Button();
            this.button4 = new global::System.Windows.Forms.Button();
            this.button3 = new global::System.Windows.Forms.Button();
            this.button2 = new global::System.Windows.Forms.Button();
            this.button1 = new global::System.Windows.Forms.Button();
            this.groupBox1 = new global::System.Windows.Forms.GroupBox();
            this.label3 = new global::System.Windows.Forms.Label();
            this.label4 = new global::System.Windows.Forms.Label();
            this.label2 = new global::System.Windows.Forms.Label();
            this.label1 = new global::System.Windows.Forms.Label();
            this.groupBox2 = new global::System.Windows.Forms.GroupBox();
            this.manage1 = new global::System.Windows.Forms.Button();
            this.manage2 = new global::System.Windows.Forms.Button();
            this.manage3 = new global::System.Windows.Forms.Button();
            this.manage4 = new global::System.Windows.Forms.Button();
            this.manage5 = new global::System.Windows.Forms.Button();
            this.manage6 = new global::System.Windows.Forms.Button();
            this.manage7 = new global::System.Windows.Forms.Button();
            this.manage8 = new global::System.Windows.Forms.Button();
            this.manage9 = new global::System.Windows.Forms.Button();
            this.tableLayout.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.Controls.Add(this.manage9);
            this.tableLayout.Controls.Add(this.manage8);
            this.tableLayout.Controls.Add(this.manage7);
            this.tableLayout.Controls.Add(this.manage6);
            this.tableLayout.Controls.Add(this.manage5);
            this.tableLayout.Controls.Add(this.manage4);
            this.tableLayout.Controls.Add(this.manage3);
            this.tableLayout.Controls.Add(this.manage2);
            this.tableLayout.Controls.Add(this.manage1);
            this.tableLayout.Controls.Add(this.button10);
            this.tableLayout.Controls.Add(this.button9);
            this.tableLayout.Controls.Add(this.button8);
            this.tableLayout.Controls.Add(this.button7);
            this.tableLayout.Controls.Add(this.button6);
            this.tableLayout.Controls.Add(this.button5);
            this.tableLayout.Controls.Add(this.button4);
            this.tableLayout.Controls.Add(this.button3);
            this.tableLayout.Controls.Add(this.button2);
            this.tableLayout.Controls.Add(this.button1);
            this.tableLayout.Location = new global::System.Drawing.Point(16, 15);
            this.tableLayout.Margin = new global::System.Windows.Forms.Padding(4);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.Padding = new global::System.Windows.Forms.Padding(4);
            this.tableLayout.Size = new global::System.Drawing.Size(783, 907);
            this.tableLayout.TabIndex = 1;
            this.tableLayout.TabStop = false;
            this.tableLayout.Text = "Layout";
            // 
            // button10
            // 
            this.button10.Location = new global::System.Drawing.Point(316, 0);
            this.button10.Margin = new global::System.Windows.Forms.Padding(4);
            this.button10.Name = "button10";
            this.button10.Size = new global::System.Drawing.Size(169, 94);
            this.button10.TabIndex = 27;
            this.button10.Text = "Entrance"+singleInstance.getNumberofTables();
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new global::System.EventHandler(this.button10_Click);

            this.addButton();
            // 
            // button9
            // 

            /*
            this.button9.Location = new global::System.Drawing.Point(577, 558);
            this.button9.Margin = new global::System.Windows.Forms.Padding(4);
            this.button9.Name = "button9";
            this.button9.Size = new global::System.Drawing.Size(183, 84);
            this.button9.TabIndex = 26;
            this.button9.Text = "Table9";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new global::System.Drawing.Point(303, 558);
            this.button8.Margin = new global::System.Windows.Forms.Padding(4);
            this.button8.Name = "button8";
            this.button8.Size = new global::System.Drawing.Size(183, 84);
            this.button8.TabIndex = 25;
            this.button8.Text = "Table8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new global::System.Drawing.Point(33, 558);
            this.button7.Margin = new global::System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new global::System.Drawing.Size(183, 84);
            this.button7.TabIndex = 24;
            this.button7.Text = "Table7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new global::System.Drawing.Point(577, 363);
            this.button6.Margin = new global::System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new global::System.Drawing.Size(183, 84);
            this.button6.TabIndex = 23;
            this.button6.Text = "Table6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new global::System.Drawing.Point(303, 363);
            this.button5.Margin = new global::System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new global::System.Drawing.Size(183, 84);
            this.button5.TabIndex = 22;
            this.button5.Text = "Table5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new global::System.Drawing.Point(33, 363);
            this.button4.Margin = new global::System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new global::System.Drawing.Size(183, 84);
            this.button4.TabIndex = 21;
            this.button4.Text = "Table4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackColor = global::System.Drawing.Color.DarkOliveGreen;
            this.button3.Location = new global::System.Drawing.Point(577, 142);
            this.button3.Margin = new global::System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new global::System.Drawing.Size(183, 84);
            this.button3.TabIndex = 20;
            this.button3.Text = "Table3";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = global::System.Drawing.Color.Gold;
            this.button2.Location = new global::System.Drawing.Point(303, 142);
            this.button2.Margin = new global::System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new global::System.Drawing.Size(183, 84);
            this.button2.TabIndex = 19;
            this.button2.Text = "Table2";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Location = new global::System.Drawing.Point(34, 142);
            this.button1.Margin = new global::System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(183, 84);
            this.button1.TabIndex = 18;
            this.button1.Text = "Table1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new global::System.EventHandler(this.button1_Click);

    */
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new global::System.Drawing.Point(807, 524);
            this.groupBox1.Margin = new global::System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new global::System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new global::System.Drawing.Size(671, 398);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new global::System.Drawing.Point(122, 101);
            this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new global::System.Drawing.Size(18, 20);
            this.label3.TabIndex = 70;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new global::System.Drawing.Point(33, 101);
            this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new global::System.Drawing.Size(85, 20);
            this.label4.TabIndex = 71;
            this.label4.Text = "Occupied:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new global::System.Drawing.Point(122, 49);
            this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new global::System.Drawing.Size(42, 20);
            this.label2.TabIndex = 69;
            this.label2.Text = "7 / 9";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10F, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new global::System.Drawing.Point(33, 49);
            this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(81, 20);
            this.label1.TabIndex = 69;
            this.label1.Text = "Available:";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new global::System.Drawing.Point(807, 15);
            this.groupBox2.Margin = new global::System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new global::System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new global::System.Drawing.Size(671, 501);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Information";
            // 
            // manage1
            // 
            this.manage1.Location = new global::System.Drawing.Point(73, 233);
            this.manage1.Name = "manage1";
            this.manage1.Size = new global::System.Drawing.Size(91, 39);
            this.manage1.TabIndex = 0;
            this.manage1.Text = "Manage";
            this.manage1.UseVisualStyleBackColor = true;
            this.manage1.Click += new global::System.EventHandler(this.manage1_click);
            // 
            // manage2
            // 
            this.manage2.Location = new global::System.Drawing.Point(354, 233);
            this.manage2.Name = "manage2";
            this.manage2.Size = new global::System.Drawing.Size(91, 39);
            this.manage2.TabIndex = 28;
            this.manage2.Text = "Manage";
            this.manage2.UseVisualStyleBackColor = true;
            // 
            // manage3
            // 
            this.manage3.Location = new global::System.Drawing.Point(616, 233);
            this.manage3.Name = "manage3";
            this.manage3.Size = new global::System.Drawing.Size(91, 39);
            this.manage3.TabIndex = 29;
            this.manage3.Text = "Manage";
            this.manage3.UseVisualStyleBackColor = true;
            // 
            // manage4
            // 
            this.manage4.Location = new global::System.Drawing.Point(73, 454);
            this.manage4.Name = "manage4";
            this.manage4.Size = new global::System.Drawing.Size(91, 39);
            this.manage4.TabIndex = 30;
            this.manage4.Text = "Manage";
            this.manage4.UseVisualStyleBackColor = true;
            // 
            // manage5
            // 
            this.manage5.Location = new global::System.Drawing.Point(354, 454);
            this.manage5.Name = "manage5";
            this.manage5.Size = new global::System.Drawing.Size(91, 39);
            this.manage5.TabIndex = 31;
            this.manage5.Text = "Manage";
            this.manage5.UseVisualStyleBackColor = true;
            // 
            // manage6
            // 
            this.manage6.Location = new global::System.Drawing.Point(633, 450);
            this.manage6.Name = "manage6";
            this.manage6.Size = new global::System.Drawing.Size(91, 39);
            this.manage6.TabIndex = 32;
            this.manage6.Text = "Manage";
            this.manage6.UseVisualStyleBackColor = true;
            // 
            // manage7
            // 
            this.manage7.Location = new global::System.Drawing.Point(73, 649);
            this.manage7.Name = "manage7";
            this.manage7.Size = new global::System.Drawing.Size(91, 39);
            this.manage7.TabIndex = 33;
            this.manage7.Text = "Manage";
            this.manage7.UseVisualStyleBackColor = true;
            // 
            // manage8
            // 
            this.manage8.Location = new global::System.Drawing.Point(354, 649);
            this.manage8.Name = "manage8";
            this.manage8.Size = new global::System.Drawing.Size(91, 39);
            this.manage8.TabIndex = 34;
            this.manage8.Text = "Manage";
            this.manage8.UseVisualStyleBackColor = true;
            // 
            // manage9
            // 
            this.manage9.Location = new global::System.Drawing.Point(633, 649);
            this.manage9.Name = "manage9";
            this.manage9.Size = new global::System.Drawing.Size(91, 39);
            this.manage9.TabIndex = 35;
            this.manage9.Text = "Manage";
            this.manage9.UseVisualStyleBackColor = true;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new global::System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new global::System.Drawing.Size(1491, 937);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayout);
            this.Margin = new global::System.Windows.Forms.Padding(4);
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
        private global::System.Windows.Forms.Button button9;
        private global::System.Windows.Forms.Button button8;
        private global::System.Windows.Forms.Button button7;
        private global::System.Windows.Forms.Button button6;
        private global::System.Windows.Forms.Button button5;
        private global::System.Windows.Forms.Button button4;
        private global::System.Windows.Forms.Button button3;
        private global::System.Windows.Forms.Button button2;
        private global::System.Windows.Forms.Button button1;
        private global::System.Windows.Forms.GroupBox groupBox1;
        private global::System.Windows.Forms.Button button10;
        private global::System.Windows.Forms.Label label3;
        private global::System.Windows.Forms.Label label4;
        private global::System.Windows.Forms.Label label2;
        private global::System.Windows.Forms.Label label1;
        private global::System.Windows.Forms.GroupBox groupBox2;
        private global::System.Windows.Forms.Button manage1;
        private global::System.Windows.Forms.Button manage9;
        private global::System.Windows.Forms.Button manage8;
        private global::System.Windows.Forms.Button manage7;
        private global::System.Windows.Forms.Button manage6;
        private global::System.Windows.Forms.Button manage5;
        private global::System.Windows.Forms.Button manage4;
        private global::System.Windows.Forms.Button manage3;
        private global::System.Windows.Forms.Button manage2;
    }
}

