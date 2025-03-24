namespace JoKenPo_2_roletaRussa
{
    partial class Frm_Roleta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Roleta));
            this.Lbl_ExibeResultado = new System.Windows.Forms.Label();
            this.Lbl_ExibeRoleta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_ExibeResultado
            // 
            this.Lbl_ExibeResultado.AllowDrop = true;
            this.Lbl_ExibeResultado.Location = new System.Drawing.Point(12, 9);
            this.Lbl_ExibeResultado.Name = "Lbl_ExibeResultado";
            this.Lbl_ExibeResultado.Size = new System.Drawing.Size(204, 19);
            this.Lbl_ExibeResultado.TabIndex = 0;
            this.Lbl_ExibeResultado.Text = "Jogador venceu!";
            // 
            // Lbl_ExibeRoleta
            // 
            this.Lbl_ExibeRoleta.AllowDrop = true;
            this.Lbl_ExibeRoleta.Location = new System.Drawing.Point(74, 42);
            this.Lbl_ExibeRoleta.Name = "Lbl_ExibeRoleta";
            this.Lbl_ExibeRoleta.Size = new System.Drawing.Size(307, 17);
            this.Lbl_ExibeRoleta.TabIndex = 1;
            this.Lbl_ExibeRoleta.Text = "Bot Joga roleta russa";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.roleta_russa;
            this.pictureBox1.Location = new System.Drawing.Point(74, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(307, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_Roleta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 293);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Lbl_ExibeRoleta);
            this.Controls.Add(this.Lbl_ExibeResultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Roleta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Roleta Russa";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_ExibeResultado;
        private System.Windows.Forms.Label Lbl_ExibeRoleta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}