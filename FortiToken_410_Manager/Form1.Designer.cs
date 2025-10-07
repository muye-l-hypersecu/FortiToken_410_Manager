namespace FortiToken_410_Manager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.PictureBox LogoImage;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTable = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonTable = new System.Windows.Forms.TableLayoutPanel();
            this.BtnDisableHOTP = new System.Windows.Forms.Button();
            this.BtnEnableHOTP = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.TokenImage = new System.Windows.Forms.PictureBox();
            this.OutputTable = new System.Windows.Forms.TableLayoutPanel();
            this.InsertHOTPStatusTable = new System.Windows.Forms.TableLayoutPanel();
            this.InsertHOTPLabel = new System.Windows.Forms.Label();
            this.HOTPStatusLabel = new System.Windows.Forms.Label();
            this.KeyStateLabel = new System.Windows.Forms.Label();
            this.PromptLabel = new System.Windows.Forms.Label();
            LogoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(LogoImage)).BeginInit();
            this.MainTable.SuspendLayout();
            this.ButtonTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TokenImage)).BeginInit();
            this.OutputTable.SuspendLayout();
            this.InsertHOTPStatusTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogoImage
            // 
            LogoImage.AllowDrop = true;
            LogoImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            LogoImage.Image = ((System.Drawing.Image)(resources.GetObject("LogoImage.Image")));
            LogoImage.InitialImage = null;
            LogoImage.Location = new System.Drawing.Point(574, 20);
            LogoImage.Margin = new System.Windows.Forms.Padding(3, 20, 30, 3);
            LogoImage.Name = "LogoImage";
            LogoImage.Size = new System.Drawing.Size(170, 26);
            LogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            LogoImage.TabIndex = 1;
            LogoImage.TabStop = false;
            // 
            // MainTable
            // 
            this.MainTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTable.ColumnCount = 1;
            this.MainTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainTable.Controls.Add(this.ButtonTable, 0, 4);
            this.MainTable.Controls.Add(this.Title, 0, 1);
            this.MainTable.Controls.Add(LogoImage, 0, 0);
            this.MainTable.Controls.Add(this.TokenImage, 0, 2);
            this.MainTable.Controls.Add(this.OutputTable, 0, 3);
            this.MainTable.Location = new System.Drawing.Point(5, 5);
            this.MainTable.Name = "MainTable";
            this.MainTable.RowCount = 5;
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.74723F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.50776F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.49446F));
            this.MainTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.MainTable.Size = new System.Drawing.Size(774, 451);
            this.MainTable.TabIndex = 0;
            // 
            // ButtonTable
            // 
            this.ButtonTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonTable.ColumnCount = 2;
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ButtonTable.Controls.Add(this.BtnDisableHOTP, 0, 0);
            this.ButtonTable.Controls.Add(this.BtnEnableHOTP, 1, 0);
            this.ButtonTable.Location = new System.Drawing.Point(3, 340);
            this.ButtonTable.Name = "ButtonTable";
            this.ButtonTable.RowCount = 1;
            this.ButtonTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ButtonTable.Size = new System.Drawing.Size(768, 108);
            this.ButtonTable.TabIndex = 5;
            // 
            // BtnDisableHOTP
            // 
            this.BtnDisableHOTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDisableHOTP.Enabled = false;
            this.BtnDisableHOTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDisableHOTP.Location = new System.Drawing.Point(134, 15);
            this.BtnDisableHOTP.Margin = new System.Windows.Forms.Padding(3, 15, 50, 3);
            this.BtnDisableHOTP.Name = "BtnDisableHOTP";
            this.BtnDisableHOTP.Size = new System.Drawing.Size(200, 50);
            this.BtnDisableHOTP.TabIndex = 1;
            this.BtnDisableHOTP.Text = "Disable HOTP";
            this.BtnDisableHOTP.UseVisualStyleBackColor = true;
            this.BtnDisableHOTP.Click += new System.EventHandler(this.BtnDisableHOTP_Click);
            // 
            // BtnEnableHOTP
            // 
            this.BtnEnableHOTP.Enabled = false;
            this.BtnEnableHOTP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnableHOTP.Location = new System.Drawing.Point(434, 15);
            this.BtnEnableHOTP.Margin = new System.Windows.Forms.Padding(50, 15, 3, 3);
            this.BtnEnableHOTP.Name = "BtnEnableHOTP";
            this.BtnEnableHOTP.Size = new System.Drawing.Size(200, 50);
            this.BtnEnableHOTP.TabIndex = 0;
            this.BtnEnableHOTP.Text = "Re-Enable HOTP";
            this.BtnEnableHOTP.UseVisualStyleBackColor = true;
            this.BtnEnableHOTP.Click += new System.EventHandler(this.BtnEnableHOTP_Click);
            // 
            // Title
            // 
            this.Title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(223, 70);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(328, 32);
            this.Title.TabIndex = 1;
            this.Title.Text = "FortiToken 410 Manager";
            this.Title.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TokenImage
            // 
            this.TokenImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TokenImage.BackColor = System.Drawing.SystemColors.Control;
            this.TokenImage.Image = ((System.Drawing.Image)(resources.GetObject("TokenImage.Image")));
            this.TokenImage.Location = new System.Drawing.Point(3, 119);
            this.TokenImage.Name = "TokenImage";
            this.TokenImage.Size = new System.Drawing.Size(768, 91);
            this.TokenImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TokenImage.TabIndex = 9;
            this.TokenImage.TabStop = false;
            // 
            // OutputTable
            // 
            this.OutputTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTable.ColumnCount = 1;
            this.OutputTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.OutputTable.Controls.Add(this.InsertHOTPStatusTable, 0, 1);
            this.OutputTable.Controls.Add(this.KeyStateLabel, 0, 0);
            this.OutputTable.Controls.Add(this.PromptLabel, 0, 2);
            this.OutputTable.Location = new System.Drawing.Point(3, 216);
            this.OutputTable.Name = "OutputTable";
            this.OutputTable.RowCount = 3;
            this.OutputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.OutputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.OutputTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45F));
            this.OutputTable.Size = new System.Drawing.Size(768, 118);
            this.OutputTable.TabIndex = 10;
            // 
            // InsertHOTPStatusTable
            // 
            this.InsertHOTPStatusTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertHOTPStatusTable.ColumnCount = 2;
            this.InsertHOTPStatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InsertHOTPStatusTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0F));
            this.InsertHOTPStatusTable.Controls.Add(this.InsertHOTPLabel, 0, 0);
            this.InsertHOTPStatusTable.Controls.Add(this.HOTPStatusLabel, 1, 0);
            this.InsertHOTPStatusTable.Location = new System.Drawing.Point(3, 38);
            this.InsertHOTPStatusTable.Name = "InsertHOTPStatusTable";
            this.InsertHOTPStatusTable.RowCount = 1;
            this.InsertHOTPStatusTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.InsertHOTPStatusTable.Size = new System.Drawing.Size(762, 23);
            this.InsertHOTPStatusTable.TabIndex = 7;
            // 
            // InsertHOTPLabel
            // 
            this.InsertHOTPLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InsertHOTPLabel.AutoSize = true;
            this.InsertHOTPLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertHOTPLabel.Location = new System.Drawing.Point(381, 3);
            this.InsertHOTPLabel.Name = "InsertHOTPLabel";
            this.InsertHOTPLabel.Size = new System.Drawing.Size(0, 17);
            this.InsertHOTPLabel.TabIndex = 6;
            this.InsertHOTPLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HOTPStatusLabel
            // 
            this.HOTPStatusLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.HOTPStatusLabel.AutoSize = true;
            this.HOTPStatusLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HOTPStatusLabel.Location = new System.Drawing.Point(765, 3);
            this.HOTPStatusLabel.Name = "HOTPStatusLabel";
            this.HOTPStatusLabel.Size = new System.Drawing.Size(0, 17);
            this.HOTPStatusLabel.TabIndex = 7;
            this.HOTPStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyStateLabel
            // 
            this.KeyStateLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.KeyStateLabel.AutoSize = true;
            this.KeyStateLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyStateLabel.Location = new System.Drawing.Point(384, 17);
            this.KeyStateLabel.Name = "KeyStateLabel";
            this.KeyStateLabel.Size = new System.Drawing.Size(0, 18);
            this.KeyStateLabel.TabIndex = 8;
            // 
            // PromptLabel
            // 
            this.PromptLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PromptLabel.AutoSize = true;
            this.PromptLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptLabel.Location = new System.Drawing.Point(384, 82);
            this.PromptLabel.Name = "PromptLabel";
            this.PromptLabel.Size = new System.Drawing.Size(0, 17);
            this.PromptLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.MainTable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Form1";
            this.Text = "FortiToken 410 Manager";
            ((System.ComponentModel.ISupportInitialize)(LogoImage)).EndInit();
            this.MainTable.ResumeLayout(false);
            this.MainTable.PerformLayout();
            this.ButtonTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TokenImage)).EndInit();
            this.OutputTable.ResumeLayout(false);
            this.OutputTable.PerformLayout();
            this.InsertHOTPStatusTable.ResumeLayout(false);
            this.InsertHOTPStatusTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel MainTable;
        private Button BtnDisableHOTP;
        private Button BtnEnableHOTP;
        private Label Title;
        private TableLayoutPanel ButtonTable;
        private Label InsertHOTPLabel;
        private PictureBox TokenImage;
        private TableLayoutPanel OutputTable;
        private TableLayoutPanel InsertHOTPStatusTable;
        private Label KeyStateLabel;
        private Label HOTPStatusLabel;
        private Label PromptLabel;
    }
}
