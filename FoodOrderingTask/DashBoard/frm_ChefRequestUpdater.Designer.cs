namespace FoodOrderingTask.DashBoard
{
    partial class frm_ChefRequestUpdater
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
            this.dgv_ChefRequest = new System.Windows.Forms.DataGridView();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.rb_Reject = new System.Windows.Forms.RadioButton();
            this.rb_Approve = new System.Windows.Forms.RadioButton();
            this.btn_UpdateRequest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Application = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_DataGridViewIndex = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
            this.CR_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR_Application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR_UserId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChefRequest)).BeginInit();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ChefRequest
            // 
            this.dgv_ChefRequest.AllowUserToAddRows = false;
            this.dgv_ChefRequest.AllowUserToDeleteRows = false;
            this.dgv_ChefRequest.AllowUserToOrderColumns = true;
            this.dgv_ChefRequest.BackgroundColor = System.Drawing.Color.White;
            this.dgv_ChefRequest.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChefRequest.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_ChefRequest.ColumnHeadersHeight = 50;
            this.dgv_ChefRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CR_Username,
            this.CR_ID,
            this.CR_Application,
            this.CR_UserId});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChefRequest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ChefRequest.Location = new System.Drawing.Point(23, 115);
            this.dgv_ChefRequest.Name = "dgv_ChefRequest";
            this.dgv_ChefRequest.ReadOnly = true;
            this.dgv_ChefRequest.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_ChefRequest.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_ChefRequest.RowHeadersWidth = 10;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgv_ChefRequest.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_ChefRequest.RowTemplate.Height = 50;
            this.dgv_ChefRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ChefRequest.Size = new System.Drawing.Size(320, 427);
            this.dgv_ChefRequest.TabIndex = 1030;
            this.dgv_ChefRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChefRequest_CellContentClick);
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_Username.Location = new System.Drawing.Point(355, 156);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(306, 33);
            this.txt_Username.TabIndex = 1044;
            // 
            // rb_Reject
            // 
            this.rb_Reject.AutoSize = true;
            this.rb_Reject.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.rb_Reject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.rb_Reject.Location = new System.Drawing.Point(537, 431);
            this.rb_Reject.Name = "rb_Reject";
            this.rb_Reject.Size = new System.Drawing.Size(124, 40);
            this.rb_Reject.TabIndex = 1040;
            this.rb_Reject.Text = "Reject";
            this.rb_Reject.UseVisualStyleBackColor = true;
            // 
            // rb_Approve
            // 
            this.rb_Approve.AutoSize = true;
            this.rb_Approve.Checked = true;
            this.rb_Approve.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rb_Approve.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.rb_Approve.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.rb_Approve.Location = new System.Drawing.Point(356, 431);
            this.rb_Approve.Name = "rb_Approve";
            this.rb_Approve.Size = new System.Drawing.Size(155, 40);
            this.rb_Approve.TabIndex = 1041;
            this.rb_Approve.TabStop = true;
            this.rb_Approve.Text = "Approve";
            this.rb_Approve.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateRequest
            // 
            this.btn_UpdateRequest.BackColor = System.Drawing.Color.DimGray;
            this.btn_UpdateRequest.FlatAppearance.BorderSize = 0;
            this.btn_UpdateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRequest.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateRequest.Location = new System.Drawing.Point(356, 487);
            this.btn_UpdateRequest.Name = "btn_UpdateRequest";
            this.btn_UpdateRequest.Size = new System.Drawing.Size(305, 55);
            this.btn_UpdateRequest.TabIndex = 1039;
            this.btn_UpdateRequest.Text = "UPDATE";
            this.btn_UpdateRequest.UseVisualStyleBackColor = false;
            this.btn_UpdateRequest.Click += new System.EventHandler(this.btn_UpdateRequest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(349, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 36);
            this.label4.TabIndex = 1037;
            this.label4.Text = "Username :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label1.Location = new System.Drawing.Point(349, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 36);
            this.label1.TabIndex = 1037;
            this.label1.Text = "Application :";
            // 
            // txt_Application
            // 
            this.txt_Application.BackColor = System.Drawing.Color.White;
            this.txt_Application.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Application.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Application.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_Application.Location = new System.Drawing.Point(355, 235);
            this.txt_Application.Multiline = true;
            this.txt_Application.Name = "txt_Application";
            this.txt_Application.Size = new System.Drawing.Size(306, 190);
            this.txt_Application.TabIndex = 1044;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(797, 82);
            this.panel8.TabIndex = 1045;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(523, 56);
            this.label5.TabIndex = 1022;
            this.label5.Text = "Applications For Chef";
            // 
            // txt_DataGridViewIndex
            // 
            this.txt_DataGridViewIndex.BackColor = System.Drawing.Color.White;
            this.txt_DataGridViewIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataGridViewIndex.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataGridViewIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_DataGridViewIndex.Location = new System.Drawing.Point(701, 156);
            this.txt_DataGridViewIndex.Name = "txt_DataGridViewIndex";
            this.txt_DataGridViewIndex.Size = new System.Drawing.Size(27, 33);
            this.txt_DataGridViewIndex.TabIndex = 1046;
            this.txt_DataGridViewIndex.Visible = false;
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.Color.White;
            this.txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_UserID.Location = new System.Drawing.Point(701, 204);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(27, 33);
            this.txt_UserID.TabIndex = 1046;
            this.txt_UserID.Visible = false;
            // 
            // CR_Username
            // 
            this.CR_Username.DataPropertyName = "CR_Username";
            this.CR_Username.HeaderText = "Username";
            this.CR_Username.Name = "CR_Username";
            this.CR_Username.ReadOnly = true;
            this.CR_Username.Width = 300;
            // 
            // CR_ID
            // 
            this.CR_ID.DataPropertyName = "CR_ID";
            this.CR_ID.HeaderText = "CR_ID";
            this.CR_ID.Name = "CR_ID";
            this.CR_ID.ReadOnly = true;
            this.CR_ID.Visible = false;
            // 
            // CR_Application
            // 
            this.CR_Application.DataPropertyName = "CR_Application";
            this.CR_Application.HeaderText = "CR_Application";
            this.CR_Application.Name = "CR_Application";
            this.CR_Application.ReadOnly = true;
            this.CR_Application.Visible = false;
            // 
            // CR_UserId
            // 
            this.CR_UserId.DataPropertyName = "CR_UserId";
            this.CR_UserId.HeaderText = "CR_UserId";
            this.CR_UserId.Name = "CR_UserId";
            this.CR_UserId.ReadOnly = true;
            this.CR_UserId.Visible = false;
            // 
            // frm_ChefRequestUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 550);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.txt_DataGridViewIndex);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txt_Application);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.rb_Reject);
            this.Controls.Add(this.rb_Approve);
            this.Controls.Add(this.btn_UpdateRequest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_ChefRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChefRequestUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChefRequestUpdater";
            this.Activated += new System.EventHandler(this.frm_ChefRequestUpdater_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChefRequest)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChefRequest;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.RadioButton rb_Reject;
        private System.Windows.Forms.RadioButton rb_Approve;
        private System.Windows.Forms.Button btn_UpdateRequest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Application;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_DataGridViewIndex;
        private System.Windows.Forms.TextBox txt_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_Application;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_UserId;
    }
}