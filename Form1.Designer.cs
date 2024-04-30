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
            button3 = new Button();
            numUserA = new NumericUpDown();
            numUserB = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numUserA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numUserB).BeginInit();
            SuspendLayout();
            // 
            // btnStartSim
            // 
            btnStartSim.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnStartSim.Location = new Point(132, 214);
            btnStartSim.Name = "btnStartSim";
            btnStartSim.Size = new Size(94, 54);
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
            comboBox1.Location = new Point(75, 57);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(229, 28);
            comboBox1.TabIndex = 7;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(262, 303);
            button3.Name = "button3";
            button3.Size = new Size(94, 33);
            button3.TabIndex = 8;
            button3.Text = "Quit";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 348);
            Controls.Add(numUserB);
            Controls.Add(numUserA);
            Controls.Add(button3);
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
        private Button button3;
        private NumericUpDown numUserA;
        private NumericUpDown numUserB;
    }
}
