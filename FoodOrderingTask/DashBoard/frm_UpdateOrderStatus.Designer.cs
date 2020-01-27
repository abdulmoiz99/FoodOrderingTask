namespace FoodOrderingTask.DashBoard
{
    partial class frm_UpdateOrderStatus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_ChefRequest = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.txt_DataGridViewIndex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_OrderStatus = new System.Windows.Forms.TextBox();
            this.dgv_OrderDetails = new System.Windows.Forms.DataGridView();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.L_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_USerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_UpdateRequest = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChefRequest)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ChefRequest
            // 
            this.dgv_ChefRequest.AllowUserToAddRows = false;
            this.dgv_ChefRequest.AllowUserToDeleteRows = false;
            this.dgv_ChefRequest.AllowUserToOrderColumns = true;
            this.dgv_ChefRequest.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChefRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChefRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_ChefRequest.ColumnHeadersHeight = 50;
            this.dgv_ChefRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.L_Username,
            this.C_USerID,
            this.C_Status});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChefRequest.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_ChefRequest.Location = new System.Drawing.Point(12, 107);
            this.dgv_ChefRequest.Name = "dgv_ChefRequest";
            this.dgv_ChefRequest.ReadOnly = true;
            this.dgv_ChefRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChefRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dgv_ChefRequest.RowHeadersWidth = 10;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            this.dgv_ChefRequest.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgv_ChefRequest.RowTemplate.Height = 50;
            this.dgv_ChefRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChefRequest.Size = new System.Drawing.Size(320, 518);
            this.dgv_ChefRequest.TabIndex = 1047;
            this.dgv_ChefRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChefRequest_CellContentClick);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(738, 82);
            this.panel8.TabIndex = 1055;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(342, 56);
            this.label5.TabIndex = 1022;
            this.label5.Text = "Update Order";
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_Username.Location = new System.Drawing.Point(347, 148);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(306, 33);
            this.txt_Username.TabIndex = 1054;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(341, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 36);
            this.label4.TabIndex = 1049;
            this.label4.Text = "Username :";
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.Color.White;
            this.txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_UserID.Location = new System.Drawing.Point(659, 229);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(27, 33);
            this.txt_UserID.TabIndex = 1056;
            this.txt_UserID.Visible = false;
            // 
            // txt_DataGridViewIndex
            // 
            this.txt_DataGridViewIndex.BackColor = System.Drawing.Color.White;
            this.txt_DataGridViewIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataGridViewIndex.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataGridViewIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_DataGridViewIndex.Location = new System.Drawing.Point(659, 148);
            this.txt_DataGridViewIndex.Name = "txt_DataGridViewIndex";
            this.txt_DataGridViewIndex.Size = new System.Drawing.Size(27, 33);
            this.txt_DataGridViewIndex.TabIndex = 1057;
            this.txt_DataGridViewIndex.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(341, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 36);
            this.label1.TabIndex = 1049;
            this.label1.Text = "Status :";
            // 
            // txt_OrderStatus
            // 
            this.txt_OrderStatus.BackColor = System.Drawing.Color.White;
            this.txt_OrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_OrderStatus.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_OrderStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_OrderStatus.Location = new System.Drawing.Point(347, 229);
            this.txt_OrderStatus.Name = "txt_OrderStatus";
            this.txt_OrderStatus.Size = new System.Drawing.Size(306, 33);
            this.txt_OrderStatus.TabIndex = 1054;
            // 
            // dgv_OrderDetails
            // 
            this.dgv_OrderDetails.AllowUserToAddRows = false;
            this.dgv_OrderDetails.AllowUserToDeleteRows = false;
            this.dgv_OrderDetails.AllowUserToOrderColumns = true;
            this.dgv_OrderDetails.BackgroundColor = System.Drawing.Color.White;
            this.dgv_OrderDetails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_OrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dgv_OrderDetails.ColumnHeadersHeight = 50;
            this.dgv_OrderDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_Name});
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle22.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle22.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle22.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_OrderDetails.DefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_OrderDetails.Location = new System.Drawing.Point(347, 268);
            this.dgv_OrderDetails.Name = "dgv_OrderDetails";
            this.dgv_OrderDetails.ReadOnly = true;
            this.dgv_OrderDetails.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_OrderDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_OrderDetails.RowHeadersWidth = 10;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            this.dgv_OrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_OrderDetails.RowTemplate.Height = 50;
            this.dgv_OrderDetails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_OrderDetails.Size = new System.Drawing.Size(306, 204);
            this.dgv_OrderDetails.TabIndex = 1058;
            // 
            // cmb_Status
            // 
            this.cmb_Status.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "READY",
            "PACKED ",
            "DELIVER",
            "CANCELLED"});
            this.cmb_Status.Location = new System.Drawing.Point(347, 514);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(306, 32);
            this.cmb_Status.TabIndex = 1059;
            // 
            // L_Username
            // 
            this.L_Username.DataPropertyName = "L_Username";
            this.L_Username.HeaderText = "Username";
            this.L_Username.Name = "L_Username";
            this.L_Username.ReadOnly = true;
            this.L_Username.Width = 300;
            // 
            // C_USerID
            // 
            this.C_USerID.DataPropertyName = "C_USerID";
            this.C_USerID.HeaderText = "C_USerID";
            this.C_USerID.Name = "C_USerID";
            this.C_USerID.ReadOnly = true;
            this.C_USerID.Visible = false;
            // 
            // C_Status
            // 
            this.C_Status.DataPropertyName = "C_Status";
            this.C_Status.HeaderText = "C_Status";
            this.C_Status.Name = "C_Status";
            this.C_Status.ReadOnly = true;
            this.C_Status.Visible = false;
            // 
            // C_Name
            // 
            this.C_Name.DataPropertyName = "C_Name";
            this.C_Name.HeaderText = "Order";
            this.C_Name.Name = "C_Name";
            this.C_Name.ReadOnly = true;
            this.C_Name.Width = 270;
            // 
            // btn_UpdateRequest
            // 
            this.btn_UpdateRequest.BackColor = System.Drawing.Color.DimGray;
            this.btn_UpdateRequest.FlatAppearance.BorderSize = 0;
            this.btn_UpdateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRequest.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateRequest.Location = new System.Drawing.Point(348, 561);
            this.btn_UpdateRequest.Name = "btn_UpdateRequest";
            this.btn_UpdateRequest.Size = new System.Drawing.Size(305, 55);
            this.btn_UpdateRequest.TabIndex = 1060;
            this.btn_UpdateRequest.Text = "UPDATE";
            this.btn_UpdateRequest.UseVisualStyleBackColor = false;
            this.btn_UpdateRequest.Click += new System.EventHandler(this.btn_UpdateRequest_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(342, 475);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 36);
            this.label2.TabIndex = 1061;
            this.label2.Text = "Update Status :";
            // 
            // frm_UpdateOrderStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 637);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_UpdateRequest);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.dgv_OrderDetails);
            this.Controls.Add(this.dgv_ChefRequest);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txt_OrderStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.txt_DataGridViewIndex);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_UpdateOrderStatus";
            this.Text = "frm_UpdateOrderStatus";
            this.Activated += new System.EventHandler(this.frm_UpdateOrderStatus_Activated);
            this.Load += new System.EventHandler(this.frm_UpdateOrderStatus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChefRequest)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_OrderDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChefRequest;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.TextBox txt_DataGridViewIndex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_OrderStatus;
        private System.Windows.Forms.DataGridView dgv_OrderDetails;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn L_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_USerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Name;
        private System.Windows.Forms.Button btn_UpdateRequest;
        private System.Windows.Forms.Label label2;
    }
}