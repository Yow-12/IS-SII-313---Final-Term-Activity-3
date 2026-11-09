namespace Activity3
{
    partial class Register
    {
        private System.ComponentModel.IContainer components = null;

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
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLogin = new LinkLabel();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 563);
            panel1.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Impact", 20F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(43, 239);
            label7.Name = "label7";
            label7.Size = new Size(199, 126);
            label7.TabIndex = 3;
            label7.Text = "INVENTORY\r\nMANAGEMENT\r\nSYSTEM";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 55F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(57, 97);
            label6.Name = "label6";
            label6.Size = new Size(178, 123);
            label6.TabIndex = 2;
            label6.Text = "📦";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.Font = new Font("Segoe UI", 15F);
            textBox1.Location = new Point(334, 122);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(424, 47);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(334, 210);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(424, 47);
            textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(334, 300);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(424, 47);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.None;
            textBox4.Font = new Font("Segoe UI", 15F);
            textBox4.Location = new Point(334, 389);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(424, 47);
            textBox4.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(334, 453);
            button1.Name = "button1";
            button1.Size = new Size(424, 49);
            button1.TabIndex = 5;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(472, 32);
            label1.Name = "label1";
            label1.Size = new Size(148, 45);
            label1.TabIndex = 6;
            label1.Text = "Register";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(338, 91);
            label2.Name = "label2";
            label2.Size = new Size(118, 33);
            label2.TabIndex = 7;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(334, 179);
            label3.Name = "label3";
            label3.Size = new Size(122, 33);
            label3.TabIndex = 8;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(334, 269);
            label4.Name = "label4";
            label4.Size = new Size(115, 33);
            label4.TabIndex = 9;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(334, 358);
            label5.Name = "label5";
            label5.Size = new Size(214, 33);
            label5.TabIndex = 10;
            label5.Text = "Re-Enter Password";
            // 
            // linkLogin
            // 
            linkLogin.AutoSize = true;
            linkLogin.Cursor = Cursors.Hand;
            linkLogin.Font = new Font("Segoe UI", 9F);
            linkLogin.LinkColor = SystemColors.HotTrack;
            linkLogin.Location = new Point(579, 513);
            linkLogin.Name = "linkLogin";
            linkLogin.Size = new Size(99, 20);
            linkLogin.TabIndex = 11;
            linkLogin.TabStop = true;
            linkLogin.Text = "Back to Login";
            linkLogin.LinkClicked += linkLogin_LinkClicked;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F);
            label8.Location = new Point(404, 513);
            label8.Name = "label8";
            label8.Size = new Size(178, 20);
            label8.TabIndex = 12;
            label8.Text = "Already have an account?";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(label8);
            Controls.Add(linkLogin);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label7;
        private Label label6;
        private LinkLabel linkLogin;
        private Label label8;
    }
}