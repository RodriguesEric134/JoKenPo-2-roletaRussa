namespace JoKenPo_2_roletaRussa
{
    partial class Frm_Resultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Resultado));
            this.Lbl_Resultado = new System.Windows.Forms.Label();
            this.Pic_Resultado = new System.Windows.Forms.PictureBox();
            this.Btn_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Resultado)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Resultado
            // 
            this.Lbl_Resultado.Location = new System.Drawing.Point(190, 76);
            this.Lbl_Resultado.Name = "Lbl_Resultado";
            this.Lbl_Resultado.Size = new System.Drawing.Size(166, 33);
            this.Lbl_Resultado.TabIndex = 0;
            this.Lbl_Resultado.Text = "Ganhou/Morreu";
            // 
            // Pic_Resultado
            // 
            this.Pic_Resultado.Image = global::JoKenPo_2_roletaRussa.Properties.Resources.morreu;
            this.Pic_Resultado.Location = new System.Drawing.Point(13, 12);
            this.Pic_Resultado.Name = "Pic_Resultado";
            this.Pic_Resultado.Size = new System.Drawing.Size(171, 157);
            this.Pic_Resultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pic_Resultado.TabIndex = 1;
            this.Pic_Resultado.TabStop = false;
            // 
            // Btn_Menu
            // 
            this.Btn_Menu.Location = new System.Drawing.Point(216, 145);
            this.Btn_Menu.Name = "Btn_Menu";
            this.Btn_Menu.Size = new System.Drawing.Size(128, 23);
            this.Btn_Menu.TabIndex = 2;
            this.Btn_Menu.Text = "Menu";
            this.Btn_Menu.UseVisualStyleBackColor = true;
            this.Btn_Menu.Click += new System.EventHandler(this.Btn_Menu_Click);
            // 
            // Frm_Resultado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 181);
            this.Controls.Add(this.Btn_Menu);
            this.Controls.Add(this.Pic_Resultado);
            this.Controls.Add(this.Lbl_Resultado);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Resultado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Resultado";
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Resultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Resultado;
        private System.Windows.Forms.PictureBox Pic_Resultado;
        private System.Windows.Forms.Button Btn_Menu;
    }
}