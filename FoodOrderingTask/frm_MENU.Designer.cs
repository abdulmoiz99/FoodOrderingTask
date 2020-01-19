namespace FoodOrderingTask
{
    partial class frm_MENU
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_MENU));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rb_Asian = new System.Windows.Forms.RadioButton();
            this.rb_Eastern = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.rb_Western = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_Find = new System.Windows.Forms.TextBox();
            this.dgv_FoodList = new System.Windows.Forms.DataGridView();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lab_Price = new System.Windows.Forms.Label();
            this.lab_Price1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lab_Name = new System.Windows.Forms.Label();
            this.lab_Name1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_AddToCart = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(322, 36);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(143, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.rb_Asian);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.rb_Eastern);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.rb_Western);
            this.panel2.Location = new System.Drawing.Point(36, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(774, 199);
            this.panel2.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 142);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // rb_Asian
            // 
            this.rb_Asian.AutoSize = true;
            this.rb_Asian.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Asian.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.rb_Asian.Location = new System.Drawing.Point(604, 3);
            this.rb_Asian.Name = "rb_Asian";
            this.rb_Asian.Size = new System.Drawing.Size(79, 27);
            this.rb_Asian.TabIndex = 12;
            this.rb_Asian.TabStop = true;
            this.rb_Asian.Text = "Asian";
            this.rb_Asian.UseVisualStyleBackColor = true;
            this.rb_Asian.CheckedChanged += new System.EventHandler(this.rb_Asian_CheckedChanged);
            // 
            // rb_Eastern
            // 
            this.rb_Eastern.AutoSize = true;
            this.rb_Eastern.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Eastern.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.rb_Eastern.Location = new System.Drawing.Point(322, 3);
            this.rb_Eastern.Name = "rb_Eastern";
            this.rb_Eastern.Size = new System.Drawing.Size(130, 27);
            this.rb_Eastern.TabIndex = 12;
            this.rb_Eastern.TabStop = true;
            this.rb_Eastern.Text = "MiddleEast";
            this.rb_Eastern.UseVisualStyleBackColor = true;
            this.rb_Eastern.CheckedChanged += new System.EventHandler(this.rb_Eastern_CheckedChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(37, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(143, 142);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // rb_Western
            // 
            this.rb_Western.AutoSize = true;
            this.rb_Western.Checked = true;
            this.rb_Western.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Western.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.rb_Western.Location = new System.Drawing.Point(37, 3);
            this.rb_Western.Name = "rb_Western";
            this.rb_Western.Size = new System.Drawing.Size(100, 27);
            this.rb_Western.TabIndex = 12;
            this.rb_Western.TabStop = true;
            this.rb_Western.Text = "Western";
            this.rb_Western.UseVisualStyleBackColor = true;
            this.rb_Western.CheckedChanged += new System.EventHandler(this.rb_Western_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txt_Find);
            this.groupBox1.Location = new System.Drawing.Point(36, 219);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(774, 100);
            this.groupBox1.TabIndex = 1020;
            this.groupBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(21, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(560, 4);
            this.panel4.TabIndex = 1020;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Here";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(586, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "FIND FOOD";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // txt_Find
            // 
            this.txt_Find.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Find.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Find.Location = new System.Drawing.Point(21, 45);
            this.txt_Find.Name = "txt_Find";
            this.txt_Find.Size = new System.Drawing.Size(560, 26);
            this.txt_Find.TabIndex = 0;
            this.txt_Find.TextChanged += new System.EventHandler(this.txt_Find_TextChanged);
            // 
            // dgv_FoodList
            // 
            this.dgv_FoodList.AllowUserToAddRows = false;
            this.dgv_FoodList.AllowUserToDeleteRows = false;
            this.dgv_FoodList.AllowUserToOrderColumns = true;
            this.dgv_FoodList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_FoodList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_FoodList.ColumnHeadersHeight = 50;
            this.dgv_FoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_Name,
            this.M_price,
            this.M_Type});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FoodList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_FoodList.Location = new System.Drawing.Point(36, 407);
            this.dgv_FoodList.Name = "dgv_FoodList";
            this.dgv_FoodList.ReadOnly = true;
            this.dgv_FoodList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_FoodList.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_FoodList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_FoodList.RowTemplate.Height = 50;
            this.dgv_FoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FoodList.Size = new System.Drawing.Size(394, 270);
            this.dgv_FoodList.TabIndex = 1021;
            this.dgv_FoodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FoodList_CellContentClick);
            // 
            // M_Name
            // 
            this.M_Name.DataPropertyName = "M_Name";
            this.M_Name.HeaderText = "MENU";
            this.M_Name.Name = "M_Name";
            this.M_Name.ReadOnly = true;
            this.M_Name.Width = 365;
            // 
            // M_price
            // 
            this.M_price.DataPropertyName = "M_price";
            this.M_price.HeaderText = "Price";
            this.M_price.Name = "M_price";
            this.M_price.ReadOnly = true;
            this.M_price.Visible = false;
            // 
            // M_Type
            // 
            this.M_Type.DataPropertyName = "M_Type";
            this.M_Type.HeaderText = "M_Type";
            this.M_Type.Name = "M_Type";
            this.M_Type.ReadOnly = true;
            this.M_Type.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel5.Controls.Add(this.lab_Price);
            this.panel5.Controls.Add(this.lab_Price1);
            this.panel5.Controls.Add(this.panel6);
            this.panel5.Controls.Add(this.lab_Name);
            this.panel5.Controls.Add(this.lab_Name1);
            this.panel5.Location = new System.Drawing.Point(437, 388);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(373, 148);
            this.panel5.TabIndex = 1025;
            // 
            // lab_Price
            // 
            this.lab_Price.AutoSize = true;
            this.lab_Price.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.lab_Price.Location = new System.Drawing.Point(99, 84);
            this.lab_Price.Name = "lab_Price";
            this.lab_Price.Size = new System.Drawing.Size(62, 25);
            this.lab_Price.TabIndex = 1023;
            this.lab_Price.Text = "Price";
            this.lab_Price.Visible = false;
            // 
            // lab_Price1
            // 
            this.lab_Price1.AutoSize = true;
            this.lab_Price1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Price1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.lab_Price1.Location = new System.Drawing.Point(18, 84);
            this.lab_Price1.Name = "lab_Price1";
            this.lab_Price1.Size = new System.Drawing.Size(62, 25);
            this.lab_Price1.TabIndex = 1023;
            this.lab_Price1.Text = "Price";
            this.lab_Price1.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.Location = new System.Drawing.Point(18, 60);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(350, 3);
            this.panel6.TabIndex = 1022;
            // 
            // lab_Name
            // 
            this.lab_Name.AutoSize = true;
            this.lab_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Name.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.lab_Name.Location = new System.Drawing.Point(94, 24);
            this.lab_Name.Name = "lab_Name";
            this.lab_Name.Size = new System.Drawing.Size(81, 25);
            this.lab_Name.TabIndex = 1023;
            this.lab_Name.Text = "Name ";
            this.lab_Name.Visible = false;
            // 
            // lab_Name1
            // 
            this.lab_Name1.AutoSize = true;
            this.lab_Name1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Name1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.lab_Name1.Location = new System.Drawing.Point(13, 24);
            this.lab_Name1.Name = "lab_Name1";
            this.lab_Name1.Size = new System.Drawing.Size(81, 25);
            this.lab_Name1.TabIndex = 1023;
            this.lab_Name1.Text = "Name ";
            this.lab_Name1.Visible = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(436, 325);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(374, 65);
            this.panel7.TabIndex = 1024;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 32);
            this.label2.TabIndex = 1022;
            this.label2.Text = "Selected";
            // 
            // btn_AddToCart
            // 
            this.btn_AddToCart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.btn_AddToCart.FlatAppearance.BorderSize = 0;
            this.btn_AddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddToCart.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddToCart.ForeColor = System.Drawing.Color.White;
            this.btn_AddToCart.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddToCart.Image")));
            this.btn_AddToCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddToCart.Location = new System.Drawing.Point(437, 542);
            this.btn_AddToCart.Name = "btn_AddToCart";
            this.btn_AddToCart.Size = new System.Drawing.Size(373, 53);
            this.btn_AddToCart.TabIndex = 1026;
            this.btn_AddToCart.Text = "ADD TO CART";
            this.btn_AddToCart.UseVisualStyleBackColor = false;
            this.btn_AddToCart.Click += new System.EventHandler(this.btn_AddToCart_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(928, 82);
            this.panel8.TabIndex = 1027;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(39, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 56);
            this.label5.TabIndex = 1022;
            this.label5.Text = "MENU";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.btn_AddToCart);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 633);
            this.panel3.TabIndex = 1029;
            // 
            // frm_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 715);
            this.Controls.Add(this.dgv_FoodList);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_MENU";
            this.Text = "frm_MENU";
            this.Activated += new System.EventHandler(this.frm_MENU_Activated);
            this.Load += new System.EventHandler(this.frm_MENU_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rb_Eastern;
        private System.Windows.Forms.RadioButton rb_Western;
        private System.Windows.Forms.RadioButton rb_Asian;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_Find;
        private System.Windows.Forms.DataGridView dgv_FoodList;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lab_Price1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lab_Name1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lab_Price;
        private System.Windows.Forms.Label lab_Name;
        private System.Windows.Forms.Button btn_AddToCart;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
    }
}