
namespace Forca
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelPalavraSecreta = new System.Windows.Forms.Label();
            this.labelComando = new System.Windows.Forms.Label();
            this.textoLetra = new System.Windows.Forms.TextBox();
            this.botaoEnviar = new System.Windows.Forms.Button();
            this.listaForca = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(142, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Jogo da Forca";
            // 
            // labelPalavraSecreta
            // 
            this.labelPalavraSecreta.AutoSize = true;
            this.labelPalavraSecreta.BackColor = System.Drawing.Color.Silver;
            this.labelPalavraSecreta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPalavraSecreta.Location = new System.Drawing.Point(121, 278);
            this.labelPalavraSecreta.MinimumSize = new System.Drawing.Size(200, 25);
            this.labelPalavraSecreta.Name = "labelPalavraSecreta";
            this.labelPalavraSecreta.Size = new System.Drawing.Size(200, 25);
            this.labelPalavraSecreta.TabIndex = 2;
            this.labelPalavraSecreta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelComando
            // 
            this.labelComando.AutoSize = true;
            this.labelComando.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComando.Location = new System.Drawing.Point(40, 323);
            this.labelComando.MinimumSize = new System.Drawing.Size(120, 20);
            this.labelComando.Name = "labelComando";
            this.labelComando.Size = new System.Drawing.Size(121, 20);
            this.labelComando.TabIndex = 3;
            this.labelComando.Text = "Palavra Secreta";
            // 
            // textoLetra
            // 
            this.textoLetra.Location = new System.Drawing.Point(175, 323);
            this.textoLetra.Name = "textoLetra";
            this.textoLetra.Size = new System.Drawing.Size(206, 20);
            this.textoLetra.TabIndex = 4;
            // 
            // botaoEnviar
            // 
            this.botaoEnviar.BackColor = System.Drawing.Color.Navy;
            this.botaoEnviar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEnviar.ForeColor = System.Drawing.Color.White;
            this.botaoEnviar.Location = new System.Drawing.Point(160, 383);
            this.botaoEnviar.Name = "botaoEnviar";
            this.botaoEnviar.Size = new System.Drawing.Size(108, 33);
            this.botaoEnviar.TabIndex = 5;
            this.botaoEnviar.Text = "Enviar";
            this.botaoEnviar.UseVisualStyleBackColor = false;
            this.botaoEnviar.Click += new System.EventHandler(this.botaoEnviar_Click);
            // 
            // listaForca
            // 
            this.listaForca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaForca.HideSelection = false;
            this.listaForca.Location = new System.Drawing.Point(24, 49);
            this.listaForca.Name = "listaForca";
            this.listaForca.Size = new System.Drawing.Size(399, 214);
            this.listaForca.TabIndex = 6;
            this.listaForca.UseCompatibleStateImageBehavior = false;
            this.listaForca.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(448, 461);
            this.Controls.Add(this.listaForca);
            this.Controls.Add(this.botaoEnviar);
            this.Controls.Add(this.textoLetra);
            this.Controls.Add(this.labelComando);
            this.Controls.Add(this.labelPalavraSecreta);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "Form1";
            this.Text = "Forca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPalavraSecreta;
        private System.Windows.Forms.Label labelComando;
        private System.Windows.Forms.TextBox textoLetra;
        private System.Windows.Forms.Button botaoEnviar;
        private System.Windows.Forms.ListView listaForca;
    }
}

