namespace AdaStkMgmt.Process.wPC
{
    partial class wUsrAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wUsrAdd));
            this.otbSurNme = new System.Windows.Forms.TextBox();
            this.olaSurNme = new System.Windows.Forms.Label();
            this.otbNme = new System.Windows.Forms.TextBox();
            this.olaNme = new System.Windows.Forms.Label();
            this.olaHead = new System.Windows.Forms.Label();
            this.ocmCcl = new System.Windows.Forms.Button();
            this.ocmAdd = new System.Windows.Forms.Button();
            this.ocbAut = new System.Windows.Forms.ComboBox();
            this.olaAut = new System.Windows.Forms.Label();
            this.otbPwd = new System.Windows.Forms.TextBox();
            this.olaPwd = new System.Windows.Forms.Label();
            this.otbUsrNme = new System.Windows.Forms.TextBox();
            this.olaUsrUsrName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // otbSurNme
            // 
            this.otbSurNme.Location = new System.Drawing.Point(25, 166);
            this.otbSurNme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otbSurNme.Name = "otbSurNme";
            this.otbSurNme.Size = new System.Drawing.Size(365, 22);
            this.otbSurNme.TabIndex = 15;
            // 
            // olaSurNme
            // 
            this.olaSurNme.AutoSize = true;
            this.olaSurNme.Location = new System.Drawing.Point(23, 137);
            this.olaSurNme.Name = "olaSurNme";
            this.olaSurNme.Size = new System.Drawing.Size(61, 16);
            this.olaSurNme.TabIndex = 14;
            this.olaSurNme.Text = "Surname";
            // 
            // otbNme
            // 
            this.otbNme.Location = new System.Drawing.Point(25, 101);
            this.otbNme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otbNme.Name = "otbNme";
            this.otbNme.Size = new System.Drawing.Size(365, 22);
            this.otbNme.TabIndex = 13;
            // 
            // olaNme
            // 
            this.olaNme.AutoSize = true;
            this.olaNme.Location = new System.Drawing.Point(23, 70);
            this.olaNme.Name = "olaNme";
            this.olaNme.Size = new System.Drawing.Size(44, 16);
            this.olaNme.TabIndex = 12;
            this.olaNme.Text = "Name";
            // 
            // olaHead
            // 
            this.olaHead.AutoSize = true;
            this.olaHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.olaHead.Location = new System.Drawing.Point(23, 22);
            this.olaHead.Name = "olaHead";
            this.olaHead.Size = new System.Drawing.Size(147, 32);
            this.olaHead.TabIndex = 23;
            this.olaHead.Text = "ADD User";
            // 
            // ocmCcl
            // 
            this.ocmCcl.Location = new System.Drawing.Point(304, 425);
            this.ocmCcl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ocmCcl.Name = "ocmCcl";
            this.ocmCcl.Size = new System.Drawing.Size(87, 37);
            this.ocmCcl.TabIndex = 22;
            this.ocmCcl.Text = "Cancel";
            this.ocmCcl.UseVisualStyleBackColor = true;
            this.ocmCcl.Click += new System.EventHandler(this.ocmCcl_Click);
            // 
            // ocmAdd
            // 
            this.ocmAdd.Location = new System.Drawing.Point(213, 425);
            this.ocmAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ocmAdd.Name = "ocmAdd";
            this.ocmAdd.Size = new System.Drawing.Size(87, 37);
            this.ocmAdd.TabIndex = 21;
            this.ocmAdd.Text = "Add";
            this.ocmAdd.UseVisualStyleBackColor = true;
            this.ocmAdd.Click += new System.EventHandler(this.ocmAdd_Click);
            // 
            // ocbAut
            // 
            this.ocbAut.FormattingEnabled = true;
            this.ocbAut.Location = new System.Drawing.Point(23, 370);
            this.ocbAut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ocbAut.Name = "ocbAut";
            this.ocbAut.Size = new System.Drawing.Size(365, 24);
            this.ocbAut.TabIndex = 20;
            // 
            // olaAut
            // 
            this.olaAut.AutoSize = true;
            this.olaAut.Location = new System.Drawing.Point(21, 347);
            this.olaAut.Name = "olaAut";
            this.olaAut.Size = new System.Drawing.Size(58, 16);
            this.olaAut.TabIndex = 19;
            this.olaAut.Text = "Auholize";
            // 
            // otbPwd
            // 
            this.otbPwd.Location = new System.Drawing.Point(25, 302);
            this.otbPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otbPwd.Name = "otbPwd";
            this.otbPwd.Size = new System.Drawing.Size(365, 22);
            this.otbPwd.TabIndex = 27;
            this.otbPwd.UseSystemPasswordChar = true;
            // 
            // olaPwd
            // 
            this.olaPwd.AutoSize = true;
            this.olaPwd.Location = new System.Drawing.Point(23, 272);
            this.olaPwd.Name = "olaPwd";
            this.olaPwd.Size = new System.Drawing.Size(67, 16);
            this.olaPwd.TabIndex = 26;
            this.olaPwd.Text = "Password";
            // 
            // otbUsrNme
            // 
            this.otbUsrNme.Location = new System.Drawing.Point(25, 236);
            this.otbUsrNme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.otbUsrNme.Name = "otbUsrNme";
            this.otbUsrNme.Size = new System.Drawing.Size(365, 22);
            this.otbUsrNme.TabIndex = 25;
            // 
            // olaUsrUsrName
            // 
            this.olaUsrUsrName.AutoSize = true;
            this.olaUsrUsrName.Location = new System.Drawing.Point(23, 206);
            this.olaUsrUsrName.Name = "olaUsrUsrName";
            this.olaUsrUsrName.Size = new System.Drawing.Size(70, 16);
            this.olaUsrUsrName.TabIndex = 24;
            this.olaUsrUsrName.Text = "Username";
            // 
            // wUsrAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 474);
            this.Controls.Add(this.otbPwd);
            this.Controls.Add(this.olaPwd);
            this.Controls.Add(this.otbUsrNme);
            this.Controls.Add(this.olaUsrUsrName);
            this.Controls.Add(this.otbSurNme);
            this.Controls.Add(this.olaSurNme);
            this.Controls.Add(this.otbNme);
            this.Controls.Add(this.olaNme);
            this.Controls.Add(this.olaHead);
            this.Controls.Add(this.ocmCcl);
            this.Controls.Add(this.ocmAdd);
            this.Controls.Add(this.ocbAut);
            this.Controls.Add(this.olaAut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "wUsrAdd";
            this.Text = "Ada Stock Management";
            this.Load += new System.EventHandler(this.wUsrAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox otbSurNme;
        private System.Windows.Forms.Label olaSurNme;
        private System.Windows.Forms.TextBox otbNme;
        private System.Windows.Forms.Label olaNme;
        private System.Windows.Forms.Label olaHead;
        private System.Windows.Forms.Button ocmCcl;
        private System.Windows.Forms.Button ocmAdd;
        private System.Windows.Forms.ComboBox ocbAut;
        private System.Windows.Forms.Label olaAut;
        private System.Windows.Forms.TextBox otbPwd;
        private System.Windows.Forms.Label olaPwd;
        private System.Windows.Forms.TextBox otbUsrNme;
        private System.Windows.Forms.Label olaUsrUsrName;
    }
}