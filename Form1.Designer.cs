﻿namespace Test4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            emailtb = new TextBox();
            passwordtb = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Maiandra GD", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(511, 80);
            label1.Name = "label1";
            label1.Size = new Size(155, 57);
            label1.TabIndex = 0;
            label1.Text = "Log In";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(368, 223);
            label2.Name = "label2";
            label2.Size = new Size(69, 29);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(368, 295);
            label3.Name = "label3";
            label3.Size = new Size(111, 29);
            label3.TabIndex = 2;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // emailtb
            // 
            emailtb.Font = new Font("Maiandra GD", 11F);
            emailtb.Location = new Point(494, 222);
            emailtb.Name = "emailtb";
            emailtb.Size = new Size(286, 34);
            emailtb.TabIndex = 3;
            // 
            // passwordtb
            // 
            passwordtb.Font = new Font("Maiandra GD", 11F);
            passwordtb.Location = new Point(494, 294);
            passwordtb.Name = "passwordtb";
            passwordtb.Size = new Size(286, 34);
            passwordtb.TabIndex = 4;
            // 
            // button1
            // 
            button1.Font = new Font("Maiandra GD", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(520, 358);
            button1.Name = "button1";
            button1.Size = new Size(137, 43);
            button1.TabIndex = 5;
            button1.Text = "Log In";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 624);
            Controls.Add(button1);
            Controls.Add(passwordtb);
            Controls.Add(emailtb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox emailtb;
        private TextBox passwordtb;
        private Button button1;
    }
}
