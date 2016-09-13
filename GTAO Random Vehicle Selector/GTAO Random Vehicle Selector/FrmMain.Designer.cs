namespace GTAO_Random_Vehicle_Selector
{
    partial class FrmMain
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
            this.lbl_rndVehicle = new System.Windows.Forms.Label();
            this.btn_NewRandomVehicle = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_rndVehicle
            // 
            this.lbl_rndVehicle.AutoSize = true;
            this.lbl_rndVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbl_rndVehicle.Location = new System.Drawing.Point(12, 9);
            this.lbl_rndVehicle.Name = "lbl_rndVehicle";
            this.lbl_rndVehicle.Size = new System.Drawing.Size(0, 20);
            this.lbl_rndVehicle.TabIndex = 0;
            // 
            // btn_NewRandomVehicle
            // 
            this.btn_NewRandomVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_NewRandomVehicle.Location = new System.Drawing.Point(97, 60);
            this.btn_NewRandomVehicle.Name = "btn_NewRandomVehicle";
            this.btn_NewRandomVehicle.Size = new System.Drawing.Size(203, 39);
            this.btn_NewRandomVehicle.TabIndex = 1;
            this.btn_NewRandomVehicle.Text = "New Random Vehicle";
            this.btn_NewRandomVehicle.UseVisualStyleBackColor = true;
            this.btn_NewRandomVehicle.Click += new System.EventHandler(this.btn_NewRandomVehicle_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(306, 60);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(116, 39);
            this.btn_Exit.TabIndex = 2;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 111);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_NewRandomVehicle);
            this.Controls.Add(this.lbl_rndVehicle);
            this.Name = "FrmMain";
            this.Text = "GTAO Random Vehicle Selector";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_rndVehicle;
        private System.Windows.Forms.Button btn_NewRandomVehicle;
        private System.Windows.Forms.Button btn_Exit;
    }
}

