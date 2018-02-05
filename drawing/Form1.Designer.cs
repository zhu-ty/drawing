namespace drawing
{
    partial class FormDrawing
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GenerateB = new System.Windows.Forms.Button();
            this.SaveB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1171, 648);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // GenerateB
            // 
            this.GenerateB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateB.Location = new System.Drawing.Point(1027, 666);
            this.GenerateB.Name = "GenerateB";
            this.GenerateB.Size = new System.Drawing.Size(75, 23);
            this.GenerateB.TabIndex = 1;
            this.GenerateB.Text = "Generate";
            this.GenerateB.UseVisualStyleBackColor = true;
            this.GenerateB.Click += new System.EventHandler(this.GenerateB_Click);
            // 
            // SaveB
            // 
            this.SaveB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveB.Location = new System.Drawing.Point(1108, 666);
            this.SaveB.Name = "SaveB";
            this.SaveB.Size = new System.Drawing.Size(75, 23);
            this.SaveB.TabIndex = 2;
            this.SaveB.Text = "Save";
            this.SaveB.UseVisualStyleBackColor = true;
            this.SaveB.Click += new System.EventHandler(this.SaveB_Click);
            // 
            // FormDrawing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 699);
            this.Controls.Add(this.SaveB);
            this.Controls.Add(this.GenerateB);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormDrawing";
            this.Text = "Drawing";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button GenerateB;
        private System.Windows.Forms.Button SaveB;
    }
}

