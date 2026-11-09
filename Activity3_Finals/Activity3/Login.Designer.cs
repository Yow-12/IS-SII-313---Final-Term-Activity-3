namespace Activity3
{
    partial class Login
    {
        private System.ComponentModel.IContainer components = null;

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

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label1 = new Label();
            linkRegister = new LinkLabel();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 533);
            panel1.TabIndex = 1;
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(332, 253);
            label4.Name = "label4";
            label4.Size = new Size(115, 33);
            label4.TabIndex = 13;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(332, 163);
            label3.Name = "label3";
            label3.Size = new Size(122, 33);
            label3.TabIndex = 12;
            label3.Text = "Username";
            // 
            // textBox3
            // 
            textBox3.Anchor = AnchorStyles.None;
            textBox3.Font = new Font("Segoe UI", 15F);
            textBox3.Location = new Point(332, 289);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(424, 47);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.Font = new Font("Segoe UI", 15F);
            textBox2.Location = new Point(332, 199);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(424, 47);
            textBox2.TabIndex = 10;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(332, 353);
            button1.Name = "button1";
            button1.Size = new Size(424, 49);
            button1.TabIndex = 14;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(491, 95);
            label1.Name = "label1";
            label1.Size = new Size(101, 45);
            label1.TabIndex = 15;
            label1.Text = "Login";
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Cursor = Cursors.Hand;
            linkRegister.Font = new Font("Segoe UI", 10F);
            linkRegister.LinkColor = SystemColors.HotTrack;
            linkRegister.Location = new Point(562, 425);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(150, 23);
            linkRegister.TabIndex = 16;
            linkRegister.TabStop = true;
            linkRegister.Text = "Create an account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(376, 425);
            label2.Name = "label2";
            label2.Size = new Size(191, 23);
            label2.TabIndex = 17;
            label2.Text = "Don't have an account?";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 523);
            Controls.Add(label2);
            Controls.Add(linkRegister);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label3;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button1;
        private Label label1;
        private LinkLabel linkRegister;
        private Label label2;
    }
}