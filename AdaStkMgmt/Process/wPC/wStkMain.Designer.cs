namespace AdaStkMgmt.Process.wPC
{
    partial class wStkMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wStkMain));
            this.otaCtrl = new System.Windows.Forms.TabControl();
            this.otaStk = new System.Windows.Forms.TabPage();
            this.olaScrh = new System.Windows.Forms.Label();
            this.otbScrh = new System.Windows.Forms.TextBox();
            this.olaStkHde = new System.Windows.Forms.Label();
            this.ocmAddStk = new System.Windows.Forms.Button();
            this.ogdStk = new System.Windows.Forms.DataGridView();
            this.otaAdm = new System.Windows.Forms.TabPage();
            this.olaUsrHde = new System.Windows.Forms.Label();
            this.ocmAddUsr = new System.Windows.Forms.Button();
            this.ogdUsr = new System.Windows.Forms.DataGridView();
            this.otaTsc = new System.Windows.Forms.TabPage();
            this.olaTscHde = new System.Windows.Forms.Label();
            this.ogdTsc = new System.Windows.Forms.DataGridView();
            this.otaLgnLog = new System.Windows.Forms.TabPage();
            this.olaLgnLog = new System.Windows.Forms.Label();
            this.ocmRefsh = new System.Windows.Forms.Button();
            this.ogdLgnLog = new System.Windows.Forms.DataGridView();
            this.olaNme = new System.Windows.Forms.Label();
            this.olaWelc = new System.Windows.Forms.Label();
            this.olaHead = new System.Windows.Forms.Label();
            this.ocmStCon = new System.Windows.Forms.Button();
            this.otaCtrl.SuspendLayout();
            this.otaStk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdStk)).BeginInit();
            this.otaAdm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdUsr)).BeginInit();
            this.otaTsc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdTsc)).BeginInit();
            this.otaLgnLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdLgnLog)).BeginInit();
            this.SuspendLayout();
            // 
            // otaCtrl
            // 
            this.otaCtrl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.otaCtrl.Controls.Add(this.otaStk);
            this.otaCtrl.Controls.Add(this.otaAdm);
            this.otaCtrl.Controls.Add(this.otaTsc);
            this.otaCtrl.Controls.Add(this.otaLgnLog);
            this.otaCtrl.Location = new System.Drawing.Point(21, 47);
            this.otaCtrl.Margin = new System.Windows.Forms.Padding(4);
            this.otaCtrl.Name = "otaCtrl";
            this.otaCtrl.SelectedIndex = 0;
            this.otaCtrl.Size = new System.Drawing.Size(828, 673);
            this.otaCtrl.TabIndex = 4;
            // 
            // otaStk
            // 
            this.otaStk.Controls.Add(this.olaScrh);
            this.otaStk.Controls.Add(this.otbScrh);
            this.otaStk.Controls.Add(this.olaStkHde);
            this.otaStk.Controls.Add(this.ocmAddStk);
            this.otaStk.Controls.Add(this.ogdStk);
            this.otaStk.Location = new System.Drawing.Point(4, 25);
            this.otaStk.Margin = new System.Windows.Forms.Padding(4);
            this.otaStk.Name = "otaStk";
            this.otaStk.Padding = new System.Windows.Forms.Padding(4);
            this.otaStk.Size = new System.Drawing.Size(820, 644);
            this.otaStk.TabIndex = 0;
            this.otaStk.Text = "Stock management";
            this.otaStk.UseVisualStyleBackColor = true;
            // 
            // olaScrh
            // 
            this.olaScrh.AutoSize = true;
            this.olaScrh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaScrh.Location = new System.Drawing.Point(290, 48);
            this.olaScrh.Name = "olaScrh";
            this.olaScrh.Size = new System.Drawing.Size(77, 22);
            this.olaScrh.TabIndex = 15;
            this.olaScrh.Text = "Search :";
            // 
            // otbScrh
            // 
            this.otbScrh.Location = new System.Drawing.Point(389, 39);
            this.otbScrh.Multiline = true;
            this.otbScrh.Name = "otbScrh";
            this.otbScrh.Size = new System.Drawing.Size(269, 37);
            this.otbScrh.TabIndex = 14;
            this.otbScrh.TextChanged += new System.EventHandler(this.otbScrh_TextChanged);
            // 
            // olaStkHde
            // 
            this.olaStkHde.AutoSize = true;
            this.olaStkHde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaStkHde.Location = new System.Drawing.Point(8, 13);
            this.olaStkHde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaStkHde.Name = "olaStkHde";
            this.olaStkHde.Size = new System.Drawing.Size(219, 29);
            this.olaStkHde.TabIndex = 8;
            this.olaStkHde.Text = "Stock Management";
            // 
            // ocmAddStk
            // 
            this.ocmAddStk.Location = new System.Drawing.Point(670, 39);
            this.ocmAddStk.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ocmAddStk.Name = "ocmAddStk";
            this.ocmAddStk.Size = new System.Drawing.Size(139, 37);
            this.ocmAddStk.TabIndex = 13;
            this.ocmAddStk.Text = "Add Stock Part";
            this.ocmAddStk.UseVisualStyleBackColor = true;
            this.ocmAddStk.Click += new System.EventHandler(this.ocmAddStk_Click);
            // 
            // ogdStk
            // 
            this.ogdStk.AllowUserToAddRows = false;
            this.ogdStk.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdStk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogdStk.Location = new System.Drawing.Point(7, 86);
            this.ogdStk.Name = "ogdStk";
            this.ogdStk.RowHeadersWidth = 51;
            this.ogdStk.RowTemplate.Height = 24;
            this.ogdStk.Size = new System.Drawing.Size(806, 551);
            this.ogdStk.TabIndex = 0;
            this.ogdStk.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogdStk_CellContentClick);
            // 
            // otaAdm
            // 
            this.otaAdm.Controls.Add(this.olaUsrHde);
            this.otaAdm.Controls.Add(this.ocmAddUsr);
            this.otaAdm.Controls.Add(this.ogdUsr);
            this.otaAdm.Location = new System.Drawing.Point(4, 25);
            this.otaAdm.Margin = new System.Windows.Forms.Padding(4);
            this.otaAdm.Name = "otaAdm";
            this.otaAdm.Padding = new System.Windows.Forms.Padding(4);
            this.otaAdm.Size = new System.Drawing.Size(820, 644);
            this.otaAdm.TabIndex = 1;
            this.otaAdm.Text = "Admin user management";
            this.otaAdm.UseVisualStyleBackColor = true;
            // 
            // olaUsrHde
            // 
            this.olaUsrHde.AutoSize = true;
            this.olaUsrHde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaUsrHde.Location = new System.Drawing.Point(8, 48);
            this.olaUsrHde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaUsrHde.Name = "olaUsrHde";
            this.olaUsrHde.Size = new System.Drawing.Size(210, 29);
            this.olaUsrHde.TabIndex = 13;
            this.olaUsrHde.Text = "User Management";
            // 
            // ocmAddUsr
            // 
            this.ocmAddUsr.Location = new System.Drawing.Point(720, 40);
            this.ocmAddUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ocmAddUsr.Name = "ocmAddUsr";
            this.ocmAddUsr.Size = new System.Drawing.Size(87, 37);
            this.ocmAddUsr.TabIndex = 12;
            this.ocmAddUsr.Text = "Add User";
            this.ocmAddUsr.UseVisualStyleBackColor = true;
            this.ocmAddUsr.Click += new System.EventHandler(this.ocmAddUsr_Click);
            // 
            // ogdUsr
            // 
            this.ogdUsr.AllowUserToAddRows = false;
            this.ogdUsr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdUsr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogdUsr.Location = new System.Drawing.Point(7, 84);
            this.ogdUsr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ogdUsr.Name = "ogdUsr";
            this.ogdUsr.RowHeadersWidth = 51;
            this.ogdUsr.RowTemplate.Height = 24;
            this.ogdUsr.Size = new System.Drawing.Size(804, 551);
            this.ogdUsr.TabIndex = 11;
            this.ogdUsr.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ogdUsr_CellContentClick);
            // 
            // otaTsc
            // 
            this.otaTsc.Controls.Add(this.olaTscHde);
            this.otaTsc.Controls.Add(this.ogdTsc);
            this.otaTsc.Location = new System.Drawing.Point(4, 25);
            this.otaTsc.Name = "otaTsc";
            this.otaTsc.Padding = new System.Windows.Forms.Padding(3);
            this.otaTsc.Size = new System.Drawing.Size(820, 644);
            this.otaTsc.TabIndex = 2;
            this.otaTsc.Text = "Transaction log";
            this.otaTsc.UseVisualStyleBackColor = true;
            // 
            // olaTscHde
            // 
            this.olaTscHde.AutoSize = true;
            this.olaTscHde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaTscHde.Location = new System.Drawing.Point(7, 13);
            this.olaTscHde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaTscHde.Name = "olaTscHde";
            this.olaTscHde.Size = new System.Drawing.Size(186, 29);
            this.olaTscHde.TabIndex = 14;
            this.olaTscHde.Text = "Transaction Log";
            // 
            // ogdTsc
            // 
            this.ogdTsc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdTsc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogdTsc.Location = new System.Drawing.Point(6, 59);
            this.ogdTsc.Name = "ogdTsc";
            this.ogdTsc.RowHeadersWidth = 51;
            this.ogdTsc.RowTemplate.Height = 24;
            this.ogdTsc.Size = new System.Drawing.Size(808, 579);
            this.ogdTsc.TabIndex = 0;
            // 
            // otaLgnLog
            // 
            this.otaLgnLog.Controls.Add(this.olaLgnLog);
            this.otaLgnLog.Controls.Add(this.ocmRefsh);
            this.otaLgnLog.Controls.Add(this.ogdLgnLog);
            this.otaLgnLog.Location = new System.Drawing.Point(4, 25);
            this.otaLgnLog.Name = "otaLgnLog";
            this.otaLgnLog.Padding = new System.Windows.Forms.Padding(3);
            this.otaLgnLog.Size = new System.Drawing.Size(820, 644);
            this.otaLgnLog.TabIndex = 3;
            this.otaLgnLog.Text = "Login log";
            this.otaLgnLog.UseVisualStyleBackColor = true;
            // 
            // olaLgnLog
            // 
            this.olaLgnLog.AutoSize = true;
            this.olaLgnLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaLgnLog.Location = new System.Drawing.Point(8, 15);
            this.olaLgnLog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaLgnLog.Name = "olaLgnLog";
            this.olaLgnLog.Size = new System.Drawing.Size(120, 29);
            this.olaLgnLog.TabIndex = 15;
            this.olaLgnLog.Text = "Login Log";
            // 
            // ocmRefsh
            // 
            this.ocmRefsh.Location = new System.Drawing.Point(615, 18);
            this.ocmRefsh.Name = "ocmRefsh";
            this.ocmRefsh.Size = new System.Drawing.Size(75, 23);
            this.ocmRefsh.TabIndex = 1;
            this.ocmRefsh.Text = "Refesh";
            this.ocmRefsh.UseVisualStyleBackColor = true;
            this.ocmRefsh.Click += new System.EventHandler(this.ocmRefsh_Click);
            // 
            // ogdLgnLog
            // 
            this.ogdLgnLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ogdLgnLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ogdLgnLog.Location = new System.Drawing.Point(6, 51);
            this.ogdLgnLog.Name = "ogdLgnLog";
            this.ogdLgnLog.RowHeadersWidth = 51;
            this.ogdLgnLog.RowTemplate.Height = 24;
            this.ogdLgnLog.Size = new System.Drawing.Size(808, 587);
            this.ogdLgnLog.TabIndex = 0;
            // 
            // olaNme
            // 
            this.olaNme.AutoSize = true;
            this.olaNme.Location = new System.Drawing.Point(692, 27);
            this.olaNme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaNme.Name = "olaNme";
            this.olaNme.Size = new System.Drawing.Size(55, 16);
            this.olaNme.TabIndex = 7;
            this.olaNme.Text = "olaNme";
            // 
            // olaWelc
            // 
            this.olaWelc.AutoSize = true;
            this.olaWelc.Location = new System.Drawing.Point(612, 27);
            this.olaWelc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaWelc.Name = "olaWelc";
            this.olaWelc.Size = new System.Drawing.Size(71, 16);
            this.olaWelc.TabIndex = 6;
            this.olaWelc.Text = "Welcome :";
            // 
            // olaHead
            // 
            this.olaHead.AutoSize = true;
            this.olaHead.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olaHead.Location = new System.Drawing.Point(16, 14);
            this.olaHead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.olaHead.Name = "olaHead";
            this.olaHead.Size = new System.Drawing.Size(267, 29);
            this.olaHead.TabIndex = 5;
            this.olaHead.Text = "Ada Stock Management";
            // 
            // ocmStCon
            // 
            this.ocmStCon.Location = new System.Drawing.Point(290, 17);
            this.ocmStCon.Name = "ocmStCon";
            this.ocmStCon.Size = new System.Drawing.Size(46, 23);
            this.ocmStCon.TabIndex = 8;
            this.ocmStCon.UseVisualStyleBackColor = true;
            // 
            // wStkMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 732);
            this.Controls.Add(this.ocmStCon);
            this.Controls.Add(this.otaCtrl);
            this.Controls.Add(this.olaNme);
            this.Controls.Add(this.olaWelc);
            this.Controls.Add(this.olaHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "wStkMain";
            this.Text = "Ada Stock Management";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.oStkMain_FormClosed);
            this.Load += new System.EventHandler(this.oStkMain_Load);
            this.otaCtrl.ResumeLayout(false);
            this.otaStk.ResumeLayout(false);
            this.otaStk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdStk)).EndInit();
            this.otaAdm.ResumeLayout(false);
            this.otaAdm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdUsr)).EndInit();
            this.otaTsc.ResumeLayout(false);
            this.otaTsc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdTsc)).EndInit();
            this.otaLgnLog.ResumeLayout(false);
            this.otaLgnLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ogdLgnLog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl otaCtrl;
        private System.Windows.Forms.TabPage otaStk;
        private System.Windows.Forms.TabPage otaAdm;
        private System.Windows.Forms.Button ocmAddUsr;
        private System.Windows.Forms.DataGridView ogdUsr;
        private System.Windows.Forms.Label olaNme;
        private System.Windows.Forms.Label olaWelc;
        private System.Windows.Forms.Label olaHead;
        private System.Windows.Forms.DataGridView ogdStk;
        private System.Windows.Forms.Button ocmAddStk;
        private System.Windows.Forms.Label olaStkHde;
        private System.Windows.Forms.Label olaUsrHde;
        private System.Windows.Forms.TabPage otaTsc;
        private System.Windows.Forms.DataGridView ogdTsc;
        private System.Windows.Forms.Label olaTscHde;
        private System.Windows.Forms.Label olaScrh;
        private System.Windows.Forms.TextBox otbScrh;
        private System.Windows.Forms.Button ocmStCon;
        private System.Windows.Forms.TabPage otaLgnLog;
        private System.Windows.Forms.Label olaLgnLog;
        private System.Windows.Forms.Button ocmRefsh;
        private System.Windows.Forms.DataGridView ogdLgnLog;
    }
}