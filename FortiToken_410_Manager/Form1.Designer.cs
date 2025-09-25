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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tableLayoutPanel1 = new TableLayoutPanel();
            Title = new Label();
            listBox1 = new ListBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            BtnDisableHOTP = new Button();
            BtnEnableHOTP = new Button();
            keyStateLabel = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(Title, 0, 0);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 3);
            tableLayoutPanel1.Controls.Add(keyStateLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5600052F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.636364F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.2640686F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 52.5974045F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 256F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 167F));
            tableLayoutPanel1.Size = new Size(998, 719);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(3, 15);
            Title.Name = "Title";
            Title.Size = new Size(333, 37);
            Title.TabIndex = 1;
            Title.Text = "FortiToken 410 Manager";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = SystemColors.ControlLight;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = Color.Red;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 465);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(992, 240);
            listBox1.TabIndex = 4;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.5887089F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.41129F));
            tableLayoutPanel3.Controls.Add(BtnDisableHOTP, 1, 0);
            tableLayoutPanel3.Controls.Add(BtnEnableHOTP, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 222);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(992, 237);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // BtnDisableHOTP
            // 
            BtnDisableHOTP.Anchor = AnchorStyles.Left;
            BtnDisableHOTP.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnDisableHOTP.Location = new Point(237, 94);
            BtnDisableHOTP.Name = "BtnDisableHOTP";
            BtnDisableHOTP.Size = new Size(176, 49);
            BtnDisableHOTP.TabIndex = 1;
            BtnDisableHOTP.Text = "Disable HOTP";
            BtnDisableHOTP.UseVisualStyleBackColor = true;
            BtnDisableHOTP.Click += BtnDisableHOTP_Click;
            // 
            // BtnEnableHOTP
            // 
            BtnEnableHOTP.Anchor = AnchorStyles.Left;
            BtnEnableHOTP.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnEnableHOTP.Location = new Point(3, 94);
            BtnEnableHOTP.Name = "BtnEnableHOTP";
            BtnEnableHOTP.Size = new Size(176, 49);
            BtnEnableHOTP.TabIndex = 0;
            BtnEnableHOTP.Text = "Enable HOTP";
            BtnEnableHOTP.UseVisualStyleBackColor = true;
            BtnEnableHOTP.Click += BtnEnableHOTP_Click;
            // 
            // keyStateLabel
            // 
            keyStateLabel.Anchor = AnchorStyles.Left;
            keyStateLabel.AutoSize = true;
            keyStateLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            keyStateLabel.Location = new Point(3, 158);
            keyStateLabel.Name = "keyStateLabel";
            keyStateLabel.Size = new Size(0, 32);
            keyStateLabel.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Location = new Point(3, 91);
            label1.Name = "label1";
            label1.Size = new Size(189, 15);
            label1.TabIndex = 6;
            label1.Text = "Insert a FortiToken 410 key to start.";
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
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button BtnDisableHOTP;
        private Button BtnEnableHOTP;
        private Label keyStateLabel;
        private Label Title;
        private ListBox listBox1;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
    }
}
