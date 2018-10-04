namespace Click
{
    partial class Click
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
            this.button1 = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalLowerBoundTextBox = new System.Windows.Forms.TextBox();
            this.intervalLowerBoundLabel = new System.Windows.Forms.Label();
            this.intervalUpperBoundLabel = new System.Windows.Forms.Label();
            this.intervalUpperBoundTextBox = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.countTextBox = new System.Windows.Forms.TextBox();
            this.itemAmountTextBox = new System.Windows.Forms.TextBox();
            this.itemAmountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(152, 24);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 22);
            this.yTextBox.TabIndex = 1;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(46, 24);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 22);
            this.xTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "y";
            // 
            // intervalLowerBoundTextBox
            // 
            this.intervalLowerBoundTextBox.Location = new System.Drawing.Point(46, 107);
            this.intervalLowerBoundTextBox.Name = "intervalLowerBoundTextBox";
            this.intervalLowerBoundTextBox.Size = new System.Drawing.Size(100, 22);
            this.intervalLowerBoundTextBox.TabIndex = 5;
            // 
            // intervalLowerBoundLabel
            // 
            this.intervalLowerBoundLabel.AutoSize = true;
            this.intervalLowerBoundLabel.Location = new System.Drawing.Point(43, 78);
            this.intervalLowerBoundLabel.Name = "intervalLowerBoundLabel";
            this.intervalLowerBoundLabel.Size = new System.Drawing.Size(141, 17);
            this.intervalLowerBoundLabel.TabIndex = 6;
            this.intervalLowerBoundLabel.Text = "Interval Lower Bound";
            // 
            // intervalUpperBoundLabel
            // 
            this.intervalUpperBoundLabel.AutoSize = true;
            this.intervalUpperBoundLabel.Location = new System.Drawing.Point(202, 78);
            this.intervalUpperBoundLabel.Name = "intervalUpperBoundLabel";
            this.intervalUpperBoundLabel.Size = new System.Drawing.Size(142, 17);
            this.intervalUpperBoundLabel.TabIndex = 7;
            this.intervalUpperBoundLabel.Text = "Interval Upper Bound";
            // 
            // intervalUpperBoundTextBox
            // 
            this.intervalUpperBoundTextBox.Location = new System.Drawing.Point(205, 107);
            this.intervalUpperBoundTextBox.Name = "intervalUpperBoundTextBox";
            this.intervalUpperBoundTextBox.Size = new System.Drawing.Size(100, 22);
            this.intervalUpperBoundTextBox.TabIndex = 8;
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(327, 169);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 9;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // countButton
            // 
            this.countButton.Location = new System.Drawing.Point(46, 218);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(75, 23);
            this.countButton.TabIndex = 10;
            this.countButton.Text = "Count";
            this.countButton.UseVisualStyleBackColor = true;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // countTextBox
            // 
            this.countTextBox.Location = new System.Drawing.Point(136, 219);
            this.countTextBox.Name = "countTextBox";
            this.countTextBox.Size = new System.Drawing.Size(100, 22);
            this.countTextBox.TabIndex = 11;
            // 
            // itemAmountTextBox
            // 
            this.itemAmountTextBox.Location = new System.Drawing.Point(205, 170);
            this.itemAmountTextBox.Name = "itemAmountTextBox";
            this.itemAmountTextBox.Size = new System.Drawing.Size(100, 22);
            this.itemAmountTextBox.TabIndex = 12;
            // 
            // itemAmountLabel
            // 
            this.itemAmountLabel.AutoSize = true;
            this.itemAmountLabel.Location = new System.Drawing.Point(202, 141);
            this.itemAmountLabel.Name = "itemAmountLabel";
            this.itemAmountLabel.Size = new System.Drawing.Size(86, 17);
            this.itemAmountLabel.TabIndex = 13;
            this.itemAmountLabel.Text = "Item Amount";
            // 
            // Click
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 417);
            this.Controls.Add(this.itemAmountLabel);
            this.Controls.Add(this.itemAmountTextBox);
            this.Controls.Add(this.countTextBox);
            this.Controls.Add(this.countButton);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.intervalUpperBoundTextBox);
            this.Controls.Add(this.intervalUpperBoundLabel);
            this.Controls.Add(this.intervalLowerBoundLabel);
            this.Controls.Add(this.intervalLowerBoundTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Click";
            this.Text = "Click";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox intervalLowerBoundTextBox;
        private System.Windows.Forms.Label intervalLowerBoundLabel;
        private System.Windows.Forms.Label intervalUpperBoundLabel;
        private System.Windows.Forms.TextBox intervalUpperBoundTextBox;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.TextBox countTextBox;
        private System.Windows.Forms.TextBox itemAmountTextBox;
        private System.Windows.Forms.Label itemAmountLabel;
    }
}

