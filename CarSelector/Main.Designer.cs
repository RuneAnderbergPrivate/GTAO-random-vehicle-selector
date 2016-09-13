namespace CarSelector
{
    partial class frmMain
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
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnNewRand = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbOutput
            // 
            this.rtbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rtbOutput.Location = new System.Drawing.Point(12, 12);
            this.rtbOutput.Margin = new System.Windows.Forms.Padding(4);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(360, 60);
            this.rtbOutput.TabIndex = 0;
            this.rtbOutput.Text = "";
            // 
            // btnNewRand
            // 
            this.btnNewRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNewRand.Location = new System.Drawing.Point(12, 78);
            this.btnNewRand.Name = "btnNewRand";
            this.btnNewRand.Size = new System.Drawing.Size(177, 40);
            this.btnNewRand.TabIndex = 1;
            this.btnNewRand.Text = "New Random Vehicle";
            this.btnNewRand.UseVisualStyleBackColor = true;
            this.btnNewRand.Click += new System.EventHandler(this.btnNewRand_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(195, 78);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(177, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 131);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewRand);
            this.Controls.Add(this.rtbOutput);
            this.Name = "frmMain";
            this.Text = "Random Vehicle Selector";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnNewRand;
        private System.Windows.Forms.Button btnExit;
    }
}

