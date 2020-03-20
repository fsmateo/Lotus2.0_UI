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
            this.rightB = new System.Windows.Forms.Button();
            this.reverseB = new System.Windows.Forms.Button();
            this.forwardB = new System.Windows.Forms.Button();
            this.leftB = new System.Windows.Forms.Button();
            this.destGB = new System.Windows.Forms.GroupBox();
            this.sendB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lonTB = new System.Windows.Forms.TextBox();
            this.latTB = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.manualConGB.SuspendLayout();
            this.destGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.serialportCB);
            this.groupBox1.Controls.Add(this.connectB);
            this.groupBox1.Location = new System.Drawing.Point(24, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(358, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serial Connection";
            // 
            // serialportCB
            // 
            this.serialportCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.serialportCB.FormattingEnabled = true;
            this.serialportCB.Location = new System.Drawing.Point(186, 38);
            this.serialportCB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.serialportCB.Name = "serialportCB";
            this.serialportCB.Size = new System.Drawing.Size(156, 33);
            this.serialportCB.TabIndex = 1;
            // 
            // connectB
            // 
            this.connectB.Location = new System.Drawing.Point(12, 37);
            this.connectB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.connectB.Name = "connectB";
            this.connectB.Size = new System.Drawing.Size(160, 44);
            this.connectB.TabIndex = 0;
            this.connectB.Text = "Connect";
            this.connectB.UseVisualStyleBackColor = true;
            this.connectB.Click += new System.EventHandler(this.connectB_Click);
            // 
            // manualConGB
            // 
            this.manualConGB.Controls.Add(this.rightB);
            this.manualConGB.Controls.Add(this.reverseB);
            this.manualConGB.Controls.Add(this.forwardB);
            this.manualConGB.Controls.Add(this.leftB);
            this.manualConGB.Location = new System.Drawing.Point(24, 365);
            this.manualConGB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.manualConGB.Name = "manualConGB";
            this.manualConGB.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.manualConGB.Size = new System.Drawing.Size(358, 244);
            this.manualConGB.TabIndex = 1;
            this.manualConGB.TabStop = false;
            this.manualConGB.Text = "Manual Control";
            // 
            // rightB
            // 
            this.rightB.Location = new System.Drawing.Point(236, 112);
            this.rightB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rightB.Name = "rightB";
            this.rightB.Size = new System.Drawing.Size(110, 48);
            this.rightB.TabIndex = 3;
            this.rightB.Text = "Right";
            this.rightB.UseVisualStyleBackColor = true;
            this.rightB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.rightB_KeyDown);
            // 
            // reverseB
            // 
            this.reverseB.Location = new System.Drawing.Point(126, 185);
            this.reverseB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.reverseB.Name = "reverseB";
            this.reverseB.Size = new System.Drawing.Size(110, 48);
            this.reverseB.TabIndex = 1;
            this.reverseB.Text = "Reverse";
            this.reverseB.UseVisualStyleBackColor = true;
            this.reverseB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.reverseB_KeyDown);
            // 
            // forwardB
            // 
            this.forwardB.Location = new System.Drawing.Point(126, 37);
            this.forwardB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.forwardB.Name = "forwardB";
            this.forwardB.Size = new System.Drawing.Size(110, 48);
            this.forwardB.TabIndex = 0;
            this.forwardB.Text = "Forward";
            this.forwardB.UseVisualStyleBackColor = true;
            this.forwardB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.forwardB_KeyDown);
            // 
            // leftB
            // 
            this.leftB.Location = new System.Drawing.Point(12, 112);
            this.leftB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.leftB.Name = "leftB";
            this.leftB.Size = new System.Drawing.Size(110, 48);
            this.leftB.TabIndex = 2;
            this.leftB.Text = "Left";
            this.leftB.UseVisualStyleBackColor = true;
            this.leftB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.leftB_KeyDown);
            // 
            // destGB
            // 
            this.destGB.Controls.Add(this.sendB);
            this.destGB.Controls.Add(this.label2);
            this.destGB.Controls.Add(this.label1);
            this.destGB.Controls.Add(this.lonTB);
            this.destGB.Controls.Add(this.latTB);
            this.destGB.Location = new System.Drawing.Point(24, 137);
            this.destGB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.destGB.Name = "destGB";
            this.destGB.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.destGB.Size = new System.Drawing.Size(358, 217);
            this.destGB.TabIndex = 2;
            this.destGB.TabStop = false;
            this.destGB.Text = "Destination";
            // 
            // sendB
            // 
            this.sendB.Location = new System.Drawing.Point(20, 137);
            this.sendB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.sendB.Name = "sendB";
            this.sendB.Size = new System.Drawing.Size(150, 44);
            this.sendB.TabIndex = 4;
            this.sendB.Text = "Send";
            this.sendB.UseVisualStyleBackColor = true;
            this.sendB.Click += new System.EventHandler(this.sendB_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 92);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Longitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Latitude";
            // 
            // lonTB
            // 
            this.lonTB.Location = new System.Drawing.Point(126, 87);
            this.lonTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lonTB.Name = "lonTB";
            this.lonTB.Size = new System.Drawing.Size(196, 31);
            this.lonTB.TabIndex = 1;
            // 
            // latTB
            // 
            this.latTB.Location = new System.Drawing.Point(126, 37);
            this.latTB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.latTB.Name = "latTB";
            this.latTB.Size = new System.Drawing.Size(196, 31);
            this.latTB.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1108, 633);
            this.Controls.Add(this.destGB);
            this.Controls.Add(this.manualConGB);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Lotus 2.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.manualConGB.ResumeLayout(false);
            this.destGB.ResumeLayout(false);
            this.destGB.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox latTB;
        private System.Windows.Forms.TextBox lonTB;
        private System.Windows.Forms.Button sendB;
    }
}

