namespace MusicStore
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpType = new System.Windows.Forms.GroupBox();
            this.rdoVinyl = new System.Windows.Forms.RadioButton();
            this.rdoItunes = new System.Windows.Forms.RadioButton();
            this.rdoCd = new System.Windows.Forms.RadioButton();
            this.grpPurchase = new System.Windows.Forms.GroupBox();
            this.PictureBox2 = new System.Windows.Forms.PictureBox();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lstSelections = new System.Windows.Forms.ListBox();
            this.lstAlbums = new System.Windows.Forms.ListBox();
            this.grpAcctNum = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.txtMemberNumber = new System.Windows.Forms.TextBox();
            this.grpCheckOut = new System.Windows.Forms.GroupBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.grpType.SuspendLayout();
            this.grpPurchase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.grpAcctNum.SuspendLayout();
            this.grpCheckOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(372, 456);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 32);
            this.btnExit.TabIndex = 30;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(286, 456);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 32);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "C&lear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // grpType
            // 
            this.grpType.Controls.Add(this.rdoVinyl);
            this.grpType.Controls.Add(this.rdoItunes);
            this.grpType.Controls.Add(this.rdoCd);
            this.grpType.Location = new System.Drawing.Point(54, 360);
            this.grpType.Name = "grpType";
            this.grpType.Size = new System.Drawing.Size(120, 112);
            this.grpType.TabIndex = 27;
            this.grpType.TabStop = false;
            this.grpType.Text = "Select Type";
            // 
            // rdoVinyl
            // 
            this.rdoVinyl.Location = new System.Drawing.Point(16, 80);
            this.rdoVinyl.Name = "rdoVinyl";
            this.rdoVinyl.Size = new System.Drawing.Size(88, 24);
            this.rdoVinyl.TabIndex = 9;
            this.rdoVinyl.Text = "Vinyl";
            // 
            // rdoItunes
            // 
            this.rdoItunes.Location = new System.Drawing.Point(16, 48);
            this.rdoItunes.Name = "rdoItunes";
            this.rdoItunes.Size = new System.Drawing.Size(88, 24);
            this.rdoItunes.TabIndex = 8;
            this.rdoItunes.Text = "iTunes";
            // 
            // rdoCd
            // 
            this.rdoCd.Checked = true;
            this.rdoCd.Location = new System.Drawing.Point(16, 16);
            this.rdoCd.Name = "rdoCd";
            this.rdoCd.Size = new System.Drawing.Size(88, 24);
            this.rdoCd.TabIndex = 7;
            this.rdoCd.TabStop = true;
            this.rdoCd.Text = "CD";
            // 
            // grpPurchase
            // 
            this.grpPurchase.Controls.Add(this.PictureBox2);
            this.grpPurchase.Controls.Add(this.PictureBox1);
            this.grpPurchase.Controls.Add(this.lstSelections);
            this.grpPurchase.Controls.Add(this.lstAlbums);
            this.grpPurchase.Location = new System.Drawing.Point(54, 112);
            this.grpPurchase.Name = "grpPurchase";
            this.grpPurchase.Size = new System.Drawing.Size(416, 232);
            this.grpPurchase.TabIndex = 26;
            this.grpPurchase.TabStop = false;
            this.grpPurchase.Text = "Select your purchase";
            // 
            // PictureBox2
            // 
            this.PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox2.Image")));
            this.PictureBox2.Location = new System.Drawing.Point(200, 112);
            this.PictureBox2.Name = "PictureBox2";
            this.PictureBox2.Size = new System.Drawing.Size(16, 16);
            this.PictureBox2.TabIndex = 6;
            this.PictureBox2.TabStop = false;
            this.PictureBox2.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Enabled = false;
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(200, 72);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(16, 16);
            this.PictureBox1.TabIndex = 5;
            this.PictureBox1.TabStop = false;
            this.PictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // lstSelections
            // 
            this.lstSelections.Location = new System.Drawing.Point(232, 24);
            this.lstSelections.Name = "lstSelections";
            this.lstSelections.Size = new System.Drawing.Size(160, 186);
            this.lstSelections.TabIndex = 4;
            // 
            // lstAlbums
            // 
            this.lstAlbums.Location = new System.Drawing.Point(24, 24);
            this.lstAlbums.Name = "lstAlbums";
            this.lstAlbums.Size = new System.Drawing.Size(160, 186);
            this.lstAlbums.Sorted = true;
            this.lstAlbums.TabIndex = 3;
            this.lstAlbums.SelectedIndexChanged += new System.EventHandler(this.lstAlbums_SelectedIndexChanged);
            // 
            // grpAcctNum
            // 
            this.grpAcctNum.Controls.Add(this.btnOrder);
            this.grpAcctNum.Controls.Add(this.txtMemberNumber);
            this.grpAcctNum.Location = new System.Drawing.Point(134, 16);
            this.grpAcctNum.Name = "grpAcctNum";
            this.grpAcctNum.Size = new System.Drawing.Size(272, 72);
            this.grpAcctNum.TabIndex = 25;
            this.grpAcctNum.TabStop = false;
            this.grpAcctNum.Text = "Enter Member Number";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(176, 32);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(80, 24);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.Text = "Place &Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // txtMemberNumber
            // 
            this.txtMemberNumber.Location = new System.Drawing.Point(32, 32);
            this.txtMemberNumber.Name = "txtMemberNumber";
            this.txtMemberNumber.Size = new System.Drawing.Size(112, 20);
            this.txtMemberNumber.TabIndex = 0;
            // 
            // grpCheckOut
            // 
            this.grpCheckOut.Controls.Add(this.lblDisplay);
            this.grpCheckOut.Controls.Add(this.btnCheckOut);
            this.grpCheckOut.Location = new System.Drawing.Point(182, 360);
            this.grpCheckOut.Name = "grpCheckOut";
            this.grpCheckOut.Size = new System.Drawing.Size(312, 88);
            this.grpCheckOut.TabIndex = 28;
            this.grpCheckOut.TabStop = false;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Location = new System.Drawing.Point(128, 40);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(178, 24);
            this.lblDisplay.TabIndex = 12;
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(16, 32);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(80, 32);
            this.btnCheckOut.TabIndex = 11;
            this.btnCheckOut.Text = "&Check Out";
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 504);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.grpType);
            this.Controls.Add(this.grpPurchase);
            this.Controls.Add(this.grpAcctNum);
            this.Controls.Add(this.grpCheckOut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.btnClear_Click);
            this.grpType.ResumeLayout(false);
            this.grpPurchase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.grpAcctNum.ResumeLayout(false);
            this.grpAcctNum.PerformLayout();
            this.grpCheckOut.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnClear;
        internal System.Windows.Forms.GroupBox grpType;
        internal System.Windows.Forms.RadioButton rdoVinyl;
        internal System.Windows.Forms.RadioButton rdoItunes;
        internal System.Windows.Forms.RadioButton rdoCd;
        internal System.Windows.Forms.GroupBox grpPurchase;
        internal System.Windows.Forms.PictureBox PictureBox2;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.ListBox lstSelections;
        internal System.Windows.Forms.ListBox lstAlbums;
        internal System.Windows.Forms.GroupBox grpAcctNum;
        internal System.Windows.Forms.Button btnOrder;
        internal System.Windows.Forms.TextBox txtMemberNumber;
        internal System.Windows.Forms.GroupBox grpCheckOut;
        internal System.Windows.Forms.Label lblDisplay;
        internal System.Windows.Forms.Button btnCheckOut;
    }
}

