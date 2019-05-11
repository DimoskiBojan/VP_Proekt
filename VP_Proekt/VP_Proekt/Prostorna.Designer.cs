namespace VP_Proekt
{
    partial class Prostorna
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
            this.components = new System.ComponentModel.Container();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.lbPrimary = new System.Windows.Forms.ListBox();
            this.lbLeft = new System.Windows.Forms.ListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnDodadi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbPogodeniLeft = new System.Windows.Forms.TextBox();
            this.btnIzbrishi = new System.Windows.Forms.Button();
            this.tbPogodeniRight = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLeft = new System.Windows.Forms.Label();
            this.lblRight = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.pbPogodeni = new System.Windows.Forms.ProgressBar();
            this.btnMoveBackRight = new System.Windows.Forms.Button();
            this.btnMoveBackLeft = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(524, 204);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(40, 30);
            this.btnMoveRight.TabIndex = 1;
            this.btnMoveRight.Text = ">>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMoveRight_Click);
            // 
            // lbPrimary
            // 
            this.lbPrimary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrimary.FormattingEnabled = true;
            this.lbPrimary.ItemHeight = 18;
            this.lbPrimary.Location = new System.Drawing.Point(291, 56);
            this.lbPrimary.Name = "lbPrimary";
            this.lbPrimary.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbPrimary.Size = new System.Drawing.Size(218, 328);
            this.lbPrimary.TabIndex = 2;
            // 
            // lbLeft
            // 
            this.lbLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLeft.FormattingEnabled = true;
            this.lbLeft.ItemHeight = 18;
            this.lbLeft.Location = new System.Drawing.Point(12, 38);
            this.lbLeft.Name = "lbLeft";
            this.lbLeft.Size = new System.Drawing.Size(218, 346);
            this.lbLeft.TabIndex = 3;
            // 
            // lbRight
            // 
            this.lbRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRight.FormattingEnabled = true;
            this.lbRight.ItemHeight = 18;
            this.lbRight.Location = new System.Drawing.Point(570, 38);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(218, 346);
            this.lbRight.TabIndex = 4;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(236, 204);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(40, 30);
            this.btnMoveLeft.TabIndex = 5;
            this.btnMoveLeft.Text = "<<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMoveLeft_Click);
            // 
            // btnDodadi
            // 
            this.btnDodadi.Location = new System.Drawing.Point(291, 404);
            this.btnDodadi.Name = "btnDodadi";
            this.btnDodadi.Size = new System.Drawing.Size(218, 23);
            this.btnDodadi.TabIndex = 6;
            this.btnDodadi.Text = "Додади ставка";
            this.btnDodadi.UseVisualStyleBackColor = true;
            this.btnDodadi.Click += new System.EventHandler(this.btnDodadi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Погодени: ";
            // 
            // tbPogodeniLeft
            // 
            this.tbPogodeniLeft.Enabled = false;
            this.tbPogodeniLeft.Location = new System.Drawing.Point(12, 423);
            this.tbPogodeniLeft.Name = "tbPogodeniLeft";
            this.tbPogodeniLeft.ReadOnly = true;
            this.tbPogodeniLeft.Size = new System.Drawing.Size(84, 20);
            this.tbPogodeniLeft.TabIndex = 8;
            // 
            // btnIzbrishi
            // 
            this.btnIzbrishi.Location = new System.Drawing.Point(291, 433);
            this.btnIzbrishi.Name = "btnIzbrishi";
            this.btnIzbrishi.Size = new System.Drawing.Size(218, 23);
            this.btnIzbrishi.TabIndex = 11;
            this.btnIzbrishi.Text = "Избриши ставка";
            this.btnIzbrishi.UseVisualStyleBackColor = true;
            this.btnIzbrishi.Click += new System.EventHandler(this.btnIzbrishi_Click);
            // 
            // tbPogodeniRight
            // 
            this.tbPogodeniRight.Enabled = false;
            this.tbPogodeniRight.Location = new System.Drawing.Point(704, 423);
            this.tbPogodeniRight.Name = "tbPogodeniRight";
            this.tbPogodeniRight.ReadOnly = true;
            this.tbPogodeniRight.Size = new System.Drawing.Size(84, 20);
            this.tbPogodeniRight.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(729, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Погодени:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeft.Location = new System.Drawing.Point(8, 6);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(60, 24);
            this.lblLeft.TabIndex = 14;
            this.lblLeft.Text = "label3";
            // 
            // lblRight
            // 
            this.lblRight.AutoSize = true;
            this.lblRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRight.Location = new System.Drawing.Point(566, 6);
            this.lblRight.Name = "lblRight";
            this.lblRight.Size = new System.Drawing.Size(60, 24);
            this.lblRight.TabIndex = 15;
            this.lblRight.Text = "label4";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(422, 15);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(71, 29);
            this.lblTimer.TabIndex = 16;
            this.lblTimer.Text = "00:00";
            // 
            // pbPogodeni
            // 
            this.pbPogodeni.Location = new System.Drawing.Point(12, 462);
            this.pbPogodeni.Name = "pbPogodeni";
            this.pbPogodeni.Size = new System.Drawing.Size(776, 23);
            this.pbPogodeni.TabIndex = 17;
            // 
            // btnMoveBackRight
            // 
            this.btnMoveBackRight.Location = new System.Drawing.Point(245, 240);
            this.btnMoveBackRight.Name = "btnMoveBackRight";
            this.btnMoveBackRight.Size = new System.Drawing.Size(40, 30);
            this.btnMoveBackRight.TabIndex = 18;
            this.btnMoveBackRight.Text = ">";
            this.btnMoveBackRight.UseVisualStyleBackColor = true;
            this.btnMoveBackRight.Click += new System.EventHandler(this.btnMoveBackRight_Click);
            // 
            // btnMoveBackLeft
            // 
            this.btnMoveBackLeft.Location = new System.Drawing.Point(515, 240);
            this.btnMoveBackLeft.Name = "btnMoveBackLeft";
            this.btnMoveBackLeft.Size = new System.Drawing.Size(40, 30);
            this.btnMoveBackLeft.TabIndex = 19;
            this.btnMoveBackLeft.Text = "<";
            this.btnMoveBackLeft.UseVisualStyleBackColor = true;
            this.btnMoveBackLeft.Click += new System.EventHandler(this.btnMoveBackLeft_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(305, 15);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(111, 29);
            this.btnNewGame.TabIndex = 20;
            this.btnNewGame.Text = "Нова игра";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // Prostorna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnMoveBackLeft);
            this.Controls.Add(this.btnMoveBackRight);
            this.Controls.Add(this.pbPogodeni);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.lblRight);
            this.Controls.Add(this.lblLeft);
            this.Controls.Add(this.tbPogodeniRight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnIzbrishi);
            this.Controls.Add(this.tbPogodeniLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDodadi);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.lbLeft);
            this.Controls.Add(this.lbPrimary);
            this.Controls.Add(this.btnMoveRight);
            this.Name = "Prostorna";
            this.Text = "Просторна ориентација";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.ListBox lbPrimary;
        private System.Windows.Forms.ListBox lbLeft;
        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.Button btnDodadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPogodeniLeft;
        private System.Windows.Forms.Button btnIzbrishi;
        private System.Windows.Forms.TextBox tbPogodeniRight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.Label lblRight;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.ProgressBar pbPogodeni;
        private System.Windows.Forms.Button btnMoveBackRight;
        private System.Windows.Forms.Button btnMoveBackLeft;
        private System.Windows.Forms.Button btnNewGame;
    }
}