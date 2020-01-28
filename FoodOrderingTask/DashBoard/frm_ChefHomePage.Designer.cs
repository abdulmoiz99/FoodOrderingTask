namespace FoodOrderingTask.DashBoard
{
    partial class frm_ChefHomePage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lab_Username = new System.Windows.Forms.Label();
            this.lab_Role = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_FoodList = new System.Windows.Forms.DataGridView();
            this.pnl_RecentSales = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Paid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).BeginInit();
            this.pnl_RecentSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.TopPanel.Controls.Add(this.label5);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(934, 85);
            this.TopPanel.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(24, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 56);
            this.label5.TabIndex = 1023;
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
            this.lab_Username.TabIndex = 1031;
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
            this.lab_Role.TabIndex = 1032;
            this.lab_Role.Text = "Username";
            this.lab_Role.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(28, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 36);
            this.label3.TabIndex = 1036;
            this.label3.Text = "NO RECENT SALES";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(28, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 36);
            this.label2.TabIndex = 1037;
            this.label2.Text = "RECENT SALES";
            // 
            // dgv_FoodList
            // 
            this.dgv_FoodList.AllowUserToAddRows = false;
            this.dgv_FoodList.AllowUserToDeleteRows = false;
            this.dgv_FoodList.AllowUserToOrderColumns = true;
            this.dgv_FoodList.BackgroundColor = System.Drawing.Color.White;
            this.dgv_FoodList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_FoodList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_FoodList.ColumnHeadersHeight = 50;
            this.dgv_FoodList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.M_Name,
            this.M_price,
            this.C_Customer,
            this.M_Type,
            this.C_Paid,
            this.C_PaymentMethod,
            this.C_Status});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_FoodList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_FoodList.Location = new System.Drawing.Point(34, 282);
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
            this.dgv_FoodList.RowTemplate.Height = 50;
            this.dgv_FoodList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_FoodList.Size = new System.Drawing.Size(689, 367);
            this.dgv_FoodList.TabIndex = 1038;
            this.dgv_FoodList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_FoodList_CellContentClick);
            // 
            // pnl_RecentSales
            // 
            this.pnl_RecentSales.Controls.Add(this.label1);
            this.pnl_RecentSales.Location = new System.Drawing.Point(34, 282);
            this.pnl_RecentSales.Name = "pnl_RecentSales";
            this.pnl_RecentSales.Size = new System.Drawing.Size(689, 367);
            this.pnl_RecentSales.TabIndex = 1039;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(216, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 36);
            this.label1.TabIndex = 1035;
            this.label1.Text = "NO RECENT SALES";
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
            // C_Customer
            // 
            this.C_Customer.DataPropertyName = "C_Buyer";
            this.C_Customer.HeaderText = "Customer";
            this.C_Customer.Name = "C_Customer";
            this.C_Customer.ReadOnly = true;
            // 
            // M_Type
            // 
            this.M_Type.DataPropertyName = "C_Type";
            this.M_Type.HeaderText = "Type";
            this.M_Type.Name = "M_Type";
            this.M_Type.ReadOnly = true;
            this.M_Type.Width = 150;
            // 
            // C_Paid
            // 
            this.C_Paid.DataPropertyName = "C_Paid";
            this.C_Paid.HeaderText = "Paid";
            this.C_Paid.Name = "C_Paid";
            this.C_Paid.ReadOnly = true;
            // 
            // C_PaymentMethod
            // 
            this.C_PaymentMethod.DataPropertyName = "C_PaymentMethod";
            this.C_PaymentMethod.HeaderText = "PaymentMethod";
            this.C_PaymentMethod.Name = "C_PaymentMethod";
            this.C_PaymentMethod.ReadOnly = true;
            // 
            // C_Status
            // 
            this.C_Status.DataPropertyName = "C_Status";
            this.C_Status.HeaderText = "Status";
            this.C_Status.Name = "C_Status";
            this.C_Status.ReadOnly = true;
            // 
            // frm_ChefHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 675);
            this.Controls.Add(this.pnl_RecentSales);
            this.Controls.Add(this.dgv_FoodList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_Role);
            this.Controls.Add(this.lab_Username);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChefHomePage";
            this.Text = "frm_ChefHomePage";
            this.Activated += new System.EventHandler(this.frm_ChefHomePage_Activated);
            this.Load += new System.EventHandler(this.frm_ChefHomePage_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).EndInit();
            this.pnl_RecentSales.ResumeLayout(false);
            this.pnl_RecentSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lab_Username;
        private System.Windows.Forms.Label lab_Role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_FoodList;
        private System.Windows.Forms.Panel pnl_RecentSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Paid;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_PaymentMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Status;
    }
}