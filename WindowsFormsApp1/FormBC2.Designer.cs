namespace WindowsFormsApp1
{
    partial class FormBC2
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
            this.btnInBC = new System.Windows.Forms.Button();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comTruong = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInBC
            // 
            this.btnInBC.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(114)))), ((int)(((byte)(242)))));
            this.btnInBC.FlatAppearance.BorderSize = 2;
            this.btnInBC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(114)))), ((int)(((byte)(242)))));
            this.btnInBC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInBC.Font = new System.Drawing.Font("Cambria", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInBC.ForeColor = System.Drawing.Color.White;
            this.btnInBC.Location = new System.Drawing.Point(322, 214);
            this.btnInBC.Name = "btnInBC";
            this.btnInBC.Size = new System.Drawing.Size(148, 48);
            this.btnInBC.TabIndex = 89;
            this.btnInBC.Text = "In báo cáo";
            this.btnInBC.UseVisualStyleBackColor = true;
            this.btnInBC.Click += new System.EventHandler(this.btnInBC_Click);
            // 
            // comGT
            // 
            this.comGT.BackColor = System.Drawing.SystemColors.Window;
            this.comGT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.ForeColor = System.Drawing.Color.Black;
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(291, 132);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(209, 28);
            this.comGT.TabIndex = 88;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(129, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 20);
            this.label2.TabIndex = 87;
            this.label2.Text = "Giá trị tìm kiếm:";
            // 
            // comTruong
            // 
            this.comTruong.BackColor = System.Drawing.SystemColors.Window;
            this.comTruong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruong.ForeColor = System.Drawing.Color.Black;
            this.comTruong.FormattingEnabled = true;
            this.comTruong.Items.AddRange(new object[] {
            "MaDA"});
            this.comTruong.Location = new System.Drawing.Point(291, 72);
            this.comTruong.Name = "comTruong";
            this.comTruong.Size = new System.Drawing.Size(209, 28);
            this.comTruong.TabIndex = 86;
            this.comTruong.SelectedIndexChanged += new System.EventHandler(this.comTruong_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(129, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 85;
            this.label1.Text = "Tên trường:";
            // 
            // FormBC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(628, 334);
            this.Controls.Add(this.btnInBC);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comTruong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBC2";
            this.Text = "FormBC2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInBC;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comTruong;
        private System.Windows.Forms.Label label1;
    }
}