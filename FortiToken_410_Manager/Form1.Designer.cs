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
            PictureBox pictureBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            Title = new Label();
            label1 = new Label();
            keyStateLabel = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnDisableHOTP = new Button();
            BtnEnableHOTP = new Button();
            promptLabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AllowDrop = true;
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(125, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(748, 91);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel1.Controls.Add(keyStateLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 5);
            tableLayoutPanel1.Controls.Add(promptLabel, 0, 4);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 3);
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 6;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 34.0259743F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 41.89189F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0540543F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 114F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 153F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutPanel1.Size = new Size(998, 719);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(Title, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 127);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 69.79866F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 30.2013416F));
            tableLayoutPanel2.Size = new Size(992, 147);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Red;
            Title.Location = new Point(205, 18);
            Title.Name = "Title";
            Title.Size = new Size(581, 65);
            Title.TabIndex = 1;
            Title.Text = "FortiToken 410 Manager";
            Title.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(215, 102);
            label1.Name = "label1";
            label1.Size = new Size(561, 21);
            label1.TabIndex = 6;
            label1.Text = "Welcome to the FortiToken 410 Manager. Insert a FortiToken 410 key to start.";
            // 
            // keyStateLabel
            // 
            keyStateLabel.Anchor = AnchorStyles.None;
            keyStateLabel.AutoSize = true;
            keyStateLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            keyStateLabel.Location = new Point(499, 306);
            keyStateLabel.Name = "keyStateLabel";
            keyStateLabel.Size = new Size(0, 30);
            keyStateLabel.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(BtnDisableHOTP, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnEnableHOTP, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 568);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(992, 148);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // BtnDisableHOTP
            // 
            BtnDisableHOTP.Anchor = AnchorStyles.None;
            BtnDisableHOTP.Enabled = false;
            BtnDisableHOTP.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDisableHOTP.Location = new Point(581, 24);
            BtnDisableHOTP.Name = "BtnDisableHOTP";
            BtnDisableHOTP.Size = new Size(325, 100);
            BtnDisableHOTP.TabIndex = 1;
            BtnDisableHOTP.Text = "Disable HOTP";
            BtnDisableHOTP.UseVisualStyleBackColor = true;
            BtnDisableHOTP.Click += BtnDisableHOTP_Click;
            // 
            // BtnEnableHOTP
            // 
            BtnEnableHOTP.Anchor = AnchorStyles.None;
            BtnEnableHOTP.Enabled = false;
            BtnEnableHOTP.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEnableHOTP.Location = new Point(85, 24);
            BtnEnableHOTP.Name = "BtnEnableHOTP";
            BtnEnableHOTP.Size = new Size(325, 100);
            BtnEnableHOTP.TabIndex = 0;
            BtnEnableHOTP.Text = "Enable HOTP";
            BtnEnableHOTP.UseVisualStyleBackColor = true;
            BtnEnableHOTP.Click += BtnEnableHOTP_Click;
            // 
            // promptLabel
            // 
            promptLabel.Anchor = AnchorStyles.None;
            promptLabel.AutoSize = true;
            promptLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            promptLabel.Location = new Point(499, 507);
            promptLabel.Name = "promptLabel";
            promptLabel.Size = new Size(0, 30);
            promptLabel.TabIndex = 8;
            promptLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(350, 376);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(297, 92);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1024, 768);
            MinimizeBox = false;
            MinimumSize = new Size(1024, 768);
            Name = "Form1";
            Text = "FortiToken 410 Manager";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnDisableHOTP;
        private Button BtnEnableHOTP;
        private Label Title;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private PictureBox pictureBox1;
        private Label keyStateLabel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label promptLabel;
        private PictureBox pictureBox2;
    }
}
