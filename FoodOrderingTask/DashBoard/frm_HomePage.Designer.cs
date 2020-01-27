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
<<<<<<< HEAD
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle29 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle30 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle32 = new System.Windows.Forms.DataGridViewCellStyle();
=======
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_Username = new System.Windows.Forms.Label();
            this.lab_Role = new System.Windows.Forms.Label();
            this.dgv_FoodList = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_RecentPurchase = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
            this.lab_Status = new System.Windows.Forms.Label();
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
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
            this.label5.Location = new System.Drawing.Point(24, 9);
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
<<<<<<< HEAD
            dataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle29.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle29.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle29.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle29.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle29.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle29;
=======
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
            this.dgv_FoodList.ColumnHeadersHeight = 50;
            this.dgv_FoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_Name,
            this.M_price,
            this.M_Type});
<<<<<<< HEAD
            dataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle30.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle30.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle30.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle30.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle30.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle30.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FoodList.DefaultCellStyle = dataGridViewCellStyle30;
            this.dgv_FoodList.Location = new System.Drawing.Point(34, 282);
            this.dgv_FoodList.Name = "dgv_FoodList";
            this.dgv_FoodList.ReadOnly = true;
            this.dgv_FoodList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle31.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle31.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle31.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle31.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle31.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle31.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodList.RowHeadersDefaultCellStyle = dataGridViewCellStyle31;
            this.dgv_FoodList.RowHeadersWidth = 10;
            dataGridViewCellStyle32.BackColor = System.Drawing.Color.White;
            this.dgv_FoodList.RowsDefaultCellStyle = dataGridViewCellStyle32;
=======
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FoodList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_FoodList.Location = new System.Drawing.Point(22, 282);
            this.dgv_FoodList.Name = "dgv_FoodList";
            this.dgv_FoodList.ReadOnly = true;
            this.dgv_FoodList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodList.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_FoodList.RowHeadersWidth = 10;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            this.dgv_FoodList.RowsDefaultCellStyle = dataGridViewCellStyle8;
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
            this.dgv_FoodList.RowTemplate.Height = 50;
            this.dgv_FoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FoodList.Size = new System.Drawing.Size(689, 367);
            this.dgv_FoodList.TabIndex = 1031;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(28, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 36);
            this.label2.TabIndex = 1033;
            this.label2.Text = "RECENT PURCHASES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 36);
            this.label3.TabIndex = 1035;
            this.label3.Text = "NO RECENT PURCHASES";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            // pnl_RecentPurchase
            // 
            this.pnl_RecentPurchase.Controls.Add(this.label1);
            this.pnl_RecentPurchase.Location = new System.Drawing.Point(34, 282);
            this.pnl_RecentPurchase.Name = "pnl_RecentPurchase";
            this.pnl_RecentPurchase.Size = new System.Drawing.Size(689, 367);
            this.pnl_RecentPurchase.TabIndex = 1036;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(176, 159);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 36);
            this.label1.TabIndex = 1035;
            this.label1.Text = "NO RECENT PURCHASES";
            this.label1.Click += new System.EventHandler(this.label3_Click);
            // 
<<<<<<< HEAD
=======
            // lab_Status
            // 
            this.lab_Status.AutoSize = true;
            this.lab_Status.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lab_Status.Location = new System.Drawing.Point(28, 194);
            this.lab_Status.Name = "lab_Status";
            this.lab_Status.Size = new System.Drawing.Size(340, 36);
            this.lab_Status.TabIndex = 1035;
            this.lab_Status.Text = "NO RECENT PURCHASES";
            // 
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
            // lab_DeliveryStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 675);
<<<<<<< HEAD
=======
            this.Controls.Add(this.lab_Status);
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
            this.Controls.Add(this.pnl_RecentPurchase);
            this.Controls.Add(this.label3);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
        private System.Windows.Forms.Panel pnl_RecentPurchase;
        private System.Windows.Forms.Label label1;
<<<<<<< HEAD
=======
        private System.Windows.Forms.Label lab_Status;
>>>>>>> feefd190f6863864c1b496ed201a658a38d30e66
    }
}