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
            this.rightButton = new System.Windows.Forms.Button();
            this.reverseButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.destGB = new System.Windows.Forms.GroupBox();
            this.sendCoordinateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.coordinateTextBox = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.databaseGB = new System.Windows.Forms.GroupBox();
            this.connectDBB = new System.Windows.Forms.Button();
            this.simulateB = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(179, 53);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection";
            // 
            // serialportCB
            // 
            this.serialportCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialportCB.FormattingEnabled = true;
            this.serialportCB.Location = new System.Drawing.Point(93, 20);
            this.serialportCB.Name = "serialportCB";
            this.serialportCB.Size = new System.Drawing.Size(80, 21);
            this.serialportCB.TabIndex = 1;
            this.serialportCB.TabStop = false;
            // 
            // connectB
            // 
            this.connectB.Location = new System.Drawing.Point(6, 19);
            this.connectB.Name = "connectB";
            this.connectB.Size = new System.Drawing.Size(80, 23);
            this.connectB.TabIndex = 0;
            this.connectB.TabStop = false;
            this.connectB.Text = "Connect";
            this.connectB.UseVisualStyleBackColor = true;
            this.connectB.Click += new System.EventHandler(this.connectB_Click);
            // 
            // manualConGB
            // 
            this.manualConGB.Controls.Add(this.manualControlButton);
            this.manualConGB.Controls.Add(this.rightButton);
            this.manualConGB.Controls.Add(this.reverseButton);
            this.manualConGB.Controls.Add(this.forwardButton);
            this.manualConGB.Controls.Add(this.leftButton);
            this.manualConGB.Location = new System.Drawing.Point(12, 163);
            this.manualConGB.Name = "manualConGB";
            this.manualConGB.Size = new System.Drawing.Size(179, 123);
            this.manualConGB.TabIndex = 1;
            this.manualConGB.TabStop = false;
            this.manualConGB.Text = "Manual Control";
            // 
            // manualControlButton
            // 
            this.manualControlButton.Location = new System.Drawing.Point(10, 20);
            this.manualControlButton.Name = "manualControlButton";
            this.manualControlButton.Size = new System.Drawing.Size(163, 23);
            this.manualControlButton.TabIndex = 4;
            this.manualControlButton.TabStop = false;
            this.manualControlButton.Text = "Enable Manual Control";
            this.manualControlButton.UseVisualStyleBackColor = true;
            this.manualControlButton.Click += new System.EventHandler(this.manualControlButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.BackColor = System.Drawing.SystemColors.Control;
            this.rightButton.Location = new System.Drawing.Point(108, 68);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(30, 30);
            this.rightButton.TabIndex = 3;
            this.rightButton.TabStop = false;
            this.rightButton.Text = "D";
            this.rightButton.UseVisualStyleBackColor = false;
            // 
            // reverseButton
            // 
            this.reverseButton.BackColor = System.Drawing.SystemColors.Control;
            this.reverseButton.Location = new System.Drawing.Point(72, 89);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(30, 30);
            this.reverseButton.TabIndex = 1;
            this.reverseButton.TabStop = false;
            this.reverseButton.Text = "S";
            this.reverseButton.UseVisualStyleBackColor = false;
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.SystemColors.Control;
            this.forwardButton.Location = new System.Drawing.Point(72, 49);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(30, 30);
            this.forwardButton.TabIndex = 0;
            this.forwardButton.TabStop = false;
            this.forwardButton.Text = "W";
            this.forwardButton.UseVisualStyleBackColor = false;
            // 
            // leftButton
            // 
            this.leftButton.BackColor = System.Drawing.SystemColors.Control;
            this.leftButton.Location = new System.Drawing.Point(36, 68);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(30, 30);
            this.leftButton.TabIndex = 2;
            this.leftButton.TabStop = false;
            this.leftButton.Text = "A";
            this.leftButton.UseVisualStyleBackColor = false;
            // 
            // destGB
            // 
            this.destGB.Controls.Add(this.sendCoordinateButton);
            this.destGB.Controls.Add(this.label1);
            this.destGB.Controls.Add(this.coordinateTextBox);
            this.destGB.Location = new System.Drawing.Point(12, 71);
            this.destGB.Name = "destGB";
            this.destGB.Size = new System.Drawing.Size(179, 86);
            this.destGB.TabIndex = 2;
            this.destGB.TabStop = false;
            this.destGB.Text = "Destination";
            // 
            // sendCoordinateButton
            // 
            this.sendCoordinateButton.Location = new System.Drawing.Point(10, 58);
            this.sendCoordinateButton.Name = "sendCoordinateButton";
            this.sendCoordinateButton.Size = new System.Drawing.Size(75, 23);
            this.sendCoordinateButton.TabIndex = 4;
            this.sendCoordinateButton.TabStop = false;
            this.sendCoordinateButton.Text = "Send";
            this.sendCoordinateButton.UseVisualStyleBackColor = true;
            this.sendCoordinateButton.Click += new System.EventHandler(this.sendB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude,Longitude";
            // 
            // coordinateTextBox
            // 
            this.coordinateTextBox.Location = new System.Drawing.Point(10, 32);
            this.coordinateTextBox.Name = "coordinateTextBox";
            this.coordinateTextBox.Size = new System.Drawing.Size(163, 20);
            this.coordinateTextBox.TabIndex = 0;
            this.coordinateTextBox.TabStop = false;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(25, 89);
            this.databaseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(37, 13);
            this.databaseLabel.TabIndex = 2;
            this.databaseLabel.Text = "Status";
            this.databaseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.databaseLabel.Visible = false;
            // 
            // databaseGB
            // 
            this.databaseGB.Controls.Add(this.connectDBB);
            this.databaseGB.Controls.Add(this.simulateB);
            this.databaseGB.Controls.Add(this.databaseLabel);
            this.databaseGB.Location = new System.Drawing.Point(282, 12);
            this.databaseGB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseGB.Name = "databaseGB";
            this.databaseGB.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.databaseGB.Size = new System.Drawing.Size(191, 116);
            this.databaseGB.TabIndex = 3;
            this.databaseGB.TabStop = false;
            this.databaseGB.Text = "Database";
            // 
            // connectDBB
            // 
            this.connectDBB.Location = new System.Drawing.Point(49, 20);
            this.connectDBB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.connectDBB.Name = "connectDBB";
            this.connectDBB.Size = new System.Drawing.Size(93, 25);
            this.connectDBB.TabIndex = 4;
            this.connectDBB.Text = "Connect";
            this.connectDBB.UseVisualStyleBackColor = true;
            this.connectDBB.Click += new System.EventHandler(this.connectDBB_Click);
            // 
            // simulateB
            // 
            this.simulateB.Location = new System.Drawing.Point(27, 55);
            this.simulateB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.simulateB.Name = "simulateB";
            this.simulateB.Size = new System.Drawing.Size(136, 27);
            this.simulateB.TabIndex = 3;
            this.simulateB.Text = "Simulate Receive String";
            this.simulateB.UseVisualStyleBackColor = true;
            this.simulateB.Click += new System.EventHandler(this.simulateB_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(197, 133);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(345, 153);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(554, 294);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.databaseGB);
            this.Controls.Add(this.destGB);
            this.Controls.Add(this.manualConGB);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Lotus 2.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
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
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.GroupBox destGB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coordinateTextBox;
        private System.Windows.Forms.Button sendCoordinateButton;
        private System.Windows.Forms.Button manualControlButton;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.GroupBox databaseGB;
        private System.Windows.Forms.Button simulateB;
        private System.Windows.Forms.Button connectDBB;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

