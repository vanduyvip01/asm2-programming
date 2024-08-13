namespace ASM21
{
    partial class Form2
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
            this.lbCustomername = new System.Windows.Forms.Label();
            this.lbLastmonth = new System.Windows.Forms.Label();
            this.lbThismonth = new System.Windows.Forms.Label();
            this.lbCustomertype = new System.Windows.Forms.Label();
            this.lbPeople = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.nudNumberofpeople = new System.Windows.Forms.NumericUpDown();
            this.txtThismonthreading = new System.Windows.Forms.TextBox();
            this.txtLastmonthreading = new System.Windows.Forms.TextBox();
            this.txtCustomername = new System.Windows.Forms.TextBox();
            this.lsvbill = new System.Windows.Forms.ListView();
            this.colCustomername = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWaterlastmonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colWaterthismonth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomertype = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPeople = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalprice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txbResult = new System.Windows.Forms.TextBox();
            this.cboCustomertype = new System.Windows.Forms.ComboBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSort = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberofpeople)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbCustomername
            // 
            this.lbCustomername.AutoSize = true;
            this.lbCustomername.Location = new System.Drawing.Point(23, 18);
            this.lbCustomername.Name = "lbCustomername";
            this.lbCustomername.Size = new System.Drawing.Size(104, 16);
            this.lbCustomername.TabIndex = 0;
            this.lbCustomername.Text = "Customer Name";
            this.lbCustomername.Click += new System.EventHandler(this.lbCustomername_Click);
            // 
            // lbLastmonth
            // 
            this.lbLastmonth.AutoSize = true;
            this.lbLastmonth.Location = new System.Drawing.Point(22, 61);
            this.lbLastmonth.Name = "lbLastmonth";
            this.lbLastmonth.Size = new System.Drawing.Size(136, 16);
            this.lbLastmonth.TabIndex = 1;
            this.lbLastmonth.Text = "Last Month\'s Reading";
            // 
            // lbThismonth
            // 
            this.lbThismonth.AutoSize = true;
            this.lbThismonth.Location = new System.Drawing.Point(22, 108);
            this.lbThismonth.Name = "lbThismonth";
            this.lbThismonth.Size = new System.Drawing.Size(137, 16);
            this.lbThismonth.TabIndex = 2;
            this.lbThismonth.Text = "This Month\'s Reading";
            // 
            // lbCustomertype
            // 
            this.lbCustomertype.AutoSize = true;
            this.lbCustomertype.Location = new System.Drawing.Point(22, 155);
            this.lbCustomertype.Name = "lbCustomertype";
            this.lbCustomertype.Size = new System.Drawing.Size(99, 16);
            this.lbCustomertype.TabIndex = 3;
            this.lbCustomertype.Text = "Customer Type";
            // 
            // lbPeople
            // 
            this.lbPeople.AutoSize = true;
            this.lbPeople.Location = new System.Drawing.Point(22, 194);
            this.lbPeople.Name = "lbPeople";
            this.lbPeople.Size = new System.Drawing.Size(116, 16);
            this.lbPeople.TabIndex = 4;
            this.lbPeople.Text = "Number of People";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(109, 235);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(124, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // nudNumberofpeople
            // 
            this.nudNumberofpeople.Location = new System.Drawing.Point(179, 192);
            this.nudNumberofpeople.Name = "nudNumberofpeople";
            this.nudNumberofpeople.Size = new System.Drawing.Size(195, 22);
            this.nudNumberofpeople.TabIndex = 7;
            this.nudNumberofpeople.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtThismonthreading
            // 
            this.txtThismonthreading.Location = new System.Drawing.Point(179, 102);
            this.txtThismonthreading.Name = "txtThismonthreading";
            this.txtThismonthreading.Size = new System.Drawing.Size(193, 22);
            this.txtThismonthreading.TabIndex = 9;
            this.txtThismonthreading.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtLastmonthreading
            // 
            this.txtLastmonthreading.Location = new System.Drawing.Point(178, 55);
            this.txtLastmonthreading.Name = "txtLastmonthreading";
            this.txtLastmonthreading.Size = new System.Drawing.Size(194, 22);
            this.txtLastmonthreading.TabIndex = 10;
            // 
            // txtCustomername
            // 
            this.txtCustomername.Location = new System.Drawing.Point(178, 15);
            this.txtCustomername.Name = "txtCustomername";
            this.txtCustomername.Size = new System.Drawing.Size(193, 22);
            this.txtCustomername.TabIndex = 11;
            this.txtCustomername.TextChanged += new System.EventHandler(this.txtCustomername_TextChanged);
            // 
            // lsvbill
            // 
            this.lsvbill.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colCustomername,
            this.colWaterlastmonth,
            this.colWaterthismonth,
            this.colCustomertype,
            this.colPeople,
            this.colTotalprice});
            this.lsvbill.HideSelection = false;
            this.lsvbill.Location = new System.Drawing.Point(6, 168);
            this.lsvbill.Name = "lsvbill";
            this.lsvbill.Size = new System.Drawing.Size(844, 114);
            this.lsvbill.TabIndex = 12;
            this.lsvbill.UseCompatibleStateImageBehavior = false;
            this.lsvbill.View = System.Windows.Forms.View.Details;
            this.lsvbill.SelectedIndexChanged += new System.EventHandler(this.lsvbill_SelectedIndexChanged);
            // 
            // colCustomername
            // 
            this.colCustomername.Text = "Customer Name";
            this.colCustomername.Width = 130;
            // 
            // colWaterlastmonth
            // 
            this.colWaterlastmonth.Text = "Water Last Month\'s";
            this.colWaterlastmonth.Width = 135;
            // 
            // colWaterthismonth
            // 
            this.colWaterthismonth.Text = "Water This Month\'s";
            this.colWaterthismonth.Width = 136;
            // 
            // colCustomertype
            // 
            this.colCustomertype.Text = "Customer Type";
            this.colCustomertype.Width = 120;
            // 
            // colPeople
            // 
            this.colPeople.Text = "People";
            this.colPeople.Width = 70;
            // 
            // colTotalprice
            // 
            this.colTotalprice.Text = "Total Price";
            this.colTotalprice.Width = 103;
            // 
            // txbResult
            // 
            this.txbResult.Location = new System.Drawing.Point(6, 21);
            this.txbResult.Multiline = true;
            this.txbResult.Name = "txbResult";
            this.txbResult.Size = new System.Drawing.Size(598, 141);
            this.txbResult.TabIndex = 13;
            // 
            // cboCustomertype
            // 
            this.cboCustomertype.FormattingEnabled = true;
            this.cboCustomertype.Location = new System.Drawing.Point(179, 147);
            this.cboCustomertype.Name = "cboCustomertype";
            this.cboCustomertype.Size = new System.Drawing.Size(193, 24);
            this.cboCustomertype.TabIndex = 14;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(265, 235);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(124, 23);
            this.btnEdit.TabIndex = 15;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(425, 235);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(124, 23);
            this.btnRemove.TabIndex = 16;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(893, 633);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Location = new System.Drawing.Point(667, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(201, 198);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::ASM21.Properties.Resources.pngtree_cute_cartoon_water_drop_as_mason_character_png_image_11985098;
            this.pictureBox2.Location = new System.Drawing.Point(3, 18);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 177);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSort);
            this.groupBox3.Controls.Add(this.txtSearch);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.Controls.Add(this.txbResult);
            this.groupBox3.Controls.Add(this.lsvbill);
            this.groupBox3.Location = new System.Drawing.Point(11, 331);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(876, 288);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Result";
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(636, 107);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(75, 23);
            this.btnSort.TabIndex = 16;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(636, 21);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(159, 22);
            this.txtSearch.TabIndex = 15;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(636, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudNumberofpeople);
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.txtThismonthreading);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.txtLastmonthreading);
            this.groupBox2.Controls.Add(this.lbPeople);
            this.groupBox2.Controls.Add(this.cboCustomertype);
            this.groupBox2.Controls.Add(this.btnCalculate);
            this.groupBox2.Controls.Add(this.lbCustomertype);
            this.groupBox2.Controls.Add(this.lbCustomername);
            this.groupBox2.Controls.Add(this.txtCustomername);
            this.groupBox2.Controls.Add(this.lbLastmonth);
            this.groupBox2.Controls.Add(this.lbThismonth);
            this.groupBox2.Location = new System.Drawing.Point(11, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 273);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::ASM21.Properties.Resources.Picture4;
            this.pictureBox1.Location = new System.Drawing.Point(3, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(887, 612);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 632);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumberofpeople)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbCustomername;
        private System.Windows.Forms.Label lbLastmonth;
        private System.Windows.Forms.Label lbThismonth;
        private System.Windows.Forms.Label lbCustomertype;
        private System.Windows.Forms.Label lbPeople;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.NumericUpDown nudNumberofpeople;
        private System.Windows.Forms.TextBox txtThismonthreading;
        private System.Windows.Forms.TextBox txtLastmonthreading;
        private System.Windows.Forms.TextBox txtCustomername;
        private System.Windows.Forms.ListView lsvbill;
        private System.Windows.Forms.TextBox txbResult;
        private System.Windows.Forms.ComboBox cboCustomertype;
        private System.Windows.Forms.ColumnHeader colCustomername;
        private System.Windows.Forms.ColumnHeader colWaterlastmonth;
        private System.Windows.Forms.ColumnHeader colWaterthismonth;
        private System.Windows.Forms.ColumnHeader colCustomertype;
        private System.Windows.Forms.ColumnHeader colPeople;
        private System.Windows.Forms.ColumnHeader colTotalprice;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSort;
    }
}