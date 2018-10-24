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
            // Directions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.addDirectionsButton);
            this.Name = "Directions";
            this.Text = "Directions";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addDirectionsButton;
        private System.Windows.Forms.Button goButton;
    }
}