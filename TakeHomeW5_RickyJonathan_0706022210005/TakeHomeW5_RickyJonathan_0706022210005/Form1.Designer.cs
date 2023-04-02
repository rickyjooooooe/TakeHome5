namespace TakeHomeW5_RickyJonathan_0706022210005
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
            this.dtproduksimpan = new System.Windows.Forms.DataGridView();
            this.dtcategory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textboxnama = new System.Windows.Forms.TextBox();
            this.comboboxcat = new System.Windows.Forms.ComboBox();
            this.textboxharga = new System.Windows.Forms.TextBox();
            this.textboxstok = new System.Windows.Forms.TextBox();
            this.textboxnamacat = new System.Windows.Forms.TextBox();
            this.buttonall = new System.Windows.Forms.Button();
            this.buttonfilter = new System.Windows.Forms.Button();
            this.comboboxfilter = new System.Windows.Forms.ComboBox();
            this.buttonaddprod = new System.Windows.Forms.Button();
            this.buttonedit = new System.Windows.Forms.Button();
            this.buttonremoveprod = new System.Windows.Forms.Button();
            this.buttonremovecat = new System.Windows.Forms.Button();
            this.buttonaddcat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtproduksimpan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dtproduksimpan
            // 
            this.dtproduksimpan.AllowUserToAddRows = false;
            this.dtproduksimpan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtproduksimpan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtproduksimpan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtproduksimpan.Location = new System.Drawing.Point(39, 69);
            this.dtproduksimpan.Name = "dtproduksimpan";
            this.dtproduksimpan.RowHeadersVisible = false;
            this.dtproduksimpan.RowHeadersWidth = 62;
            this.dtproduksimpan.RowTemplate.Height = 28;
            this.dtproduksimpan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtproduksimpan.Size = new System.Drawing.Size(489, 229);
            this.dtproduksimpan.TabIndex = 0;
            // 
            // dtcategory
            // 
            this.dtcategory.AllowUserToAddRows = false;
            this.dtcategory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtcategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtcategory.Location = new System.Drawing.Point(700, 62);
            this.dtcategory.Name = "dtcategory";
            this.dtcategory.RowHeadersVisible = false;
            this.dtcategory.RowHeadersWidth = 62;
            this.dtcategory.RowTemplate.Height = 28;
            this.dtcategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtcategory.Size = new System.Drawing.Size(266, 200);
            this.dtcategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "PRODUCT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(695, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "CATEGORY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "DETAILS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 358);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nama :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 396);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Category :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 434);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Harga :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 473);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Stok :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(699, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Nama :";
            // 
            // textboxnama
            // 
            this.textboxnama.Location = new System.Drawing.Point(100, 358);
            this.textboxnama.Name = "textboxnama";
            this.textboxnama.Size = new System.Drawing.Size(230, 26);
            this.textboxnama.TabIndex = 10;
            // 
            // comboboxcat
            // 
            this.comboboxcat.FormattingEnabled = true;
            this.comboboxcat.Location = new System.Drawing.Point(100, 393);
            this.comboboxcat.Name = "comboboxcat";
            this.comboboxcat.Size = new System.Drawing.Size(134, 28);
            this.comboboxcat.TabIndex = 11;
            // 
            // textboxharga
            // 
            this.textboxharga.Location = new System.Drawing.Point(100, 431);
            this.textboxharga.Name = "textboxharga";
            this.textboxharga.Size = new System.Drawing.Size(134, 26);
            this.textboxharga.TabIndex = 12;
            // 
            // textboxstok
            // 
            this.textboxstok.Location = new System.Drawing.Point(100, 470);
            this.textboxstok.Name = "textboxstok";
            this.textboxstok.Size = new System.Drawing.Size(134, 26);
            this.textboxstok.TabIndex = 13;
            // 
            // textboxnamacat
            // 
            this.textboxnamacat.Location = new System.Drawing.Point(764, 275);
            this.textboxnamacat.Name = "textboxnamacat";
            this.textboxnamacat.Size = new System.Drawing.Size(205, 26);
            this.textboxnamacat.TabIndex = 14;
            // 
            // buttonall
            // 
            this.buttonall.Location = new System.Drawing.Point(233, 19);
            this.buttonall.Name = "buttonall";
            this.buttonall.Size = new System.Drawing.Size(85, 31);
            this.buttonall.TabIndex = 15;
            this.buttonall.Text = "ALL";
            this.buttonall.UseVisualStyleBackColor = true;
            this.buttonall.Click += new System.EventHandler(this.buttonall_Click);
            // 
            // buttonfilter
            // 
            this.buttonfilter.Location = new System.Drawing.Point(324, 19);
            this.buttonfilter.Name = "buttonfilter";
            this.buttonfilter.Size = new System.Drawing.Size(87, 31);
            this.buttonfilter.TabIndex = 16;
            this.buttonfilter.Text = "FILTER";
            this.buttonfilter.UseVisualStyleBackColor = true;
            this.buttonfilter.Click += new System.EventHandler(this.buttonfilter_Click);
            // 
            // comboboxfilter
            // 
            this.comboboxfilter.Enabled = false;
            this.comboboxfilter.FormattingEnabled = true;
            this.comboboxfilter.Location = new System.Drawing.Point(417, 19);
            this.comboboxfilter.Name = "comboboxfilter";
            this.comboboxfilter.Size = new System.Drawing.Size(111, 28);
            this.comboboxfilter.TabIndex = 17;
            this.comboboxfilter.SelectedIndexChanged += new System.EventHandler(this.comboboxfilter_SelectedIndexChanged);
            // 
            // buttonaddprod
            // 
            this.buttonaddprod.Location = new System.Drawing.Point(255, 402);
            this.buttonaddprod.Name = "buttonaddprod";
            this.buttonaddprod.Size = new System.Drawing.Size(91, 85);
            this.buttonaddprod.TabIndex = 18;
            this.buttonaddprod.Text = "Add Product";
            this.buttonaddprod.UseVisualStyleBackColor = true;
            this.buttonaddprod.Click += new System.EventHandler(this.buttonaddprod_Click);
            // 
            // buttonedit
            // 
            this.buttonedit.Location = new System.Drawing.Point(352, 402);
            this.buttonedit.Name = "buttonedit";
            this.buttonedit.Size = new System.Drawing.Size(91, 85);
            this.buttonedit.TabIndex = 19;
            this.buttonedit.Text = "Edit Product";
            this.buttonedit.UseVisualStyleBackColor = true;
            this.buttonedit.Click += new System.EventHandler(this.buttonedit_Click);
            // 
            // buttonremoveprod
            // 
            this.buttonremoveprod.Location = new System.Drawing.Point(449, 402);
            this.buttonremoveprod.Name = "buttonremoveprod";
            this.buttonremoveprod.Size = new System.Drawing.Size(87, 85);
            this.buttonremoveprod.TabIndex = 20;
            this.buttonremoveprod.Text = "Remove Product";
            this.buttonremoveprod.UseVisualStyleBackColor = true;
            this.buttonremoveprod.Click += new System.EventHandler(this.buttonremoveprod_Click);
            // 
            // buttonremovecat
            // 
            this.buttonremovecat.Location = new System.Drawing.Point(873, 317);
            this.buttonremovecat.Name = "buttonremovecat";
            this.buttonremovecat.Size = new System.Drawing.Size(82, 61);
            this.buttonremovecat.TabIndex = 22;
            this.buttonremovecat.Text = "Remove Category";
            this.buttonremovecat.UseVisualStyleBackColor = true;
            this.buttonremovecat.Click += new System.EventHandler(this.buttonremovecat_Click);
            // 
            // buttonaddcat
            // 
            this.buttonaddcat.Location = new System.Drawing.Point(776, 317);
            this.buttonaddcat.Name = "buttonaddcat";
            this.buttonaddcat.Size = new System.Drawing.Size(86, 61);
            this.buttonaddcat.TabIndex = 21;
            this.buttonaddcat.Text = "Add Category";
            this.buttonaddcat.UseVisualStyleBackColor = true;
            this.buttonaddcat.Click += new System.EventHandler(this.buttonaddcat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 543);
            this.Controls.Add(this.buttonremovecat);
            this.Controls.Add(this.buttonaddcat);
            this.Controls.Add(this.buttonremoveprod);
            this.Controls.Add(this.buttonedit);
            this.Controls.Add(this.buttonaddprod);
            this.Controls.Add(this.comboboxfilter);
            this.Controls.Add(this.buttonfilter);
            this.Controls.Add(this.buttonall);
            this.Controls.Add(this.textboxnamacat);
            this.Controls.Add(this.textboxstok);
            this.Controls.Add(this.textboxharga);
            this.Controls.Add(this.comboboxcat);
            this.Controls.Add(this.textboxnama);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtcategory);
            this.Controls.Add(this.dtproduksimpan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtproduksimpan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtcategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtproduksimpan;
        private System.Windows.Forms.DataGridView dtcategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textboxnama;
        private System.Windows.Forms.ComboBox comboboxcat;
        private System.Windows.Forms.TextBox textboxharga;
        private System.Windows.Forms.TextBox textboxstok;
        private System.Windows.Forms.TextBox textboxnamacat;
        private System.Windows.Forms.Button buttonall;
        private System.Windows.Forms.Button buttonfilter;
        private System.Windows.Forms.ComboBox comboboxfilter;
        private System.Windows.Forms.Button buttonaddprod;
        private System.Windows.Forms.Button buttonedit;
        private System.Windows.Forms.Button buttonremoveprod;
        private System.Windows.Forms.Button buttonremovecat;
        private System.Windows.Forms.Button buttonaddcat;
    }
}

