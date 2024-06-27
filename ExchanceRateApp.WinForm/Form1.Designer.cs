namespace ExchanceRateApp.WinForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_selling_usd = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_buying_usd = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grd_exchange_rate_history = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl_selling_eur = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_buying_eur = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lbl_selling_gbp = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_buying_gbp = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_exchange_rate_date = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_exchange_rate_history)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_selling_usd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbl_buying_usd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ABD Doları";
            // 
            // lbl_selling_usd
            // 
            this.lbl_selling_usd.AutoSize = true;
            this.lbl_selling_usd.Location = new System.Drawing.Point(150, 55);
            this.lbl_selling_usd.Name = "lbl_selling_usd";
            this.lbl_selling_usd.Size = new System.Drawing.Size(16, 17);
            this.lbl_selling_usd.TabIndex = 0;
            this.lbl_selling_usd.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Satış";
            // 
            // lbl_buying_usd
            // 
            this.lbl_buying_usd.AutoSize = true;
            this.lbl_buying_usd.Location = new System.Drawing.Point(150, 33);
            this.lbl_buying_usd.Name = "lbl_buying_usd";
            this.lbl_buying_usd.Size = new System.Drawing.Size(16, 17);
            this.lbl_buying_usd.TabIndex = 0;
            this.lbl_buying_usd.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.label5.Location = new System.Drawing.Point(23, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alış";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grd_exchange_rate_history);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(295, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(648, 332);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kur Geçmişi";
            // 
            // grd_exchange_rate_history
            // 
            this.grd_exchange_rate_history.AllowUserToAddRows = false;
            this.grd_exchange_rate_history.AllowUserToDeleteRows = false;
            this.grd_exchange_rate_history.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_exchange_rate_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grd_exchange_rate_history.Location = new System.Drawing.Point(3, 16);
            this.grd_exchange_rate_history.Name = "grd_exchange_rate_history";
            this.grd_exchange_rate_history.ReadOnly = true;
            this.grd_exchange_rate_history.Size = new System.Drawing.Size(642, 313);
            this.grd_exchange_rate_history.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl_selling_eur);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lbl_buying_eur);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 88);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Euro";
            // 
            // lbl_selling_eur
            // 
            this.lbl_selling_eur.AutoSize = true;
            this.lbl_selling_eur.Location = new System.Drawing.Point(150, 55);
            this.lbl_selling_eur.Name = "lbl_selling_eur";
            this.lbl_selling_eur.Size = new System.Drawing.Size(16, 17);
            this.lbl_selling_eur.TabIndex = 0;
            this.lbl_selling_eur.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Satış";
            // 
            // lbl_buying_eur
            // 
            this.lbl_buying_eur.AutoSize = true;
            this.lbl_buying_eur.Location = new System.Drawing.Point(150, 33);
            this.lbl_buying_eur.Name = "lbl_buying_eur";
            this.lbl_buying_eur.Size = new System.Drawing.Size(16, 17);
            this.lbl_buying_eur.TabIndex = 0;
            this.lbl_buying_eur.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.label9.Location = new System.Drawing.Point(23, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 39);
            this.label9.TabIndex = 0;
            this.label9.Text = "€";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Alış";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbl_selling_gbp);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lbl_buying_gbp);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(12, 200);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 90);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "İngiliz Sterlini";
            // 
            // lbl_selling_gbp
            // 
            this.lbl_selling_gbp.AutoSize = true;
            this.lbl_selling_gbp.Location = new System.Drawing.Point(150, 55);
            this.lbl_selling_gbp.Name = "lbl_selling_gbp";
            this.lbl_selling_gbp.Size = new System.Drawing.Size(16, 17);
            this.lbl_selling_gbp.TabIndex = 0;
            this.lbl_selling_gbp.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(74, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Satış";
            // 
            // lbl_buying_gbp
            // 
            this.lbl_buying_gbp.AutoSize = true;
            this.lbl_buying_gbp.Location = new System.Drawing.Point(150, 33);
            this.lbl_buying_gbp.Name = "lbl_buying_gbp";
            this.lbl_buying_gbp.Size = new System.Drawing.Size(16, 17);
            this.lbl_buying_gbp.TabIndex = 0;
            this.lbl_buying_gbp.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(128)))), ((int)(((byte)(104)))));
            this.label14.Location = new System.Drawing.Point(23, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 39);
            this.label14.TabIndex = 0;
            this.label14.Text = "₺";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(74, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Alış";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_refresh.Location = new System.Drawing.Point(12, 313);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(276, 31);
            this.btn_refresh.TabIndex = 2;
            this.btn_refresh.Text = "Yenile";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tarih";
            // 
            // lbl_exchange_rate_date
            // 
            this.lbl_exchange_rate_date.AutoSize = true;
            this.lbl_exchange_rate_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_exchange_rate_date.Location = new System.Drawing.Point(88, 293);
            this.lbl_exchange_rate_date.Name = "lbl_exchange_rate_date";
            this.lbl_exchange_rate_date.Size = new System.Drawing.Size(16, 17);
            this.lbl_exchange_rate_date.TabIndex = 0;
            this.lbl_exchange_rate_date.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 356);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbl_exchange_rate_date);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dövizler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_exchange_rate_history)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_selling_usd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_buying_usd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView grd_exchange_rate_history;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbl_selling_eur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_buying_eur;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lbl_selling_gbp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_buying_gbp;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_exchange_rate_date;
    }
}

