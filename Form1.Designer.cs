namespace Text_Analyzer
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
            btnanalye = new Button();
            btnclear = new Button();
            richTextBox1 = new RichTextBox();
            listBox1 = new ListBox();
            lblword = new Label();
            lblcharcount = new Label();
            lblfrequent = new Label();
            SuspendLayout();
            // 
            // btnanalye
            // 
            btnanalye.Location = new Point(77, 210);
            btnanalye.Name = "btnanalye";
            btnanalye.Size = new Size(118, 29);
            btnanalye.TabIndex = 0;
            btnanalye.Text = "Text_analyze";
            btnanalye.UseVisualStyleBackColor = true;
            btnanalye.Click += btnanalye_Click;
            // 
            // btnclear
            // 
            btnclear.Location = new Point(215, 210);
            btnclear.Name = "btnclear";
            btnclear.Size = new Size(94, 29);
            btnclear.TabIndex = 1;
            btnclear.Text = "Clear";
            btnclear.UseVisualStyleBackColor = true;
            btnclear.Click += btnclear_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(34, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(642, 183);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(34, 387);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(641, 224);
            listBox1.TabIndex = 3;
            // 
            // lblword
            // 
            lblword.AutoSize = true;
            lblword.BackColor = Color.Cornsilk;
            lblword.Location = new Point(77, 256);
            lblword.Name = "lblword";
            lblword.Size = new Size(91, 20);
            lblword.TabIndex = 4;
            lblword.Text = "Word_count:";
            // 
            // lblcharcount
            // 
            lblcharcount.AutoSize = true;
            lblcharcount.BackColor = Color.Cornsilk;
            lblcharcount.Location = new Point(77, 295);
            lblcharcount.Name = "lblcharcount";
            lblcharcount.Size = new Size(110, 20);
            lblcharcount.TabIndex = 5;
            lblcharcount.Text = "Charcter_count:";
            // 
            // lblfrequent
            // 
            lblfrequent.AutoSize = true;
            lblfrequent.BackColor = Color.OldLace;
            lblfrequent.Location = new Point(77, 340);
            lblfrequent.Name = "lblfrequent";
            lblfrequent.Size = new Size(153, 20);
            lblfrequent.TabIndex = 6;
            lblfrequent.Text = "Frequent_word_count:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(747, 576);
            Controls.Add(lblfrequent);
            Controls.Add(lblcharcount);
            Controls.Add(lblword);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(btnclear);
            Controls.Add(btnanalye);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TEXT_ANALYZER";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnanalye;
        private Button btnclear;
        private RichTextBox richTextBox1;
        private ListBox listBox1;
        private Label lblword;
        private Label lblcharcount;
        private Label lblfrequent;
    }
}
