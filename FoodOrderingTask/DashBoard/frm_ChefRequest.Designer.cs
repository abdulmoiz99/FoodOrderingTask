namespace FoodOrderingTask.DashBoard
{
    partial class frm_ChefRequest
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
            this.txt_Why = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SubmitRequest = new System.Windows.Forms.Button();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Why
            // 
            this.txt_Why.BackColor = System.Drawing.Color.White;
            this.txt_Why.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Why.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Why.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.txt_Why.Location = new System.Drawing.Point(313, 137);
            this.txt_Why.Multiline = true;
            this.txt_Why.Name = "txt_Why";
            this.txt_Why.Size = new System.Drawing.Size(309, 266);
            this.txt_Why.TabIndex = 1040;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.label2.Location = new System.Drawing.Point(26, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 56);
            this.label2.TabIndex = 1039;
            this.label2.Text = "Why Are You Applying \r\nFor This Job ?";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(73)))), ((int)(((byte)(93)))));
            this.panel8.Controls.Add(this.label5);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(823, 82);
            this.panel8.TabIndex = 1042;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(369, 56);
            this.label5.TabIndex = 1022;
            this.label5.Text = "Apply For Chef";
            // 
            // btn_SubmitRequest
            // 
            this.btn_SubmitRequest.BackColor = System.Drawing.Color.DimGray;
            this.btn_SubmitRequest.FlatAppearance.BorderSize = 0;
            this.btn_SubmitRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SubmitRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SubmitRequest.ForeColor = System.Drawing.Color.White;
            this.btn_SubmitRequest.Location = new System.Drawing.Point(313, 409);
            this.btn_SubmitRequest.Name = "btn_SubmitRequest";
            this.btn_SubmitRequest.Size = new System.Drawing.Size(309, 55);
            this.btn_SubmitRequest.TabIndex = 1043;
            this.btn_SubmitRequest.Text = "SUBMIT REQUEST";
            this.btn_SubmitRequest.UseVisualStyleBackColor = false;
            this.btn_SubmitRequest.Click += new System.EventHandler(this.btn_SubmitRequest_Click);
            // 
            // frm_ChefRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 480);
            this.Controls.Add(this.btn_SubmitRequest);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.txt_Why);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_ChefRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_ChefRequest";
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Why;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SubmitRequest;
    }
}