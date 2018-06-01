namespace WinPi_Imager
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ContentPanel1 = new System.Windows.Forms.Panel();
            this.ContentLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.RefreshDisksButton = new System.Windows.Forms.Button();
            this.ContentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(12, 9);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(101, 25);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Welcome";
            // 
            // ContentPanel1
            // 
            this.ContentPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ContentPanel1.Controls.Add(this.RefreshDisksButton);
            this.ContentPanel1.Controls.Add(this.ComboBox);
            this.ContentPanel1.Controls.Add(this.NextButton);
            this.ContentPanel1.Controls.Add(this.CheckBox);
            this.ContentPanel1.Controls.Add(this.TextBox);
            this.ContentPanel1.Controls.Add(this.ContentLabel);
            this.ContentPanel1.Location = new System.Drawing.Point(17, 47);
            this.ContentPanel1.Name = "ContentPanel1";
            this.ContentPanel1.Size = new System.Drawing.Size(914, 460);
            this.ContentPanel1.TabIndex = 1;
            // 
            // ContentLabel
            // 
            this.ContentLabel.AutoSize = true;
            this.ContentLabel.Location = new System.Drawing.Point(13, 15);
            this.ContentLabel.Name = "ContentLabel";
            this.ContentLabel.Size = new System.Drawing.Size(582, 25);
            this.ContentLabel.TabIndex = 0;
            this.ContentLabel.Text = "Welcome! Before continuing, please read. This is important.";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(16, 54);
            this.TextBox.Multiline = true;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = true;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox.Size = new System.Drawing.Size(874, 309);
            this.TextBox.TabIndex = 1;
            this.TextBox.Text = resources.GetString("TextBox.Text");
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Location = new System.Drawing.Point(16, 380);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(227, 29);
            this.CheckBox.TabIndex = 0;
            this.CheckBox.Text = "I read the message";
            this.CheckBox.UseVisualStyleBackColor = true;
            this.CheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // NextButton
            // 
            this.NextButton.Enabled = false;
            this.NextButton.Location = new System.Drawing.Point(760, 405);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(130, 41);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.Enabled = false;
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(16, 102);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(874, 33);
            this.ComboBox.TabIndex = 4;
            this.ComboBox.Visible = false;
            // 
            // RefreshDisksButton
            // 
            this.RefreshDisksButton.Enabled = false;
            this.RefreshDisksButton.Location = new System.Drawing.Point(16, 150);
            this.RefreshDisksButton.Name = "RefreshDisksButton";
            this.RefreshDisksButton.Size = new System.Drawing.Size(175, 39);
            this.RefreshDisksButton.TabIndex = 5;
            this.RefreshDisksButton.Text = "Refresh Disks";
            this.RefreshDisksButton.UseVisualStyleBackColor = true;
            this.RefreshDisksButton.Visible = false;
            this.RefreshDisksButton.Click += new System.EventHandler(this.RefreshDisksButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 519);
            this.Controls.Add(this.ContentPanel1);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Windows on RasPi Imager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ContentPanel1.ResumeLayout(false);
            this.ContentPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Panel ContentPanel1;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label ContentLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.CheckBox CheckBox;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Button RefreshDisksButton;
    }
}

