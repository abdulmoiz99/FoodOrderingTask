namespace FoodOrderingTask.DashBoard
{
    partial class frm_Payments
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_FoodList = new System.Windows.Forms.DataGridView();
            this.M_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.M_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lab_SubTotal = new System.Windows.Forms.Label();
            this.rb_Cash = new System.Windows.Forms.RadioButton();
            this.rb_CARD = new System.Windows.Forms.RadioButton();
            this.txt_Address = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnl_CardDetails = new System.Windows.Forms.Panel();
            this.txt_CardNo = new System.Windows.Forms.TextBox();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(836, 82);
            this.panel8.TabIndex = 1028;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 56);
            this.label5.TabIndex = 1022;
            this.label5.Text = "Payments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.label1.Location = new System.Drawing.Point(12, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 56);
            this.label1.TabIndex = 1022;
            this.label1.Text = "Your Cart ";
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
            this.dgv_FoodList.Location = new System.Drawing.Point(22, 153);
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
            this.dgv_FoodList.Size = new System.Drawing.Size(704, 270);
            this.dgv_FoodList.TabIndex = 1029;
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
            this.label2.Location = new System.Drawing.Point(29, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 36);
            this.label2.TabIndex = 1030;
            this.label2.Text = "TOTAL AMOUNT : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label3.Location = new System.Drawing.Point(29, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 36);
            this.label3.TabIndex = 1030;
            this.label3.Text = "Payment Mode :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label4.Location = new System.Drawing.Point(131, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 36);
            this.label4.TabIndex = 1030;
            this.label4.Text = "Address :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(22, 604);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(705, 55);
            this.button2.TabIndex = 1031;
            this.button2.Text = "CONFIRM PAYMENT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lab_SubTotal
            // 
            this.lab_SubTotal.AutoSize = true;
            this.lab_SubTotal.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_SubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.lab_SubTotal.Location = new System.Drawing.Point(281, 435);
            this.lab_SubTotal.Name = "lab_SubTotal";
            this.lab_SubTotal.Size = new System.Drawing.Size(172, 36);
            this.lab_SubTotal.TabIndex = 1030;
            this.lab_SubTotal.Text = "SUB TOTAL :";
            // 
            // rb_Cash
            // 
            this.rb_Cash.AutoSize = true;
            this.rb_Cash.Checked = true;
            this.rb_Cash.FlatAppearance.CheckedBackColor = System.Drawing.Color.Gray;
            this.rb_Cash.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.rb_Cash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.rb_Cash.Location = new System.Drawing.Point(287, 482);
            this.rb_Cash.Name = "rb_Cash";
            this.rb_Cash.Size = new System.Drawing.Size(112, 40);
            this.rb_Cash.TabIndex = 1032;
            this.rb_Cash.TabStop = true;
            this.rb_Cash.Text = "CASH";
            this.rb_Cash.UseVisualStyleBackColor = true;
            this.rb_Cash.CheckedChanged += new System.EventHandler(this.rb_Cash_CheckedChanged);
            // 
            // rb_CARD
            // 
            this.rb_CARD.AutoSize = true;
            this.rb_CARD.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.rb_CARD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.rb_CARD.Location = new System.Drawing.Point(405, 482);
            this.rb_CARD.Name = "rb_CARD";
            this.rb_CARD.Size = new System.Drawing.Size(114, 40);
            this.rb_CARD.TabIndex = 1032;
            this.rb_CARD.Text = "CARD";
            this.rb_CARD.UseVisualStyleBackColor = true;
            // 
            // txt_Address
            // 
            this.txt_Address.BackColor = System.Drawing.Color.White;
            this.txt_Address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Address.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.txt_Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_Address.Location = new System.Drawing.Point(287, 531);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.Size = new System.Drawing.Size(439, 36);
            this.txt_Address.TabIndex = 1033;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(287, 578);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 4);
            this.panel1.TabIndex = 1034;
            // 
            // pnl_CardDetails
            // 
            this.pnl_CardDetails.BackColor = System.Drawing.Color.DimGray;
            this.pnl_CardDetails.Location = new System.Drawing.Point(525, 529);
            this.pnl_CardDetails.Name = "pnl_CardDetails";
            this.pnl_CardDetails.Size = new System.Drawing.Size(202, 4);
            this.pnl_CardDetails.TabIndex = 1036;
            this.pnl_CardDetails.Visible = false;
            // 
            // txt_CardNo
            // 
            this.txt_CardNo.BackColor = System.Drawing.Color.White;
            this.txt_CardNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_CardNo.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold);
            this.txt_CardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_CardNo.Location = new System.Drawing.Point(525, 482);
            this.txt_CardNo.Name = "txt_CardNo";
            this.txt_CardNo.Size = new System.Drawing.Size(201, 36);
            this.txt_CardNo.TabIndex = 1035;
            this.txt_CardNo.Visible = false;
            // 
            // frm_Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(836, 682);
            this.Controls.Add(this.pnl_CardDetails);
            this.Controls.Add(this.txt_CardNo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_Address);
            this.Controls.Add(this.rb_CARD);
            this.Controls.Add(this.rb_Cash);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lab_SubTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgv_FoodList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Payments";
            this.Load += new System.EventHandler(this.frm_Payments_Load);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_FoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_FoodList;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn M_Type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lab_SubTotal;
        private System.Windows.Forms.RadioButton rb_Cash;
        private System.Windows.Forms.RadioButton rb_CARD;
        private System.Windows.Forms.TextBox txt_Address;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnl_CardDetails;
        private System.Windows.Forms.TextBox txt_CardNo;
    }
}