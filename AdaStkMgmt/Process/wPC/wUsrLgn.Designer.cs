namespace AdaStkMgmt
{
    partial class wUsrLgn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wUsrLgn));
            this.olaHead = new System.Windows.Forms.Label();
            this.olaUsrnme = new System.Windows.Forms.Label();
            this.otbUsrnme = new System.Windows.Forms.TextBox();
            this.otbPwd = new System.Windows.Forms.TextBox();
            this.olaPwd = new System.Windows.Forms.Label();
            this.ocmLogin = new System.Windows.Forms.Button();
            this.ocmCancel = new System.Windows.Forms.Button();
            this.ocmStCon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // olaHead
            // 
            this.olaHead.AutoSize = true;
            this.olaHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaHead.Location = new System.Drawing.Point(40, 18);
            this.olaHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaHead.Name = "olaHead";
            this.olaHead.Size = new System.Drawing.Size(267, 29);
            this.olaHead.TabIndex = 0;
            this.olaHead.Text = "Ada Stock Management";
            // 
            // olaUsrnme
            // 
            this.olaUsrnme.AutoSize = true;
            this.olaUsrnme.Location = new System.Drawing.Point(41, 80);
            this.olaUsrnme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaUsrnme.Name = "olaUsrnme";
            this.olaUsrnme.Size = new System.Drawing.Size(70, 16);
            this.olaUsrnme.TabIndex = 1;
            this.olaUsrnme.Text = "Username";
            // 
            // otbUsrnme
            // 
            this.otbUsrnme.Location = new System.Drawing.Point(129, 76);
            this.otbUsrnme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otbUsrnme.Name = "otbUsrnme";
            this.otbUsrnme.Size = new System.Drawing.Size(207, 22);
            this.otbUsrnme.TabIndex = 2;
            // 
            // otbPwd
            // 
            this.otbPwd.Location = new System.Drawing.Point(129, 119);
            this.otbPwd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.otbPwd.Name = "otbPwd";
            this.otbPwd.Size = new System.Drawing.Size(207, 22);
            this.otbPwd.TabIndex = 4;
            this.otbPwd.UseSystemPasswordChar = true;
            // 
            // olaPwd
            // 
            this.olaPwd.AutoSize = true;
            this.olaPwd.Location = new System.Drawing.Point(41, 123);
            this.olaPwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaPwd.Name = "olaPwd";
            this.olaPwd.Size = new System.Drawing.Size(67, 16);
            this.olaPwd.TabIndex = 3;
            this.olaPwd.Text = "Password";
            // 
            // ocmLogin
            // 
            this.ocmLogin.Location = new System.Drawing.Point(129, 164);
            this.ocmLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ocmLogin.Name = "ocmLogin";
            this.ocmLogin.Size = new System.Drawing.Size(100, 28);
            this.ocmLogin.TabIndex = 5;
            this.ocmLogin.Text = "Login";
            this.ocmLogin.UseVisualStyleBackColor = true;
            this.ocmLogin.Click += new System.EventHandler(this.ocmLogin_Click);
            // 
            // ocmCancel
            // 
            this.ocmCancel.Location = new System.Drawing.Point(237, 164);
            this.ocmCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ocmCancel.Name = "ocmCancel";
            this.ocmCancel.Size = new System.Drawing.Size(100, 28);
            this.ocmCancel.TabIndex = 6;
            this.ocmCancel.Text = "Cancel";
            this.ocmCancel.UseVisualStyleBackColor = true;
            this.ocmCancel.Click += new System.EventHandler(this.ocmCancel_Click);
            // 
            // ocmStCon
            // 
            this.ocmStCon.Location = new System.Drawing.Point(322, 24);
            this.ocmStCon.Name = "ocmStCon";
            this.ocmStCon.Size = new System.Drawing.Size(46, 23);
            this.ocmStCon.TabIndex = 7;
            this.ocmStCon.UseVisualStyleBackColor = true;
            // 
            // wUsrLgn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 246);
            this.Controls.Add(this.ocmStCon);
            this.Controls.Add(this.ocmCancel);
            this.Controls.Add(this.ocmLogin);
            this.Controls.Add(this.otbPwd);
            this.Controls.Add(this.olaPwd);
            this.Controls.Add(this.otbUsrnme);
            this.Controls.Add(this.olaUsrnme);
            this.Controls.Add(this.olaHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "wUsrLgn";
            this.Text = "Ada Stock Management";
            this.Load += new System.EventHandler(this.oUsrLgn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label olaHead;
        private System.Windows.Forms.Label olaUsrnme;
        private System.Windows.Forms.TextBox otbUsrnme;
        private System.Windows.Forms.TextBox otbPwd;
        private System.Windows.Forms.Label olaPwd;
        private System.Windows.Forms.Button ocmLogin;
        private System.Windows.Forms.Button ocmCancel;
        private System.Windows.Forms.Button ocmStCon;
    }
}

