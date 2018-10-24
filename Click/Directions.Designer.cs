namespace Click
{
    partial class Directions
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
            this.addDirectionsButton = new System.Windows.Forms.Button();
            this.goButton = new System.Windows.Forms.Button();
            this.getCursorPositionButton = new System.Windows.Forms.Button();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.yLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addDirectionsButton
            // 
            this.addDirectionsButton.Location = new System.Drawing.Point(100, 50);
            this.addDirectionsButton.Name = "addDirectionsButton";
            this.addDirectionsButton.Size = new System.Drawing.Size(116, 23);
            this.addDirectionsButton.TabIndex = 0;
            this.addDirectionsButton.Text = "Add Direction";
            this.addDirectionsButton.UseVisualStyleBackColor = true;
            this.addDirectionsButton.Click += new System.EventHandler(this.addDirectionsButton_Click);
            // 
            // goButton
            // 
            this.goButton.Location = new System.Drawing.Point(100, 347);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(75, 23);
            this.goButton.TabIndex = 1;
            this.goButton.Text = "Go";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.goButton_Click);
            // 
            // getCursorPositionButton
            // 
            this.getCursorPositionButton.Location = new System.Drawing.Point(659, 50);
            this.getCursorPositionButton.Name = "getCursorPositionButton";
            this.getCursorPositionButton.Size = new System.Drawing.Size(99, 44);
            this.getCursorPositionButton.TabIndex = 2;
            this.getCursorPositionButton.Text = "Get cursor position";
            this.getCursorPositionButton.UseVisualStyleBackColor = true;
            this.getCursorPositionButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(688, 132);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 22);
            this.yTextBox.TabIndex = 3;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(582, 132);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 22);
            this.xTextBox.TabIndex = 4;
            // 
            // yLabel
            // 
            this.yLabel.AutoSize = true;
            this.yLabel.Location = new System.Drawing.Point(685, 102);
            this.yLabel.Name = "yLabel";
            this.yLabel.Size = new System.Drawing.Size(17, 17);
            this.yLabel.TabIndex = 5;
            this.yLabel.Text = "Y";
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.Location = new System.Drawing.Point(579, 102);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(17, 17);
            this.xLabel.TabIndex = 6;
            this.xLabel.Text = "X";
            // 
            // Directions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.yLabel);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.getCursorPositionButton);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.addDirectionsButton);
            this.Name = "Directions";
            this.Text = "Directions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDirectionsButton;
        private System.Windows.Forms.Button goButton;
        private System.Windows.Forms.Button getCursorPositionButton;
        private System.Windows.Forms.TextBox yTextBox;
        private System.Windows.Forms.TextBox xTextBox;
        private System.Windows.Forms.Label yLabel;
        private System.Windows.Forms.Label xLabel;
    }
}