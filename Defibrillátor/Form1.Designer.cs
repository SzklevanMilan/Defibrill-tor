namespace Defibrillátor
{
    partial class frmFo
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
            this.lblX = new System.Windows.Forms.Label();
            this.lblY = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.btnLekeres = new System.Windows.Forms.Button();
            this.lbAdatok = new System.Windows.Forms.ListBox();
            this.btnUj = new System.Windows.Forms.Button();
            this.btnKilep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(93, 31);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(70, 13);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X koordináta:";
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(93, 58);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(70, 13);
            this.lblY.TabIndex = 1;
            this.lblY.Text = "Y koordináta:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(179, 28);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(129, 20);
            this.tbX.TabIndex = 2;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(179, 58);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(129, 20);
            this.tbY.TabIndex = 3;
            // 
            // btnLekeres
            // 
            this.btnLekeres.Location = new System.Drawing.Point(136, 111);
            this.btnLekeres.Name = "btnLekeres";
            this.btnLekeres.Size = new System.Drawing.Size(137, 32);
            this.btnLekeres.TabIndex = 4;
            this.btnLekeres.Text = "Adatok lekérése";
            this.btnLekeres.UseVisualStyleBackColor = true;
            // 
            // lbAdatok
            // 
            this.lbAdatok.FormattingEnabled = true;
            this.lbAdatok.Location = new System.Drawing.Point(96, 165);
            this.lbAdatok.Name = "lbAdatok";
            this.lbAdatok.Size = new System.Drawing.Size(212, 147);
            this.lbAdatok.TabIndex = 5;
            // 
            // btnUj
            // 
            this.btnUj.Location = new System.Drawing.Point(41, 332);
            this.btnUj.Name = "btnUj";
            this.btnUj.Size = new System.Drawing.Size(122, 33);
            this.btnUj.TabIndex = 6;
            this.btnUj.Text = "Új adat megadása";
            this.btnUj.UseVisualStyleBackColor = true;
            // 
            // btnKilep
            // 
            this.btnKilep.Location = new System.Drawing.Point(243, 332);
            this.btnKilep.Name = "btnKilep";
            this.btnKilep.Size = new System.Drawing.Size(103, 33);
            this.btnKilep.TabIndex = 7;
            this.btnKilep.Text = "Kilépés";
            this.btnKilep.UseVisualStyleBackColor = true;
            // 
            // frmFo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 393);
            this.Controls.Add(this.btnKilep);
            this.Controls.Add(this.btnUj);
            this.Controls.Add(this.lbAdatok);
            this.Controls.Add(this.btnLekeres);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmFo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Defibrillátor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Button btnLekeres;
        private System.Windows.Forms.ListBox lbAdatok;
        private System.Windows.Forms.Button btnUj;
        private System.Windows.Forms.Button btnKilep;
    }
}

