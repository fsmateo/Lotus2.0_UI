namespace LotusUI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.serialportCB = new System.Windows.Forms.ComboBox();
            this.connectB = new System.Windows.Forms.Button();
            this.manualConGB = new System.Windows.Forms.GroupBox();
            this.manualControlButton = new System.Windows.Forms.Button();
            this.rightB = new System.Windows.Forms.Button();
            this.reverseB = new System.Windows.Forms.Button();
            this.forwardB = new System.Windows.Forms.Button();
            this.leftB = new System.Windows.Forms.Button();
            this.destGB = new System.Windows.Forms.GroupBox();
            this.sendCoordinateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coordinateTextBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.databaseGB = new System.Windows.Forms.GroupBox();
            this.simulateB = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.manualConGB.SuspendLayout();
            this.destGB.SuspendLayout();
            this.databaseGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serialportCB);
            this.groupBox1.Controls.Add(this.connectB);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(268, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection";
            // 
            // serialportCB
            // 
            this.serialportCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialportCB.FormattingEnabled = true;
            this.serialportCB.Location = new System.Drawing.Point(140, 31);
            this.serialportCB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serialportCB.Name = "serialportCB";
            this.serialportCB.Size = new System.Drawing.Size(118, 28);
            this.serialportCB.TabIndex = 1;
            this.serialportCB.TabStop = false;
            // 
            // connectB
            // 
            this.connectB.Location = new System.Drawing.Point(9, 29);
            this.connectB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.connectB.Name = "connectB";
            this.connectB.Size = new System.Drawing.Size(120, 35);
            this.connectB.TabIndex = 0;
            this.connectB.TabStop = false;
            this.connectB.Text = "Connect";
            this.connectB.UseVisualStyleBackColor = true;
            this.connectB.Click += new System.EventHandler(this.connectB_Click);
            // 
            // manualConGB
            // 
            this.manualConGB.Controls.Add(this.manualControlButton);
            this.manualConGB.Controls.Add(this.rightB);
            this.manualConGB.Controls.Add(this.reverseB);
            this.manualConGB.Controls.Add(this.forwardB);
            this.manualConGB.Controls.Add(this.leftB);
            this.manualConGB.Location = new System.Drawing.Point(18, 251);
            this.manualConGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manualConGB.Name = "manualConGB";
            this.manualConGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manualConGB.Size = new System.Drawing.Size(268, 192);
            this.manualConGB.TabIndex = 1;
            this.manualConGB.TabStop = false;
            this.manualConGB.Text = "Manual Control";
            // 
            // manualControlButton
            // 
            this.manualControlButton.Location = new System.Drawing.Point(15, 31);
            this.manualControlButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manualControlButton.Name = "manualControlButton";
            this.manualControlButton.Size = new System.Drawing.Size(244, 35);
            this.manualControlButton.TabIndex = 4;
            this.manualControlButton.TabStop = false;
            this.manualControlButton.Text = "Enable Manual Control";
            this.manualControlButton.UseVisualStyleBackColor = true;
            // 
            // rightB
            // 
            this.rightB.Location = new System.Drawing.Point(162, 105);
            this.rightB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rightB.Name = "rightB";
            this.rightB.Size = new System.Drawing.Size(45, 46);
            this.rightB.TabIndex = 3;
            this.rightB.TabStop = false;
            this.rightB.Text = "→";
            this.rightB.UseVisualStyleBackColor = true;
            this.rightB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightB_KeyDown);
            // 
            // reverseB
            // 
            this.reverseB.Location = new System.Drawing.Point(108, 137);
            this.reverseB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reverseB.Name = "reverseB";
            this.reverseB.Size = new System.Drawing.Size(45, 46);
            this.reverseB.TabIndex = 1;
            this.reverseB.TabStop = false;
            this.reverseB.Text = "↓";
            this.reverseB.UseVisualStyleBackColor = true;
            this.reverseB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reverseB_KeyDown);
            // 
            // forwardB
            // 
            this.forwardB.Location = new System.Drawing.Point(108, 75);
            this.forwardB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forwardB.Name = "forwardB";
            this.forwardB.Size = new System.Drawing.Size(45, 46);
            this.forwardB.TabIndex = 0;
            this.forwardB.TabStop = false;
            this.forwardB.Text = "↑";
            this.forwardB.UseVisualStyleBackColor = true;
            this.forwardB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.forwardB_KeyDown);
            // 
            // leftB
            // 
            this.leftB.Location = new System.Drawing.Point(54, 105);
            this.leftB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.leftB.Name = "leftB";
            this.leftB.Size = new System.Drawing.Size(45, 46);
            this.leftB.TabIndex = 2;
            this.leftB.TabStop = false;
            this.leftB.Text = "←";
            this.leftB.UseVisualStyleBackColor = true;
            this.leftB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leftB_KeyDown);
            // 
            // destGB
            // 
            this.destGB.Controls.Add(this.sendCoordinateButton);
            this.destGB.Controls.Add(this.label1);
            this.destGB.Controls.Add(this.coordinateTextBox);
            this.destGB.Location = new System.Drawing.Point(18, 109);
            this.destGB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destGB.Name = "destGB";
            this.destGB.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.destGB.Size = new System.Drawing.Size(268, 132);
            this.destGB.TabIndex = 2;
            this.destGB.TabStop = false;
            this.destGB.Text = "Destination";
            // 
            // sendCoordinateButton
            // 
            this.sendCoordinateButton.Location = new System.Drawing.Point(15, 89);
            this.sendCoordinateButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sendCoordinateButton.Name = "sendCoordinateButton";
            this.sendCoordinateButton.Size = new System.Drawing.Size(112, 35);
            this.sendCoordinateButton.TabIndex = 4;
            this.sendCoordinateButton.TabStop = false;
            this.sendCoordinateButton.Text = "Send";
            this.sendCoordinateButton.UseVisualStyleBackColor = true;
            this.sendCoordinateButton.Click += new System.EventHandler(this.sendB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude,Longitude";
            // 
            // coordinateTextBox
            // 
            this.coordinateTextBox.Location = new System.Drawing.Point(15, 49);
            this.coordinateTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.coordinateTextBox.Name = "coordinateTextBox";
            this.coordinateTextBox.Size = new System.Drawing.Size(242, 26);
            this.coordinateTextBox.TabIndex = 0;
            this.coordinateTextBox.TabStop = false;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(54, 88);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(56, 20);
            this.databaseLabel.TabIndex = 2;
            this.databaseLabel.Text = "Status";
            this.databaseLabel.Visible = false;
            this.databaseLabel.Click += new System.EventHandler(this.databaseLabel_Click);
            // 
            // databaseGB
            // 
            this.databaseGB.Controls.Add(this.simulateB);
            this.databaseGB.Controls.Add(this.databaseLabel);
            this.databaseGB.Location = new System.Drawing.Point(409, 282);
            this.databaseGB.Name = "databaseGB";
            this.databaseGB.Size = new System.Drawing.Size(286, 138);
            this.databaseGB.TabIndex = 3;
            this.databaseGB.TabStop = false;
            this.databaseGB.Text = "Database";
            // 
            // simulateB
            // 
            this.simulateB.Location = new System.Drawing.Point(45, 31);
            this.simulateB.Name = "simulateB";
            this.simulateB.Size = new System.Drawing.Size(204, 41);
            this.simulateB.TabIndex = 3;
            this.simulateB.Text = "Simulate Receive String";
            this.simulateB.UseVisualStyleBackColor = true;
            this.simulateB.Click += new System.EventHandler(this.simulateB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(831, 449);
            this.Controls.Add(this.databaseGB);
            this.Controls.Add(this.destGB);
            this.Controls.Add(this.manualConGB);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Lotus 2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.manualConGB.ResumeLayout(false);
            this.destGB.ResumeLayout(false);
            this.destGB.PerformLayout();
            this.databaseGB.ResumeLayout(false);
            this.databaseGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox serialportCB;
        private System.Windows.Forms.Button connectB;
        private System.Windows.Forms.GroupBox manualConGB;
        private System.Windows.Forms.Button rightB;
        private System.Windows.Forms.Button reverseB;
        private System.Windows.Forms.Button forwardB;
        private System.Windows.Forms.Button leftB;
        private System.Windows.Forms.GroupBox destGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coordinateTextBox;
        private System.Windows.Forms.Button sendCoordinateButton;
        private System.Windows.Forms.Button manualControlButton;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.GroupBox databaseGB;
        private System.Windows.Forms.Button simulateB;
    }
}

