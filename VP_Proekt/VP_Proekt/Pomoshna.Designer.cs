namespace VP_Proekt
{
    partial class Pomoshna
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
            this.labelUspeshno = new System.Windows.Forms.Label();
            this.labelBravo = new System.Windows.Forms.Label();
            this.labelObidPovtorno = new System.Windows.Forms.Label();
            this.buttonDa = new System.Windows.Forms.Button();
            this.buttonNe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUspeshno
            // 
            this.labelUspeshno.AutoSize = true;
            this.labelUspeshno.BackColor = System.Drawing.Color.White;
            this.labelUspeshno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUspeshno.ForeColor = System.Drawing.Color.Violet;
            this.labelUspeshno.Location = new System.Drawing.Point(410, 346);
            this.labelUspeshno.Name = "labelUspeshno";
            this.labelUspeshno.Size = new System.Drawing.Size(111, 18);
            this.labelUspeshno.TabIndex = 0;
            this.labelUspeshno.Text = "LabelUspeshno";
            // 
            // labelBravo
            // 
            this.labelBravo.AutoSize = true;
            this.labelBravo.BackColor = System.Drawing.Color.White;
            this.labelBravo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBravo.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelBravo.Location = new System.Drawing.Point(670, 396);
            this.labelBravo.Name = "labelBravo";
            this.labelBravo.Size = new System.Drawing.Size(73, 25);
            this.labelBravo.TabIndex = 1;
            this.labelBravo.Text = "Bravo";
            // 
            // labelObidPovtorno
            // 
            this.labelObidPovtorno.AllowDrop = true;
            this.labelObidPovtorno.AutoSize = true;
            this.labelObidPovtorno.BackColor = System.Drawing.Color.White;
            this.labelObidPovtorno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelObidPovtorno.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.labelObidPovtorno.Location = new System.Drawing.Point(485, 296);
            this.labelObidPovtorno.Name = "labelObidPovtorno";
            this.labelObidPovtorno.Size = new System.Drawing.Size(130, 18);
            this.labelObidPovtorno.TabIndex = 2;
            this.labelObidPovtorno.Text = "labelObidPovtorno";
            // 
            // buttonDa
            // 
            this.buttonDa.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDa.Location = new System.Drawing.Point(403, 400);
            this.buttonDa.Name = "buttonDa";
            this.buttonDa.Size = new System.Drawing.Size(75, 23);
            this.buttonDa.TabIndex = 3;
            this.buttonDa.UseVisualStyleBackColor = false;
            this.buttonDa.Click += new System.EventHandler(this.buttonDa_Click);
            // 
            // buttonNe
            // 
            this.buttonNe.BackColor = System.Drawing.Color.YellowGreen;
            this.buttonNe.Location = new System.Drawing.Point(533, 402);
            this.buttonNe.Name = "buttonNe";
            this.buttonNe.Size = new System.Drawing.Size(75, 23);
            this.buttonNe.TabIndex = 4;
            this.buttonNe.UseVisualStyleBackColor = false;
            this.buttonNe.Click += new System.EventHandler(this.buttonNe_Click);
            // 
            // Pomoshna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonNe);
            this.Controls.Add(this.buttonDa);
            this.Controls.Add(this.labelObidPovtorno);
            this.Controls.Add(this.labelBravo);
            this.Controls.Add(this.labelUspeshno);
            this.Name = "Pomoshna";
            this.Text = "Win";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Win_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUspeshno;
        private System.Windows.Forms.Label labelBravo;
        private System.Windows.Forms.Label labelObidPovtorno;
        private System.Windows.Forms.Button buttonDa;
        private System.Windows.Forms.Button buttonNe;
    }
}