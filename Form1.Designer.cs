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
            components = new System.ComponentModel.Container();
            btnStartSim = new Button();
            lblUserA = new Label();
            lblUserB = new Label();
            label3 = new Label();
            cmb_Isolation = new ComboBox();
            btnQuit = new Button();
            numUserA = new NumericUpDown();
            numUserB = new NumericUpDown();
            txt_EventLog = new RichTextBox();
            label1 = new Label();
            timer = new System.Windows.Forms.Timer(components);
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
            // cmb_Isolation
            // 
            cmb_Isolation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmb_Isolation.FormattingEnabled = true;
            cmb_Isolation.Items.AddRange(new object[] { "READ UNCOMMITTED", "READ COMMITTED", "REPEATABLE READ", "SERIALIZABLE" });
            cmb_Isolation.Location = new Point(83, 57);
            cmb_Isolation.Name = "cmb_Isolation";
            cmb_Isolation.Size = new Size(212, 28);
            cmb_Isolation.TabIndex = 7;
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
            numUserA.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numUserA.Name = "numUserA";
            numUserA.Size = new Size(120, 27);
            numUserA.TabIndex = 9;
            // 
            // numUserB
            // 
            numUserB.Location = new Point(204, 154);
            numUserB.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numUserB.Name = "numUserB";
            numUserB.Size = new Size(119, 27);
            numUserB.TabIndex = 10;
            // 
            // txt_EventLog
            // 
            txt_EventLog.BackColor = SystemColors.ButtonHighlight;
            txt_EventLog.Location = new Point(362, 57);
            txt_EventLog.Name = "txt_EventLog";
            txt_EventLog.ReadOnly = true;
            txt_EventLog.Size = new Size(423, 243);
            txt_EventLog.TabIndex = 11;
            txt_EventLog.Text = "Ready!\n";
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
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 3001;
            timer.Tick += timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 348);
            Controls.Add(label1);
            Controls.Add(txt_EventLog);
            Controls.Add(numUserB);
            Controls.Add(numUserA);
            Controls.Add(btnQuit);
            Controls.Add(cmb_Isolation);
            Controls.Add(label3);
            Controls.Add(lblUserB);
            Controls.Add(lblUserA);
            Controls.Add(btnStartSim);
            Name = "Form1";
            Text = "Transaction Simulation";
            ((System.ComponentModel.ISupportInitialize)numUserA).EndInit();
            ((System.ComponentModel.ISupportInitialize)numUserB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartSim;
        private Label lblUserA;
        private Label lblUserB;
        private Label label3;
        private ComboBox cmb_Isolation;
        private Button btnQuit;
        private NumericUpDown numUserA;
        private NumericUpDown numUserB;
        private RichTextBox txt_EventLog;
        private Label label1;
        private System.Windows.Forms.Timer timer;
    }
}
