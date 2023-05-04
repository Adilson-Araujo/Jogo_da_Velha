namespace jogo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textJog2 = new System.Windows.Forms.TextBox();
            this.textJog1 = new System.Windows.Forms.TextBox();
            this.butstar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textJog2
            // 
            this.textJog2.Location = new System.Drawing.Point(159, 109);
            this.textJog2.Name = "textJog2";
            this.textJog2.Size = new System.Drawing.Size(100, 20);
            this.textJog2.TabIndex = 0;
            this.textJog2.TabStop = false;
            this.textJog2.UseWaitCursor = true;
            this.textJog2.TextChanged += new System.EventHandler(this.textJog2_TextChanged);
            // 
            // textJog1
            // 
            this.textJog1.Location = new System.Drawing.Point(159, 57);
            this.textJog1.Name = "textJog1";
            this.textJog1.Size = new System.Drawing.Size(100, 20);
            this.textJog1.TabIndex = 1;
            this.textJog1.TabStop = false;
            this.textJog1.TextChanged += new System.EventHandler(this.textJog1_TextChanged);
            // 
            // butstar
            // 
            this.butstar.Location = new System.Drawing.Point(159, 175);
            this.butstar.Name = "butstar";
            this.butstar.Size = new System.Drawing.Size(75, 23);
            this.butstar.TabIndex = 2;
            this.butstar.TabStop = false;
            this.butstar.Text = "Star";
            this.butstar.UseVisualStyleBackColor = true;
            this.butstar.Click += new System.EventHandler(this.butstar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Jogador 2 (O):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jogador 1 (X):";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butstar);
            this.Controls.Add(this.textJog1);
            this.Controls.Add(this.textJog2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textJog2;
        private System.Windows.Forms.TextBox textJog1;
        private System.Windows.Forms.Button butstar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

