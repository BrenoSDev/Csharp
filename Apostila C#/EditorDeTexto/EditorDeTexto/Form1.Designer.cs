
namespace EditorDeTexto
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
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoReplace = new System.Windows.Forms.TextBox();
            this.botaoReplace = new System.Windows.Forms.Button();
            this.botaoMaiusculo = new System.Windows.Forms.Button();
            this.botaoMinusculo = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(12, 23);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(402, 212);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(38, 286);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Gravar";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botaoReplace);
            this.groupBox1.Controls.Add(this.textoReplace);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.botaoBusca);
            this.groupBox1.Controls.Add(this.textoBusca);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(131, 252);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 80);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Find and Replace";
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(18, 49);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 2;
            this.botaoBusca.Text = "Find";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(75, 23);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(106, 20);
            this.textoBusca.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Find";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Replace";
            // 
            // textoReplace
            // 
            this.textoReplace.Location = new System.Drawing.Point(294, 26);
            this.textoReplace.Name = "textoReplace";
            this.textoReplace.Size = new System.Drawing.Size(100, 20);
            this.textoReplace.TabIndex = 4;
            // 
            // botaoReplace
            // 
            this.botaoReplace.Location = new System.Drawing.Point(241, 51);
            this.botaoReplace.Name = "botaoReplace";
            this.botaoReplace.Size = new System.Drawing.Size(75, 23);
            this.botaoReplace.TabIndex = 5;
            this.botaoReplace.Text = "Replace";
            this.botaoReplace.UseVisualStyleBackColor = true;
            this.botaoReplace.Click += new System.EventHandler(this.botaoReplace_Click);
            // 
            // botaoMaiusculo
            // 
            this.botaoMaiusculo.Location = new System.Drawing.Point(450, 42);
            this.botaoMaiusculo.Name = "botaoMaiusculo";
            this.botaoMaiusculo.Size = new System.Drawing.Size(75, 23);
            this.botaoMaiusculo.TabIndex = 3;
            this.botaoMaiusculo.Text = "Maiusculo";
            this.botaoMaiusculo.UseVisualStyleBackColor = true;
            this.botaoMaiusculo.Click += new System.EventHandler(this.botaoMaiusculo_Click);
            // 
            // botaoMinusculo
            // 
            this.botaoMinusculo.Location = new System.Drawing.Point(450, 96);
            this.botaoMinusculo.Name = "botaoMinusculo";
            this.botaoMinusculo.Size = new System.Drawing.Size(75, 23);
            this.botaoMinusculo.TabIndex = 4;
            this.botaoMinusculo.Text = "Minusculas";
            this.botaoMinusculo.UseVisualStyleBackColor = true;
            this.botaoMinusculo.Click += new System.EventHandler(this.botaoMinusculo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 335);
            this.Controls.Add(this.botaoMinusculo);
            this.Controls.Add(this.botaoMaiusculo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button botaoBusca;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botaoReplace;
        private System.Windows.Forms.TextBox textoReplace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button botaoMaiusculo;
        private System.Windows.Forms.Button botaoMinusculo;
    }
}

