
namespace TFCalc
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
            this.cash = new System.Windows.Forms.Button();
            this.visa = new System.Windows.Forms.Button();
            this.mc = new System.Windows.Forms.Button();
            this.amex = new System.Windows.Forms.Button();
            this.it = new System.Windows.Forms.Button();
            this.mop = new System.Windows.Forms.GroupBox();
            this.itFee = new System.Windows.Forms.NumericUpDown();
            this.amexFee = new System.Windows.Forms.NumericUpDown();
            this.mcFee = new System.Windows.Forms.NumericUpDown();
            this.visaFee = new System.Windows.Forms.NumericUpDown();
            this.cashFee = new System.Windows.Forms.NumericUpDown();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileNav = new System.Windows.Forms.ToolStripMenuItem();
            this.viewNav = new System.Windows.Forms.ToolStripMenuItem();
            this.editNav = new System.Windows.Forms.ToolStripMenuItem();
            this.cinText = new System.Windows.Forms.RichTextBox();
            this.cinLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.coutText = new System.Windows.Forms.RichTextBox();
            this.coutLabel = new System.Windows.Forms.Label();
            this.totLabel = new System.Windows.Forms.Label();
            this.totText = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amexFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.visaFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashFee)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cash
            // 
            this.cash.Location = new System.Drawing.Point(21, 41);
            this.cash.Name = "cash";
            this.cash.Size = new System.Drawing.Size(172, 50);
            this.cash.TabIndex = 5;
            this.cash.Text = "Cash";
            this.cash.UseVisualStyleBackColor = true;
            this.cash.Click += new System.EventHandler(this.cash_Click);
            // 
            // visa
            // 
            this.visa.Location = new System.Drawing.Point(21, 97);
            this.visa.Name = "visa";
            this.visa.Size = new System.Drawing.Size(172, 50);
            this.visa.TabIndex = 6;
            this.visa.Text = "Visa";
            this.visa.UseVisualStyleBackColor = true;
            this.visa.Click += new System.EventHandler(this.visa_Click);
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(21, 153);
            this.mc.Name = "mc";
            this.mc.Size = new System.Drawing.Size(172, 50);
            this.mc.TabIndex = 7;
            this.mc.Text = "Mastercard";
            this.mc.UseVisualStyleBackColor = true;
            this.mc.Click += new System.EventHandler(this.mc_Click);
            // 
            // amex
            // 
            this.amex.Location = new System.Drawing.Point(21, 209);
            this.amex.Name = "amex";
            this.amex.Size = new System.Drawing.Size(172, 50);
            this.amex.TabIndex = 8;
            this.amex.Text = "AMEX";
            this.amex.UseVisualStyleBackColor = true;
            this.amex.Click += new System.EventHandler(this.amex_Click);
            // 
            // it
            // 
            this.it.Location = new System.Drawing.Point(21, 265);
            this.it.Name = "it";
            this.it.Size = new System.Drawing.Size(172, 50);
            this.it.TabIndex = 9;
            this.it.Text = "INTERAC";
            this.it.UseVisualStyleBackColor = true;
            this.it.Click += new System.EventHandler(this.it_Click);
            // 
            // mop
            // 
            this.mop.Controls.Add(this.itFee);
            this.mop.Controls.Add(this.amexFee);
            this.mop.Controls.Add(this.mcFee);
            this.mop.Controls.Add(this.visaFee);
            this.mop.Controls.Add(this.cashFee);
            this.mop.Controls.Add(this.it);
            this.mop.Controls.Add(this.amex);
            this.mop.Controls.Add(this.mc);
            this.mop.Controls.Add(this.visa);
            this.mop.Controls.Add(this.cash);
            this.mop.Location = new System.Drawing.Point(255, 39);
            this.mop.Name = "mop";
            this.mop.Size = new System.Drawing.Size(301, 332);
            this.mop.TabIndex = 10;
            this.mop.TabStop = false;
            this.mop.Text = "Method of Payment ---------------------------------Processing Fee (%)";
            // 
            // itFee
            // 
            this.itFee.DecimalPlaces = 3;
            this.itFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.itFee.Location = new System.Drawing.Point(199, 265);
            this.itFee.MaximumSize = new System.Drawing.Size(100, 0);
            this.itFee.Name = "itFee";
            this.itFee.Size = new System.Drawing.Size(64, 20);
            this.itFee.TabIndex = 15;
            this.itFee.Value = new decimal(new int[] {
            275,
            0,
            0,
            196608});
            // 
            // amexFee
            // 
            this.amexFee.DecimalPlaces = 3;
            this.amexFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.amexFee.Location = new System.Drawing.Point(199, 209);
            this.amexFee.MaximumSize = new System.Drawing.Size(100, 0);
            this.amexFee.Name = "amexFee";
            this.amexFee.Size = new System.Drawing.Size(64, 20);
            this.amexFee.TabIndex = 14;
            this.amexFee.Value = new decimal(new int[] {
            3735,
            0,
            0,
            196608});
            // 
            // mcFee
            // 
            this.mcFee.DecimalPlaces = 3;
            this.mcFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.mcFee.Location = new System.Drawing.Point(199, 153);
            this.mcFee.MaximumSize = new System.Drawing.Size(100, 0);
            this.mcFee.Name = "mcFee";
            this.mcFee.Size = new System.Drawing.Size(64, 20);
            this.mcFee.TabIndex = 13;
            this.mcFee.Value = new decimal(new int[] {
            1735,
            0,
            0,
            196608});
            // 
            // visaFee
            // 
            this.visaFee.DecimalPlaces = 3;
            this.visaFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.visaFee.Location = new System.Drawing.Point(199, 97);
            this.visaFee.MaximumSize = new System.Drawing.Size(100, 0);
            this.visaFee.Name = "visaFee";
            this.visaFee.Size = new System.Drawing.Size(64, 20);
            this.visaFee.TabIndex = 12;
            this.visaFee.Value = new decimal(new int[] {
            125,
            0,
            0,
            131072});
            // 
            // cashFee
            // 
            this.cashFee.DecimalPlaces = 3;
            this.cashFee.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.cashFee.Location = new System.Drawing.Point(199, 41);
            this.cashFee.MaximumSize = new System.Drawing.Size(100, 0);
            this.cashFee.Name = "cashFee";
            this.cashFee.Size = new System.Drawing.Size(64, 20);
            this.cashFee.TabIndex = 11;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileNav,
            this.viewNav,
            this.editNav});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(568, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "NavBar";
            // 
            // fileNav
            // 
            this.fileNav.Name = "fileNav";
            this.fileNav.Size = new System.Drawing.Size(37, 20);
            this.fileNav.Text = "File";
            // 
            // viewNav
            // 
            this.viewNav.Name = "viewNav";
            this.viewNav.Size = new System.Drawing.Size(44, 20);
            this.viewNav.Text = "View";
            // 
            // editNav
            // 
            this.editNav.Name = "editNav";
            this.editNav.Size = new System.Drawing.Size(39, 20);
            this.editNav.Text = "Edit";
            // 
            // cinText
            // 
            this.cinText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cinText.Location = new System.Drawing.Point(15, 58);
            this.cinText.Multiline = false;
            this.cinText.Name = "cinText";
            this.cinText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cinText.Size = new System.Drawing.Size(211, 50);
            this.cinText.TabIndex = 13;
            this.cinText.Text = "";
            // 
            // cinLabel
            // 
            this.cinLabel.AutoSize = true;
            this.cinLabel.Location = new System.Drawing.Point(12, 39);
            this.cinLabel.Name = "cinLabel";
            this.cinLabel.Size = new System.Drawing.Size(43, 13);
            this.cinLabel.TabIndex = 14;
            this.cinLabel.Text = "Cash-In";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(12, 117);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(27, 13);
            this.descLabel.TabIndex = 16;
            this.descLabel.Text = "Item";
            // 
            // coutText
            // 
            this.coutText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.coutText.Location = new System.Drawing.Point(15, 236);
            this.coutText.Name = "coutText";
            this.coutText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.coutText.Size = new System.Drawing.Size(211, 56);
            this.coutText.TabIndex = 17;
            this.coutText.Text = "$";
            // 
            // coutLabel
            // 
            this.coutLabel.AutoSize = true;
            this.coutLabel.Location = new System.Drawing.Point(12, 220);
            this.coutLabel.Name = "coutLabel";
            this.coutLabel.Size = new System.Drawing.Size(51, 13);
            this.coutLabel.TabIndex = 18;
            this.coutLabel.Text = "Cash-Out";
            // 
            // totLabel
            // 
            this.totLabel.AutoSize = true;
            this.totLabel.Location = new System.Drawing.Point(12, 299);
            this.totLabel.Name = "totLabel";
            this.totLabel.Size = new System.Drawing.Size(31, 13);
            this.totLabel.TabIndex = 20;
            this.totLabel.Text = "Total";
            // 
            // totText
            // 
            this.totText.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.totText.Location = new System.Drawing.Point(15, 315);
            this.totText.Name = "totText";
            this.totText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totText.Size = new System.Drawing.Size(211, 56);
            this.totText.TabIndex = 19;
            this.totText.Text = "$";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(15, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(211, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 383);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.totLabel);
            this.Controls.Add(this.totText);
            this.Controls.Add(this.coutLabel);
            this.Controls.Add(this.coutText);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.cinLabel);
            this.Controls.Add(this.cinText);
            this.Controls.Add(this.mop);
            this.Controls.Add(this.menuStrip);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amexFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mcFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.visaFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cashFee)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cash;
        private System.Windows.Forms.Button visa;
        private System.Windows.Forms.Button mc;
        private System.Windows.Forms.Button amex;
        private System.Windows.Forms.Button it;
        private System.Windows.Forms.GroupBox mop;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileNav;
        private System.Windows.Forms.ToolStripMenuItem viewNav;
        private System.Windows.Forms.ToolStripMenuItem editNav;
        private System.Windows.Forms.RichTextBox cinText;
        private System.Windows.Forms.Label cinLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.NumericUpDown cashFee;
        private System.Windows.Forms.NumericUpDown visaFee;
        private System.Windows.Forms.NumericUpDown itFee;
        private System.Windows.Forms.NumericUpDown amexFee;
        private System.Windows.Forms.NumericUpDown mcFee;
        private System.Windows.Forms.RichTextBox coutText;
        private System.Windows.Forms.Label coutLabel;
        private System.Windows.Forms.Label totLabel;
        private System.Windows.Forms.RichTextBox totText;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

