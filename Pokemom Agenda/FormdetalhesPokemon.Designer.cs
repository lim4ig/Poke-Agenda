namespace Pokemom_Agenda
{
    partial class FormdetalhesPokemon
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
            this.lbNome = new System.Windows.Forms.Label();
            this.pbImagemPokedex = new System.Windows.Forms.PictureBox();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbNivel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemPokedex)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(12, 252);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(70, 26);
            this.lbNome.TabIndex = 0;
            this.lbNome.Text = "label1";
            this.lbNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbImagemPokedex
            // 
            this.pbImagemPokedex.Location = new System.Drawing.Point(12, 12);
            this.pbImagemPokedex.Name = "pbImagemPokedex";
            this.pbImagemPokedex.Size = new System.Drawing.Size(309, 217);
            this.pbImagemPokedex.TabIndex = 3;
            this.pbImagemPokedex.TabStop = false;
            this.pbImagemPokedex.Click += new System.EventHandler(this.pbImagemPokedex_Click);
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(12, 293);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(70, 26);
            this.lbTipo.TabIndex = 4;
            this.lbTipo.Text = "label2";
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNivel.Location = new System.Drawing.Point(12, 335);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(70, 26);
            this.lbNivel.TabIndex = 5;
            this.lbNivel.Text = "label3";
            // 
            // FormdetalhesPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 487);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.pbImagemPokedex);
            this.Controls.Add(this.lbNome);
            this.Name = "FormdetalhesPokemon";
            this.Text = "FormdetalhesPokemon";
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemPokedex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.PictureBox pbImagemPokedex;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbNivel;
    }
}