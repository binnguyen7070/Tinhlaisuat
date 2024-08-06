namespace Tinhlaisuat
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
            label4 = new Label();
            txttiengui = new TextBox();
            txtlaisuat = new TextBox();
            txtsonam = new TextBox();
            btntinh = new Button();
            lbltongtien = new Label();
            lbltienlai = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(288, 24);
            label1.Name = "label1";
            label1.Size = new Size(160, 32);
            label1.TabIndex = 0;
            label1.Text = "Tính lãi suất ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(75, 112);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Số tiền gửi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 170);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 2;
            label3.Text = "Lãi suất ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(75, 234);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 3;
            label4.Text = "Số năm";
            // 
            // txttiengui
            // 
            txttiengui.Location = new Point(278, 104);
            txttiengui.Name = "txttiengui";
            txttiengui.Size = new Size(100, 23);
            txttiengui.TabIndex = 4;
            // 
            // txtlaisuat
            // 
            txtlaisuat.Location = new Point(278, 162);
            txtlaisuat.Name = "txtlaisuat";
            txtlaisuat.Size = new Size(100, 23);
            txtlaisuat.TabIndex = 4;
            // 
            // txtsonam
            // 
            txtsonam.Location = new Point(278, 226);
            txtsonam.Name = "txtsonam";
            txtsonam.Size = new Size(100, 23);
            txtsonam.TabIndex = 4;
            // 
            // btntinh
            // 
            btntinh.Location = new Point(303, 286);
            btntinh.Name = "btntinh";
            btntinh.Size = new Size(75, 23);
            btntinh.TabIndex = 5;
            btntinh.Text = "Tính ";
            btntinh.UseVisualStyleBackColor = true;
            btntinh.Click += btntinh_Click;
            // 
            // lbltongtien
            // 
            lbltongtien.AutoSize = true;
            lbltongtien.Location = new Point(541, 109);
            lbltongtien.Name = "lbltongtien";
            lbltongtien.Size = new Size(0, 15);
            lbltongtien.TabIndex = 6;
            // 
            // lbltienlai
            // 
            lbltienlai.AutoSize = true;
            lbltienlai.Location = new Point(541, 176);
            lbltienlai.Name = "lbltienlai";
            lbltienlai.Size = new Size(0, 15);
            lbltienlai.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(466, 107);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 7;
            label5.Text = "Tổng tiền :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(466, 170);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 7;
            label6.Text = "Tiền lãi :";
            label6.Click += label6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(lbltienlai);
            Controls.Add(lbltongtien);
            Controls.Add(btntinh);
            Controls.Add(txtsonam);
            Controls.Add(txtlaisuat);
            Controls.Add(txttiengui);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txttiengui;
        private TextBox txtlaisuat;
        private TextBox txtsonam;
        private Button btntinh;
        private Label lbltongtien;
        private Label lbltienlai;
        private Label label5;
        private Label label6;
    }
}
