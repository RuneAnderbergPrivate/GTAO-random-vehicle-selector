namespace GTAO_Random_Vehicle_Selector
{
    partial class frm_main
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_newRandomVehicle = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btn_newRandomVehicle
            // 
            this.btn_newRandomVehicle.Location = new System.Drawing.Point(391, 167);
            this.btn_newRandomVehicle.Name = "btn_newRandomVehicle";
            this.btn_newRandomVehicle.Size = new System.Drawing.Size(116, 39);
            this.btn_newRandomVehicle.TabIndex = 1;
            this.btn_newRandomVehicle.Text = "New Random Vehicle";
            this.btn_newRandomVehicle.UseVisualStyleBackColor = true;
            this.btn_newRandomVehicle.Click += new System.EventHandler(this.btn_newRandomVehicle_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(513, 167);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 218);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_newRandomVehicle);
            this.Controls.Add(this.label1);
            this.Name = "frm_main";
            this.Text = "GTAO Random Vehicle Selector";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_newRandomVehicle;
        private System.Windows.Forms.Button button2;
    }
}

