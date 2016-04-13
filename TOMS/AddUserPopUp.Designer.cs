namespace TOMS
{
    partial class AddUserPopUp
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
            this.textBox1 = new global::System.Windows.Forms.TextBox();
            this.button1 = new global::System.Windows.Forms.Button();
            this.button2 = new global::System.Windows.Forms.Button();
            this.label1 = new global::System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new global::System.Drawing.Point(415, 88);
            this.textBox1.Name = "textBox1";
            this.textBox1.PasswordChar = '*';
            this.textBox1.RightToLeft = global::System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new global::System.Drawing.Size(200, 31);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new global::System.Drawing.Point(297, 152);
            this.button1.Name = "button1";
            this.button1.Size = new global::System.Drawing.Size(147, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new global::System.Drawing.Point(571, 153);
            this.button2.Name = "button2";
            this.button2.Size = new global::System.Drawing.Size(123, 62);
            this.button2.TabIndex = 2;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new global::System.Drawing.Point(435, 47);
            this.label1.Name = "label1";
            this.label1.Size = new global::System.Drawing.Size(163, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Password";
            // 
            // AddUserPopUp
            // 
            this.ClientSize = new global::System.Drawing.Size(1004, 341);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddUserPopUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private global::System.Windows.Forms.TextBox textBox1;
        private global::System.Windows.Forms.Button button1;
        private global::System.Windows.Forms.Button button2;
        private global::System.Windows.Forms.Label label1;
    }
}