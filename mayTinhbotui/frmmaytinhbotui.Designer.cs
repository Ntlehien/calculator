namespace mayTinhbotui
{
    partial class frmmaytinhbotui
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.btncong = new System.Windows.Forms.Button();
            this.btntru = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnchia = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(43, 49);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(94, 22);
            this.txtSo1.TabIndex = 0;
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(299, 49);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(113, 22);
            this.txtSo2.TabIndex = 1;
            // 
            // txtKQ
            // 
            this.txtKQ.BackColor = System.Drawing.Color.DarkGray;
            this.txtKQ.ForeColor = System.Drawing.Color.Maroon;
            this.txtKQ.Location = new System.Drawing.Point(136, 101);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(149, 22);
            this.txtKQ.TabIndex = 2;
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(43, 188);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(94, 47);
            this.btncong.TabIndex = 3;
            this.btncong.Text = "cộng";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btntru
            // 
            this.btntru.Location = new System.Drawing.Point(299, 188);
            this.btntru.Name = "btntru";
            this.btntru.Size = new System.Drawing.Size(91, 47);
            this.btntru.TabIndex = 4;
            this.btntru.Text = "trừ";
            this.btntru.UseVisualStyleBackColor = true;
            this.btntru.Click += new System.EventHandler(this.btntru_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(43, 324);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(94, 46);
            this.btnnhan.TabIndex = 5;
            this.btnnhan.Text = "nhân";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnchia
            // 
            this.btnchia.Location = new System.Drawing.Point(300, 324);
            this.btnchia.Name = "btnchia";
            this.btnchia.Size = new System.Drawing.Size(90, 46);
            this.btnchia.TabIndex = 6;
            this.btnchia.Text = "chia";
            this.btnchia.UseVisualStyleBackColor = true;
            this.btnchia.Click += new System.EventHandler(this.btnchia_Click);
            // 
            // frmmaytinhbotui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 493);
            this.Controls.Add(this.btnchia);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btntru);
            this.Controls.Add(this.btncong);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.txtSo1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmmaytinhbotui";
            this.Text = "MayTinhBoTui";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSo1;
        private System.Windows.Forms.TextBox txtSo2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btntru;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnchia;
    }
}

