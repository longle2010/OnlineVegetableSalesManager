
namespace project_1
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.Ban = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Nhapkho = new System.Windows.Forms.Button();
            this.thoat = new System.Windows.Forms.Button();
            this.dtkho = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.daBan = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ThongKe = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtkho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daBan)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(343, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý thực phẩm";
            // 
            // Ban
            // 
            this.Ban.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ban.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Ban.Location = new System.Drawing.Point(165, 159);
            this.Ban.Name = "Ban";
            this.Ban.Size = new System.Drawing.Size(117, 46);
            this.Ban.TabIndex = 1;
            this.Ban.Text = "Bán hàng";
            this.Ban.UseVisualStyleBackColor = true;
            this.Ban.Click += new System.EventHandler(this.Ban_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(173, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Bán hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(646, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nhập kho";
            // 
            // Nhapkho
            // 
            this.Nhapkho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nhapkho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Nhapkho.Location = new System.Drawing.Point(640, 159);
            this.Nhapkho.Name = "Nhapkho";
            this.Nhapkho.Size = new System.Drawing.Size(117, 46);
            this.Nhapkho.TabIndex = 3;
            this.Nhapkho.Text = "Nhập kho";
            this.Nhapkho.UseVisualStyleBackColor = true;
            this.Nhapkho.Click += new System.EventHandler(this.Nhapkho_Click);
            // 
            // thoat
            // 
            this.thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thoat.ForeColor = System.Drawing.Color.Red;
            this.thoat.Location = new System.Drawing.Point(407, 640);
            this.thoat.Name = "thoat";
            this.thoat.Size = new System.Drawing.Size(117, 46);
            this.thoat.TabIndex = 5;
            this.thoat.Text = "Thoát";
            this.thoat.UseVisualStyleBackColor = true;
            this.thoat.Click += new System.EventHandler(this.thoat_Click);
            // 
            // dtkho
            // 
            this.dtkho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtkho.Location = new System.Drawing.Point(487, 311);
            this.dtkho.Name = "dtkho";
            this.dtkho.RowHeadersWidth = 51;
            this.dtkho.RowTemplate.Height = 24;
            this.dtkho.Size = new System.Drawing.Size(426, 313);
            this.dtkho.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(677, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kho";
            // 
            // daBan
            // 
            this.daBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daBan.Location = new System.Drawing.Point(12, 311);
            this.daBan.Name = "daBan";
            this.daBan.RowHeadersWidth = 51;
            this.daBan.RowTemplate.Height = 24;
            this.daBan.Size = new System.Drawing.Size(426, 313);
            this.daBan.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Đã bán";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(412, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Thống kê";
            // 
            // ThongKe
            // 
            this.ThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThongKe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ThongKe.Location = new System.Drawing.Point(393, 159);
            this.ThongKe.Name = "ThongKe";
            this.ThongKe.Size = new System.Drawing.Size(145, 46);
            this.ThongKe.TabIndex = 10;
            this.ThongKe.Text = "Thống kê";
            this.ThongKe.UseVisualStyleBackColor = true;
            this.ThongKe.Click += new System.EventHandler(this.ThongKe_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(407, 236);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 46);
            this.button1.TabIndex = 12;
            this.button1.Text = "In";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 698);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ThongKe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.daBan);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtkho);
            this.Controls.Add(this.thoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Nhapkho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ban);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtkho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daBan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Nhapkho;
        private System.Windows.Forms.Button thoat;
        private System.Windows.Forms.DataGridView dtkho;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView daBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ThongKe;
        private System.Windows.Forms.Button button1;
    }
}

