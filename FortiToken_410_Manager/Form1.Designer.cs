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
            tableLayoutPanel1 = new TableLayoutPanel();
            HOTPStatusLabel = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            button2 = new Button();
            button1 = new Button();
            Title = new Label();
            keyStateLabel = new Label();
            listBox1 = new ListBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(HOTPStatusLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(Title, 0, 0);
            tableLayoutPanel1.Controls.Add(keyStateLabel, 0, 1);
            tableLayoutPanel1.Controls.Add(listBox1, 0, 4);
            tableLayoutPanel1.Location = new Point(5, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.6564674F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.5702362F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5173855F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.3588314F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45.7579956F));
            tableLayoutPanel1.Size = new Size(998, 719);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // HOTPStatusLabel
            // 
            HOTPStatusLabel.Anchor = AnchorStyles.Left;
            HOTPStatusLabel.AutoSize = true;
            HOTPStatusLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HOTPStatusLabel.Location = new Point(3, 193);
            HOTPStatusLabel.Name = "HOTPStatusLabel";
            HOTPStatusLabel.Size = new Size(103, 37);
            HOTPStatusLabel.TabIndex = 3;
            HOTPStatusLabel.Text = "Status:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.7843666F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.21564F));
            tableLayoutPanel2.Controls.Add(button2, 1, 0);
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 261);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(992, 124);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Left;
            button2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(298, 37);
            button2.Name = "button2";
            button2.Size = new Size(176, 49);
            button2.TabIndex = 1;
            button2.Text = "Disable HOTP";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Left;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 37);
            button1.Name = "button1";
            button1.Size = new Size(176, 49);
            button1.TabIndex = 0;
            button1.Text = "Enable HOTP";
            button1.UseVisualStyleBackColor = true;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Left;
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(3, 27);
            Title.Name = "Title";
            Title.Size = new Size(333, 37);
            Title.TabIndex = 1;
            Title.Text = "FortiToken 410 Manager";
            // 
            // keyStateLabel
            // 
            keyStateLabel.Anchor = AnchorStyles.Left;
            keyStateLabel.AutoSize = true;
            keyStateLabel.Font = new Font("Segoe UI", 12F);
            keyStateLabel.Location = new Point(3, 118);
            keyStateLabel.Name = "keyStateLabel";
            keyStateLabel.Size = new Size(260, 21);
            keyStateLabel.TabIndex = 2;
            keyStateLabel.Text = "Insert a FortiToken 410 Security Key.";
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.BackColor = SystemColors.ControlLight;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.ForeColor = Color.Red;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 392);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(992, 315);
            listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(tableLayoutPanel1);
            MaximizeBox = false;
            MaximumSize = new Size(1024, 768);
            MinimizeBox = false;
            MinimumSize = new Size(1024, 768);
            Name = "Form1";
            Text = "FortiToken 410 Manager";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label Title;
        private Label keyStateLabel;
        private Label HOTPStatusLabel;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}
