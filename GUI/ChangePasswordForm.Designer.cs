namespace GUI
{
    partial class ChangePasswordForm
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPW = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtConfirmPW = new System.Windows.Forms.TextBox();
            this.txtNewPW = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.labelFW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUserName.Location = new System.Drawing.Point(398, 123);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(112, 28);
            this.labelUserName.TabIndex = 2;
            this.labelUserName.Text = "User Name:";
            // 
            // labelPW
            // 
            this.labelPW.AutoSize = true;
            this.labelPW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelPW.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelPW.Location = new System.Drawing.Point(398, 180);
            this.labelPW.Name = "labelPW";
            this.labelPW.Size = new System.Drawing.Size(97, 28);
            this.labelPW.TabIndex = 3;
            this.labelPW.Text = "Password:";
            this.labelPW.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(398, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "New password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(398, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Confirm PW:";
            // 
            // txtConfirmPW
            // 
            this.txtConfirmPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPW.Location = new System.Drawing.Point(547, 293);
            this.txtConfirmPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPW.Name = "txtConfirmPW";
            this.txtConfirmPW.PasswordChar = '*';
            this.txtConfirmPW.Size = new System.Drawing.Size(199, 30);
            this.txtConfirmPW.TabIndex = 6;
            // 
            // txtNewPW
            // 
            this.txtNewPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPW.Location = new System.Drawing.Point(547, 237);
            this.txtNewPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNewPW.Name = "txtNewPW";
            this.txtNewPW.PasswordChar = '*';
            this.txtNewPW.Size = new System.Drawing.Size(199, 30);
            this.txtNewPW.TabIndex = 7;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPW.Location = new System.Drawing.Point(547, 180);
            this.txtPW.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPW.Name = "txtPW";
            this.txtPW.PasswordChar = '*';
            this.txtPW.Size = new System.Drawing.Size(199, 30);
            this.txtPW.TabIndex = 8;
            this.txtPW.Visible = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(547, 123);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(199, 30);
            this.txtUserName.TabIndex = 9;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(582, 340);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 40);
            this.btnConfirm.TabIndex = 111;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::GUI.Properties.Resources.logout_logo;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(767, 25);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 112;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelFW
            // 
            this.labelFW.AutoSize = true;
            this.labelFW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelFW.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFW.ForeColor = System.Drawing.Color.Black;
            this.labelFW.Location = new System.Drawing.Point(424, 27);
            this.labelFW.Name = "labelFW";
            this.labelFW.Size = new System.Drawing.Size(299, 38);
            this.labelFW.TabIndex = 113;
            this.labelFW.Text = "Change Password";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.labelFW);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtNewPW);
            this.Controls.Add(this.txtConfirmPW);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPW);
            this.Controls.Add(this.labelUserName);
            this.Name = "ChangePasswordForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtConfirmPW;
        private System.Windows.Forms.TextBox txtNewPW;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Label labelFW;
    }
}