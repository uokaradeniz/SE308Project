namespace SE308Project
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
            btnStartSim = new Button();
            lblUserA = new Label();
            lblUserB = new Label();
            lblUserBCounter = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            btnQuit = new Button();
            numUserA = new NumericUpDown();
            numUserB = new NumericUpDown();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)numUserA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUserB).BeginInit();
            SuspendLayout();
            // 
            // btnStartSim
            // 
            btnStartSim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartSim.Location = new Point(107, 214);
            btnStartSim.Name = "btnStartSim";
            btnStartSim.Size = new Size(135, 54);
            btnStartSim.TabIndex = 0;
            btnStartSim.Text = "Start Simulation";
            btnStartSim.UseVisualStyleBackColor = true;
            btnStartSim.Click += btnStartSim_Click;
            // 
            // lblUserA
            // 
            lblUserA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUserA.AutoSize = true;
            lblUserA.Location = new Point(43, 116);
            lblUserA.Name = "lblUserA";
            lblUserA.Size = new Size(120, 20);
            lblUserA.TabIndex = 1;
            lblUserA.Text = "User A (Updater)";
            // 
            // lblUserB
            // 
            lblUserB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUserB.AutoSize = true;
            lblUserB.Location = new Point(204, 116);
            lblUserB.Name = "lblUserB";
            lblUserB.Size = new Size(119, 20);
            lblUserB.TabIndex = 2;
            lblUserB.Text = "User B (Selector)";
            // 
            // lblUserBCounter
            // 
            lblUserBCounter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblUserBCounter.AutoSize = true;
            lblUserBCounter.Location = new Point(107, 280);
            lblUserBCounter.Name = "lblUserBCounter";
            lblUserBCounter.Size = new Size(135, 20);
            lblUserBCounter.TabIndex = 5;
            lblUserBCounter.Text = "Elapsed Time: NaN";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Location = new Point(107, 22);
            label3.Name = "label3";
            label3.Size = new Size(171, 20);
            label3.TabIndex = 6;
            label3.Text = "Select an Isolation Level:";
            // 
            // comboBox1
            // 
            comboBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "READ UNCOMMITTED", "READ COMMITTED", "REPEATABLE READ", "SERIALIZABLE" });
            comboBox1.Location = new Point(83, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(212, 28);
            comboBox1.TabIndex = 7;
            // 
            // btnQuit
            // 
            btnQuit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnQuit.Location = new Point(23, 303);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(73, 33);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += btnQuit_Click;
            // 
            // numUserA
            // 
            numUserA.Location = new Point(43, 154);
            numUserA.Name = "numUserA";
            numUserA.Size = new Size(120, 27);
            numUserA.TabIndex = 9;
            // 
            // numUserB
            // 
            numUserB.Location = new Point(204, 154);
            numUserB.Name = "numUserB";
            numUserB.Size = new Size(119, 27);
            numUserB.TabIndex = 10;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(362, 57);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(423, 243);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "Deadlock Occured!\nDeadlock Occured!\nDeadlock Occured!\nDeadlock Occured!\nDeadlock Occured!\nDeadlock Occured!\n\n\n";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(372, 34);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 12;
            label1.Text = "Event Log";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 348);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(numUserB);
            Controls.Add(numUserA);
            Controls.Add(btnQuit);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(lblUserBCounter);
            Controls.Add(lblUserB);
            Controls.Add(lblUserA);
            Controls.Add(btnStartSim);
            Name = "Form1";
            Text = "Transaction Sim";
            ((System.ComponentModel.ISupportInitialize)numUserA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUserB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartSim;
        private Label lblUserA;
        private Label lblUserB;
        private Label lblUserBCounter;
        private Label label3;
        private ComboBox comboBox1;
        private Button btnQuit;
        private NumericUpDown numUserA;
        private NumericUpDown numUserB;
        private RichTextBox richTextBox1;
        private Label label1;
    }
}
