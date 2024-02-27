namespace PizzaOrderReceipt
{
    partial class Billing
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExtraLargeBtn = new System.Windows.Forms.RadioButton();
            this.LargeBtn = new System.Windows.Forms.RadioButton();
            this.MediumBtn = new System.Windows.Forms.RadioButton();
            this.SmallBtn = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.QtyTb = new System.Windows.Forms.TextBox();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.SettingsBtn = new System.Windows.Forms.Button();
            this.BillDGV = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.GrdTotalLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(192, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pizza Ordering Management System\r\n";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 664);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PizzaOrderReceipt.Properties.Resources.chef;
            this.pictureBox2.Location = new System.Drawing.Point(3, 597);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(77, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(14, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please Select A Pizza\r\n";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExtraLargeBtn);
            this.panel2.Controls.Add(this.LargeBtn);
            this.panel2.Controls.Add(this.MediumBtn);
            this.panel2.Controls.Add(this.SmallBtn);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(194, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 227);
            this.panel2.TabIndex = 4;
            // 
            // ExtraLargeBtn
            // 
            this.ExtraLargeBtn.AutoSize = true;
            this.ExtraLargeBtn.Location = new System.Drawing.Point(14, 194);
            this.ExtraLargeBtn.Name = "ExtraLargeBtn";
            this.ExtraLargeBtn.Size = new System.Drawing.Size(104, 24);
            this.ExtraLargeBtn.TabIndex = 7;
            this.ExtraLargeBtn.TabStop = true;
            this.ExtraLargeBtn.Text = "Extra Large";
            this.ExtraLargeBtn.UseVisualStyleBackColor = true;
            // 
            // LargeBtn
            // 
            this.LargeBtn.AutoSize = true;
            this.LargeBtn.Location = new System.Drawing.Point(14, 147);
            this.LargeBtn.Name = "LargeBtn";
            this.LargeBtn.Size = new System.Drawing.Size(67, 24);
            this.LargeBtn.TabIndex = 6;
            this.LargeBtn.TabStop = true;
            this.LargeBtn.Text = "Large";
            this.LargeBtn.UseVisualStyleBackColor = true;
            // 
            // MediumBtn
            // 
            this.MediumBtn.AutoSize = true;
            this.MediumBtn.Location = new System.Drawing.Point(14, 100);
            this.MediumBtn.Name = "MediumBtn";
            this.MediumBtn.Size = new System.Drawing.Size(85, 24);
            this.MediumBtn.TabIndex = 5;
            this.MediumBtn.TabStop = true;
            this.MediumBtn.Text = "Medium";
            this.MediumBtn.UseVisualStyleBackColor = true;
            // 
            // SmallBtn
            // 
            this.SmallBtn.AutoSize = true;
            this.SmallBtn.Location = new System.Drawing.Point(14, 55);
            this.SmallBtn.Name = "SmallBtn";
            this.SmallBtn.Size = new System.Drawing.Size(67, 24);
            this.SmallBtn.TabIndex = 4;
            this.SmallBtn.TabStop = true;
            this.SmallBtn.Text = "Small";
            this.SmallBtn.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(234, 353);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantity";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // QtyTb
            // 
            this.QtyTb.Location = new System.Drawing.Point(232, 377);
            this.QtyTb.Name = "QtyTb";
            this.QtyTb.Size = new System.Drawing.Size(132, 27);
            this.QtyTb.TabIndex = 6;
            // 
            // OrderBtn
            // 
            this.OrderBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.OrderBtn.ForeColor = System.Drawing.Color.Bisque;
            this.OrderBtn.Location = new System.Drawing.Point(218, 425);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(166, 53);
            this.OrderBtn.TabIndex = 14;
            this.OrderBtn.Text = "Add To Your Order";
            this.OrderBtn.UseVisualStyleBackColor = false;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.BackColor = System.Drawing.Color.Goldenrod;
            this.SettingsBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SettingsBtn.Location = new System.Drawing.Point(192, 556);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.Size = new System.Drawing.Size(183, 45);
            this.SettingsBtn.TabIndex = 15;
            this.SettingsBtn.Text = "Set The Prices";
            this.SettingsBtn.UseVisualStyleBackColor = false;
            this.SettingsBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // BillDGV
            // 
            this.BillDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.BillDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BillDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.BillDGV.GridColor = System.Drawing.SystemColors.Window;
            this.BillDGV.Location = new System.Drawing.Point(462, 95);
            this.BillDGV.Name = "BillDGV";
            this.BillDGV.RowHeadersWidth = 51;
            this.BillDGV.RowTemplate.Height = 29;
            this.BillDGV.Size = new System.Drawing.Size(679, 378);
            this.BillDGV.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Item";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // PrintBtn
            // 
            this.PrintBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.PrintBtn.ForeColor = System.Drawing.Color.Bisque;
            this.PrintBtn.Location = new System.Drawing.Point(734, 544);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(179, 57);
            this.PrintBtn.TabIndex = 17;
            this.PrintBtn.Text = "Print Your Order";
            this.PrintBtn.UseVisualStyleBackColor = false;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // GrdTotalLbl
            // 
            this.GrdTotalLbl.AutoSize = true;
            this.GrdTotalLbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GrdTotalLbl.Location = new System.Drawing.Point(776, 512);
            this.GrdTotalLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GrdTotalLbl.Name = "GrdTotalLbl";
            this.GrdTotalLbl.Size = new System.Drawing.Size(79, 20);
            this.GrdTotalLbl.TabIndex = 18;
            this.GrdTotalLbl.Text = "GrdTotalbl";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(1140, -9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 47);
            this.label5.TabIndex = 19;
            this.label5.Text = "x";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(394, 556);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 45);
            this.button1.TabIndex = 20;
            this.button1.Text = "Logout";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PizzaOrderReceipt.Properties.Resources.pizza_logo_template_design_183c12cfbe00ef109c299d864f364e58_screen;
            this.pictureBox3.Location = new System.Drawing.Point(1038, 582);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1173, 664);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.GrdTotalLbl);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.BillDGV);
            this.Controls.Add(this.SettingsBtn);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.QtyTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Billing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Billing";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label2;
        private Panel panel2;
        private RadioButton ExtraLargeBtn;
        private RadioButton LargeBtn;
        private RadioButton MediumBtn;
        private RadioButton SmallBtn;
        private Label label3;
        private TextBox QtyTb;
        private Button OrderBtn;
        private Button SettingsBtn;
        private DataGridView BillDGV;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Button PrintBtn;
        private Label GrdTotalLbl;
        private Label label5;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}