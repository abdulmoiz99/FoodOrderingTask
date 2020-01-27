namespace FoodOrderingTask.DashBoard
{
    partial class lab_DeliveryStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_Username = new System.Windows.Forms.Label();
            this.lab_Role = new System.Windows.Forms.Label();
            this.dgv_FoodList = new System.Windows.Forms.DataGridView();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_RecentPurchase = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).BeginInit();
            this.pnl_RecentPurchase.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(934, 82);
            this.panel8.TabIndex = 1029;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 56);
            this.label5.TabIndex = 1022;
            this.label5.Text = "WELCOME ";
            // 
            // lab_Username
            // 
            this.lab_Username.AutoSize = true;
            this.lab_Username.BackColor = System.Drawing.Color.Transparent;
            this.lab_Username.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.lab_Username.Location = new System.Drawing.Point(24, 101);
            this.lab_Username.Name = "lab_Username";
            this.lab_Username.Size = new System.Drawing.Size(259, 56);
            this.lab_Username.TabIndex = 1030;
            this.lab_Username.Text = "Username";
            this.lab_Username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lab_Username.Click += new System.EventHandler(this.lab_Username_Click);
            // 
            // lab_Role
            // 
            this.lab_Role.AutoSize = true;
            this.lab_Role.BackColor = System.Drawing.Color.Transparent;
            this.lab_Role.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Role.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.lab_Role.Location = new System.Drawing.Point(30, 157);
            this.lab_Role.Name = "lab_Role";
            this.lab_Role.Size = new System.Drawing.Size(103, 23);
            this.lab_Role.TabIndex = 1030;
            this.lab_Role.Text = "Username";
            this.lab_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.dgv_FoodList.Location = new System.Drawing.Point(22, 282);
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
            this.dgv_FoodList.Size = new System.Drawing.Size(722, 367);
            this.dgv_FoodList.TabIndex = 1031;
            // 
            // M_Name
            // 
            this.M_Name.DataPropertyName = "C_Name";
            this.M_Name.HeaderText = "Name";
            this.M_Name.Name = "M_Name";
            this.M_Name.ReadOnly = true;
            this.M_Name.Width = 380;
            // 
            // M_price
            // 
            this.M_price.DataPropertyName = "C_price";
            this.M_price.HeaderText = "Price";
            this.M_price.Name = "M_price";
            this.M_price.ReadOnly = true;
            this.M_price.Width = 150;
            // 
            // M_Type
            // 
            this.M_Type.DataPropertyName = "C_Type";
            this.M_Type.HeaderText = "Type";
            this.M_Type.Name = "M_Type";
            this.M_Type.ReadOnly = true;
            this.M_Type.Width = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(16, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 36);
            this.label2.TabIndex = 1033;
            this.label2.Text = "RECENT PURCHASES";
            // 
            // pnl_RecentPurchase
            // 
            this.pnl_RecentPurchase.Controls.Add(this.label1);
            this.pnl_RecentPurchase.Location = new System.Drawing.Point(22, 233);
            this.pnl_RecentPurchase.Name = "pnl_RecentPurchase";
            this.pnl_RecentPurchase.Size = new System.Drawing.Size(722, 416);
            this.pnl_RecentPurchase.TabIndex = 1034;
            this.pnl_RecentPurchase.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(199, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 36);
            this.label1.TabIndex = 1034;
            this.label1.Text = "NO RECENT PURCHASES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(28, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 36);
            this.label3.TabIndex = 1034;
            this.label3.Text = "NO RECENT PURCHASES";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // lab_DeliveryStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 661);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnl_RecentPurchase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_FoodList);
            this.Controls.Add(this.lab_Role);
            this.Controls.Add(this.lab_Username);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "lab_DeliveryStatus";
            this.Text = "frm_HomePage";
            this.Activated += new System.EventHandler(this.frm_HomePage_Activated);
            this.Load += new System.EventHandler(this.frm_HomePage_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).EndInit();
            this.pnl_RecentPurchase.ResumeLayout(false);
            this.pnl_RecentPurchase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_Username;
        private System.Windows.Forms.Label lab_Role;
        private System.Windows.Forms.DataGridView dgv_FoodList;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_RecentPurchase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}