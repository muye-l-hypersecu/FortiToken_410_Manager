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
            label3 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnDisableHOTP = new Button();
            BtnEnableHOTP = new Button();
            tableLayoutPanel4 = new TableLayoutPanel();
            keyStatus = new Label();
            keyStateLabel = new Label();
            FIDOlabel = new Label();
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
            pictureBox1.Location = new Point(733, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 59);
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
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 3);
            tableLayoutPanel1.Controls.Add(pictureBox2, 0, 2);
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 39.1304359F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 38.858696F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.01087F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 163F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 187F));
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
            tableLayoutPanel2.Controls.Add(label1, 0, 2);
            tableLayoutPanel2.Controls.Add(label3, 0, 1);
            tableLayoutPanel2.Location = new Point(3, 147);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 76.08696F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 23.913044F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel2.Size = new Size(992, 137);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.None;
            Title.AutoSize = true;
            Title.Font = new Font("Arial", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.ForeColor = Color.Black;
            Title.Location = new Point(209, 7);
            Title.Name = "Title";
            Title.Size = new Size(574, 56);
            Title.TabIndex = 1;
            Title.Text = "FortiToken 410 Manager";
            Title.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(206, 92);
            label1.Name = "label1";
            label1.Size = new Size(579, 19);
            label1.TabIndex = 6;
            label1.Text = "Welcome to the FortiToken 410 Manager. Insert a FortiToken 410 key to begin.";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.BackColor = Color.FromArgb(218, 41, 28);
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(216, 70);
            label3.Name = "label3";
            label3.Size = new Size(560, 3);
            label3.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(BtnDisableHOTP, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnEnableHOTP, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 534);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(992, 182);
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
            tableLayoutPanel4.Controls.Add(FIDOlabel, 0, 2);
            tableLayoutPanel4.Controls.Add(HOTPlabel, 0, 3);
            tableLayoutPanel4.Location = new Point(390, 371);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 4;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 24F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 70F));
            tableLayoutPanel4.Size = new Size(218, 157);
            tableLayoutPanel4.TabIndex = 10;
            // 
            // keyStatus
            // 
            keyStatus.Anchor = AnchorStyles.Left;
            keyStatus.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            keyStatus.Location = new Point(3, 8);
            keyStatus.Margin = new Padding(3, 0, 3, 3);
            keyStatus.Name = "keyStatus";
            keyStatus.Size = new Size(105, 19);
            keyStatus.TabIndex = 11;
            keyStatus.Text = "Key Status:";
            // 
            // keyStateLabel
            // 
            keyStateLabel.AutoSize = true;
            keyStateLabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keyStateLabel.Location = new Point(3, 38);
            keyStateLabel.Name = "keyStateLabel";
            keyStateLabel.Size = new Size(0, 18);
            keyStateLabel.TabIndex = 12;
            // 
            // FIDOlabel
            // 
            FIDOlabel.AutoSize = true;
            FIDOlabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FIDOlabel.Location = new Point(3, 63);
            FIDOlabel.Name = "FIDOlabel";
            FIDOlabel.Size = new Size(0, 18);
            FIDOlabel.TabIndex = 13;
            // 
            // HOTPlabel
            // 
            HOTPlabel.AutoSize = true;
            HOTPlabel.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HOTPlabel.Location = new Point(3, 87);
            HOTPlabel.Name = "HOTPlabel";
            HOTPlabel.Size = new Size(0, 18);
            HOTPlabel.TabIndex = 14;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(399, 296);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(199, 62);
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
        private Label label3;
        private Label keyStateLabel;
        private Label FIDOlabel;
        private Label HOTPlabel;
    }
}
