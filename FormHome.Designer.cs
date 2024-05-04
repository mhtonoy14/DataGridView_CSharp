namespace Test4
{
    partial class FormHome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            uidtb = new TextBox();
            nametb = new TextBox();
            phonetb = new TextBox();
            emailtb = new TextBox();
            addresstb = new TextBox();
            passwordtb = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(31, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(642, 340);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.Click += dataGridView1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(449, 19);
            label1.Name = "label1";
            label1.Size = new Size(243, 43);
            label1.TabIndex = 1;
            label1.Text = "DataGridView";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(743, 81);
            label2.Name = "label2";
            label2.Size = new Size(81, 26);
            label2.TabIndex = 2;
            label2.Text = "User Id";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(743, 147);
            label3.Name = "label3";
            label3.Size = new Size(71, 26);
            label3.TabIndex = 3;
            label3.Text = "Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Maiandra GD", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(743, 211);
            label4.Name = "label4";
            label4.Size = new Size(65, 26);
            label4.TabIndex = 4;
            label4.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Maiandra GD", 11F);
            label5.Location = new Point(742, 272);
            label5.Name = "label5";
            label5.Size = new Size(72, 26);
            label5.TabIndex = 5;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Maiandra GD", 11F);
            label6.Location = new Point(743, 333);
            label6.Name = "label6";
            label6.Size = new Size(88, 26);
            label6.TabIndex = 6;
            label6.Text = "Address";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Maiandra GD", 11F);
            label7.Location = new Point(743, 395);
            label7.Name = "label7";
            label7.Size = new Size(103, 26);
            label7.TabIndex = 7;
            label7.Text = "Password";
            // 
            // uidtb
            // 
            uidtb.Font = new Font("Maiandra GD", 11F);
            uidtb.Location = new Point(852, 78);
            uidtb.Name = "uidtb";
            uidtb.ReadOnly = true;
            uidtb.Size = new Size(266, 34);
            uidtb.TabIndex = 8;
            // 
            // nametb
            // 
            nametb.Font = new Font("Maiandra GD", 11F);
            nametb.Location = new Point(852, 144);
            nametb.Name = "nametb";
            nametb.Size = new Size(266, 34);
            nametb.TabIndex = 9;
            // 
            // phonetb
            // 
            phonetb.Font = new Font("Maiandra GD", 11F);
            phonetb.Location = new Point(852, 269);
            phonetb.Name = "phonetb";
            phonetb.Size = new Size(266, 34);
            phonetb.TabIndex = 10;
            // 
            // emailtb
            // 
            emailtb.Font = new Font("Maiandra GD", 11F);
            emailtb.Location = new Point(852, 208);
            emailtb.Name = "emailtb";
            emailtb.Size = new Size(266, 34);
            emailtb.TabIndex = 11;
            // 
            // addresstb
            // 
            addresstb.Font = new Font("Maiandra GD", 11F);
            addresstb.Location = new Point(852, 330);
            addresstb.Name = "addresstb";
            addresstb.Size = new Size(266, 34);
            addresstb.TabIndex = 12;
            // 
            // passwordtb
            // 
            passwordtb.Font = new Font("Maiandra GD", 11F);
            passwordtb.Location = new Point(852, 392);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(266, 34);
            passwordtb.TabIndex = 13;
            // 
            // button1
            // 
            button1.Font = new Font("Maiandra GD", 11F);
            button1.Location = new Point(200, 512);
            button1.Name = "button1";
            button1.Size = new Size(145, 45);
            button1.TabIndex = 14;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Maiandra GD", 11F);
            button2.Location = new Point(393, 512);
            button2.Name = "button2";
            button2.Size = new Size(145, 45);
            button2.TabIndex = 15;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Maiandra GD", 11F);
            button3.Location = new Point(587, 512);
            button3.Name = "button3";
            button3.Size = new Size(145, 45);
            button3.TabIndex = 16;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Maiandra GD", 11F);
            button4.Location = new Point(782, 512);
            button4.Name = "button4";
            button4.Size = new Size(145, 45);
            button4.TabIndex = 17;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // FormHome
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 624);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passwordtb);
            Controls.Add(addresstb);
            Controls.Add(emailtb);
            Controls.Add(phonetb);
            Controls.Add(nametb);
            Controls.Add(uidtb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FormHome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            Load += FormHome_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox uidtb;
        private TextBox nametb;
        private TextBox phonetb;
        private TextBox emailtb;
        private TextBox addresstb;
        private TextBox passwordtb;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}