namespace VP_Proekt
{
    partial class Ulica
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
            this.labeltime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.BackColor = System.Drawing.Color.Transparent;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labeltime.Location = new System.Drawing.Point(580, 22);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(70, 25);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "label1";
            // 
            // Ulica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltime);
            this.Name = "Ulica";
            this.Text = "Ulica";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Ulica_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Ulica_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltime;
    }
}