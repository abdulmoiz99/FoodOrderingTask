namespace FoodOrderingTask.DashBoard
{
    partial class ChefRequestUpdater
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
            this.CR_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR_UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR_Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CR_Application = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_Application = new System.Windows.Forms.TextBox();
            this.rb_Approved = new System.Windows.Forms.RadioButton();
            this.rb_Reject = new System.Windows.Forms.RadioButton();
            this.btn_UpdateRequest = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.Label();
            this.txt_DataGridViewIndex = new System.Windows.Forms.TextBox();
            this.txt_UserID = new System.Windows.Forms.TextBox();
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
            this.CR_ID,
            this.CR_UserID,
            this.CR_Username,
            this.CR_Application});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_ChefRequest.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_ChefRequest.Location = new System.Drawing.Point(12, 88);
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
            this.dgv_ChefRequest.Size = new System.Drawing.Size(263, 500);
            this.dgv_ChefRequest.TabIndex = 1030;
            this.dgv_ChefRequest.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ChefRequest_CellContentClick);
            // 
            // CR_ID
            // 
            this.CR_ID.DataPropertyName = "CR_ID";
            this.CR_ID.HeaderText = "CR_ID";
            this.CR_ID.Name = "CR_ID";
            this.CR_ID.ReadOnly = true;
            this.CR_ID.Visible = false;
            // 
            // CR_UserID
            // 
            this.CR_UserID.DataPropertyName = "CR_UserID";
            this.CR_UserID.HeaderText = "CR_UserID";
            this.CR_UserID.Name = "CR_UserID";
            this.CR_UserID.ReadOnly = true;
            this.CR_UserID.Visible = false;
            // 
            // CR_Username
            // 
            this.CR_Username.DataPropertyName = "CR_Username";
            this.CR_Username.HeaderText = "Usernames";
            this.CR_Username.Name = "CR_Username";
            this.CR_Username.ReadOnly = true;
            this.CR_Username.Width = 250;
            // 
            // CR_Application
            // 
            this.CR_Application.DataPropertyName = "CR_Application";
            this.CR_Application.HeaderText = "CR_Application";
            this.CR_Application.Name = "CR_Application";
            this.CR_Application.ReadOnly = true;
            this.CR_Application.Visible = false;
            // 
            // txt_Application
            // 
            this.txt_Application.BackColor = System.Drawing.Color.White;
            this.txt_Application.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Application.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Application.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_Application.Location = new System.Drawing.Point(303, 230);
            this.txt_Application.Multiline = true;
            this.txt_Application.Name = "txt_Application";
            this.txt_Application.Size = new System.Drawing.Size(309, 276);
            this.txt_Application.TabIndex = 1041;
            // 
            // rb_Approved
            // 
            this.rb_Approved.AutoSize = true;
            this.rb_Approved.Checked = true;
            this.rb_Approved.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Approved.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.rb_Approved.Location = new System.Drawing.Point(303, 512);
            this.rb_Approved.Name = "rb_Approved";
            this.rb_Approved.Size = new System.Drawing.Size(133, 29);
            this.rb_Approved.TabIndex = 1042;
            this.rb_Approved.TabStop = true;
            this.rb_Approved.Text = "Approved";
            this.rb_Approved.UseVisualStyleBackColor = true;
            // 
            // rb_Reject
            // 
            this.rb_Reject.AutoSize = true;
            this.rb_Reject.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Reject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.rb_Reject.Location = new System.Drawing.Point(454, 512);
            this.rb_Reject.Name = "rb_Reject";
            this.rb_Reject.Size = new System.Drawing.Size(92, 29);
            this.rb_Reject.TabIndex = 1042;
            this.rb_Reject.Text = "Reject";
            this.rb_Reject.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateRequest
            // 
            this.btn_UpdateRequest.BackColor = System.Drawing.Color.DimGray;
            this.btn_UpdateRequest.FlatAppearance.BorderSize = 0;
            this.btn_UpdateRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateRequest.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateRequest.Location = new System.Drawing.Point(303, 547);
            this.btn_UpdateRequest.Name = "btn_UpdateRequest";
            this.btn_UpdateRequest.Size = new System.Drawing.Size(309, 40);
            this.btn_UpdateRequest.TabIndex = 1044;
            this.btn_UpdateRequest.Text = "UPDATE STATUS";
            this.btn_UpdateRequest.UseVisualStyleBackColor = false;
            this.btn_UpdateRequest.Click += new System.EventHandler(this.btn_UpdateRequest_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(744, 82);
            this.panel8.TabIndex = 1046;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(354, 56);
            this.label5.TabIndex = 1022;
            this.label5.Text = "Chef Requests";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(298, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 1045;
            this.label2.Text = "Application";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.BackColor = System.Drawing.Color.White;
            this.txt_Username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Username.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_Username.Location = new System.Drawing.Point(303, 147);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(309, 37);
            this.txt_Username.TabIndex = 1047;
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.Username.Location = new System.Drawing.Point(298, 107);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(129, 28);
            this.Username.TabIndex = 1045;
            this.Username.Text = "Username";
            this.Username.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Username.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_DataGridViewIndex
            // 
            this.txt_DataGridViewIndex.BackColor = System.Drawing.Color.White;
            this.txt_DataGridViewIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_DataGridViewIndex.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DataGridViewIndex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_DataGridViewIndex.Location = new System.Drawing.Point(678, 98);
            this.txt_DataGridViewIndex.Name = "txt_DataGridViewIndex";
            this.txt_DataGridViewIndex.Size = new System.Drawing.Size(40, 37);
            this.txt_DataGridViewIndex.TabIndex = 1048;
            this.txt_DataGridViewIndex.Visible = false;
            // 
            // txt_UserID
            // 
            this.txt_UserID.BackColor = System.Drawing.Color.White;
            this.txt_UserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UserID.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_UserID.Location = new System.Drawing.Point(678, 147);
            this.txt_UserID.Name = "txt_UserID";
            this.txt_UserID.Size = new System.Drawing.Size(40, 37);
            this.txt_UserID.TabIndex = 1048;
            this.txt_UserID.Visible = false;
            // 
            // ChefRequestUpdater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 600);
            this.Controls.Add(this.txt_UserID);
            this.Controls.Add(this.txt_DataGridViewIndex);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_UpdateRequest);
            this.Controls.Add(this.rb_Reject);
            this.Controls.Add(this.rb_Approved);
            this.Controls.Add(this.txt_Application);
            this.Controls.Add(this.dgv_ChefRequest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChefRequestUpdater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChefRequestUpdater";
            this.Activated += new System.EventHandler(this.ChefRequestUpdater_Activated);
            this.Load += new System.EventHandler(this.ChefRequestUpdater_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChefRequest)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ChefRequest;
        private System.Windows.Forms.TextBox txt_Application;
        private System.Windows.Forms.RadioButton rb_Approved;
        private System.Windows.Forms.RadioButton rb_Reject;
        private System.Windows.Forms.Button btn_UpdateRequest;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn CR_Application;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.TextBox txt_DataGridViewIndex;
        private System.Windows.Forms.TextBox txt_UserID;
    }
}