namespace GUI
{
    partial class ForgotPwrdForm
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
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnGetOTP = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnCheckUserName = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnLogout = new System.Windows.Forms.PictureBox();
            this.labelMess = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.labelOTP = new System.Windows.Forms.Label();
            this.labelFW = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelUserName.Location = new System.Drawing.Point(410, 93);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(112, 28);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "User Name:";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(551, 93);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(199, 30);
            this.txtUserName.TabIndex = 3;
            // 
            // btnGetOTP
            // 
            this.btnGetOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnGetOTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetOTP.Location = new System.Drawing.Point(656, 292);
            this.btnGetOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGetOTP.Name = "btnGetOTP";
            this.btnGetOTP.Size = new System.Drawing.Size(94, 30);
            this.btnGetOTP.TabIndex = 7;
            this.btnGetOTP.Text = "Get OTP";
            this.btnGetOTP.UseVisualStyleBackColor = false;
            this.btnGetOTP.Visible = false;
            this.btnGetOTP.Click += new System.EventHandler(this.btnGetOTP_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelEmail.Location = new System.Drawing.Point(410, 234);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(63, 28);
            this.labelEmail.TabIndex = 8;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Visible = false;
            // 
            // btnCheckUserName
            // 
            this.btnCheckUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnCheckUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckUserName.Location = new System.Drawing.Point(512, 142);
            this.btnCheckUserName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCheckUserName.Name = "btnCheckUserName";
            this.btnCheckUserName.Size = new System.Drawing.Size(133, 40);
            this.btnCheckUserName.TabIndex = 9;
            this.btnCheckUserName.Text = "Check";
            this.btnCheckUserName.UseVisualStyleBackColor = false;
            this.btnCheckUserName.Click += new System.EventHandler(this.btnCheckUserName_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(551, 234);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(199, 30);
            this.txtEmail.TabIndex = 10;
            this.txtEmail.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::GUI.Properties.Resources.logout_logo;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.Location = new System.Drawing.Point(776, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(40, 40);
            this.btnLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnLogout.TabIndex = 107;
            this.btnLogout.TabStop = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // labelMess
            // 
            this.labelMess.AutoSize = true;
            this.labelMess.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMess.Location = new System.Drawing.Point(412, 195);
            this.labelMess.Name = "labelMess";
            this.labelMess.Size = new System.Drawing.Size(346, 18);
            this.labelMess.TabIndex = 108;
            this.labelMess.Text = "Enter the email associated with your account";
            this.labelMess.Visible = false;
            // 
            // txtOTP
            // 
            this.txtOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(512, 292);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(133, 30);
            this.txtOTP.TabIndex = 109;
            this.txtOTP.Visible = false;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(551, 337);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(94, 40);
            this.btnConfirm.TabIndex = 110;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Visible = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // labelOTP
            // 
            this.labelOTP.AutoSize = true;
            this.labelOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelOTP.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.labelOTP.Location = new System.Drawing.Point(410, 292);
            this.labelOTP.Name = "labelOTP";
            this.labelOTP.Size = new System.Drawing.Size(51, 28);
            this.labelOTP.TabIndex = 111;
            this.labelOTP.Text = "OTP:";
            this.labelOTP.Visible = false;
            // 
            // labelFW
            // 
            this.labelFW.AutoSize = true;
            this.labelFW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.labelFW.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFW.ForeColor = System.Drawing.Color.Black;
            this.labelFW.Location = new System.Drawing.Point(454, 12);
            this.labelFW.Name = "labelFW";
            this.labelFW.Size = new System.Drawing.Size(283, 38);
            this.labelFW.TabIndex = 0;
            this.labelFW.Text = "Forgot Password";
            // 
            // ForgotPwrdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GUI.Properties.Resources.BackgroundImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(845, 450);
            this.Controls.Add(this.labelFW);
            this.Controls.Add(this.labelOTP);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtOTP);
            this.Controls.Add(this.labelMess);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCheckUserName);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.btnGetOTP);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.labelUserName);
            this.Name = "ForgotPwrdForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnLogout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnGetOTP;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Button btnCheckUserName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox btnLogout;
        private System.Windows.Forms.Label labelMess;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Label labelOTP;
        private System.Windows.Forms.Label labelFW;
    }
}