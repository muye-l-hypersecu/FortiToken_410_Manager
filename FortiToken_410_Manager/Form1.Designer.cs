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
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnDisableHOTP = new Button();
            BtnEnableHOTP = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            keyStatus = new Label();
            keyStateLabel = new Label();
            HOTPlabel = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.AllowDrop = true;
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(639, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 36);
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
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 2);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.586895F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.42105F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 36.05263F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 162F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 157F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(998, 719);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(Title, 0, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 105);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 63F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(992, 147);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Arial", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(261, 19);
            Title.Name = "Title";
            Title.Size = new Size(470, 46);
            Title.TabIndex = 1;
            Title.Text = "FortiToken 410 Manager";
            Title.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(358, 84);
            label1.Name = "label1";
            label1.Size = new Size(275, 19);
            label1.TabIndex = 6;
            label1.Text = "Insert a FortiToken 410 key to begin.";
            label1.Click += label1_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(BtnDisableHOTP, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnEnableHOTP, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 564);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(992, 152);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // BtnDisableHOTP
            // 
            BtnDisableHOTP.Enabled = false;
            BtnDisableHOTP.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDisableHOTP.Location = new Point(516, 3);
            BtnDisableHOTP.Margin = new Padding(20, 3, 3, 3);
            BtnDisableHOTP.Name = "BtnDisableHOTP";
            BtnDisableHOTP.Size = new Size(190, 55);
            BtnDisableHOTP.TabIndex = 1;
            BtnDisableHOTP.Text = "Disable HOTP";
            BtnDisableHOTP.UseVisualStyleBackColor = true;
            BtnDisableHOTP.Click += BtnDisableHOTP_Click;
            // 
            // BtnEnableHOTP
            // 
            BtnEnableHOTP.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEnableHOTP.Enabled = false;
            BtnEnableHOTP.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEnableHOTP.Location = new Point(286, 3);
            BtnEnableHOTP.Margin = new Padding(3, 3, 20, 3);
            BtnEnableHOTP.Name = "BtnEnableHOTP";
            BtnEnableHOTP.Size = new Size(190, 55);
            BtnEnableHOTP.TabIndex = 0;
            BtnEnableHOTP.Text = "Enable HOTP";
            BtnEnableHOTP.UseVisualStyleBackColor = true;
            BtnEnableHOTP.Click += BtnEnableHOTP_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(keyStatus, 0, 0);
            tableLayoutPanel4.Controls.Add(keyStateLabel, 0, 1);
            tableLayoutPanel4.Controls.Add(HOTPlabel, 0, 2);
            tableLayoutPanel4.Location = new Point(390, 402);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 31F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 86F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(218, 156);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // keyStatus
            // 
            keyStatus.AutoSize = true;
            keyStatus.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            keyStatus.Location = new Point(3, 0);
            keyStatus.Margin = new Padding(3, 0, 0, 0);
            keyStatus.Name = "keyStatus";
            keyStatus.Size = new Size(117, 22);
            keyStatus.TabIndex = 11;
            keyStatus.Text = "Key Status:";
            // 
            // keyStateLabel
            // 
            keyStateLabel.AutoSize = true;
            keyStateLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keyStateLabel.Location = new Point(3, 39);
            keyStateLabel.Name = "keyStateLabel";
            keyStateLabel.Size = new Size(0, 18);
            keyStateLabel.TabIndex = 12;
            // 
            // HOTPlabel
            // 
            HOTPlabel.AutoSize = true;
            HOTPlabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HOTPlabel.Location = new Point(3, 70);
            HOTPlabel.Name = "HOTPlabel";
            HOTPlabel.Size = new Size(0, 18);
            HOTPlabel.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(399, 277);
            pictureBox2.Margin = new Padding(3, 3, 3, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 62);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            pictureBox2.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
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
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
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
        private TableLayoutPanel tableLayoutPanel2;
        private PictureBox pictureBox2;
        private TableLayoutPanel tableLayoutPanel4;
        private Label keyStatus;
        private Label keyStateLabel;
        private Label HOTPlabel;
    }
}
