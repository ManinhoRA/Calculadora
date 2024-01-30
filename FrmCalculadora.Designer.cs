namespace Calculadora
{
    partial class frmCalculadora
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
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.btnMaisMenos = new System.Windows.Forms.Button();
            this.btnLimparTudo = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnVirgula = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btn1x = new System.Windows.Forms.Button();
            this.btnPorcentagem = new System.Windows.Forms.Button();
            this.btnRaiz = new System.Windows.Forms.Button();
            this.lblAviso = new System.Windows.Forms.Label();
            this.lblCalculo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultado
            // 
            this.txtResultado.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(5, 8);
            this.txtResultado.MaxLength = 12;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(289, 50);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "0";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(5, 253);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(53, 49);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(64, 253);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(53, 49);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(123, 253);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(53, 49);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(5, 198);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(53, 49);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(64, 198);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(53, 49);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(123, 198);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(53, 49);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(5, 143);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(53, 49);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(64, 143);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(53, 49);
            this.btn8.TabIndex = 8;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(123, 143);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(53, 49);
            this.btn9.TabIndex = 9;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(5, 88);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(53, 49);
            this.btnApagar.TabIndex = 10;
            this.btnApagar.Text = "←";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.btnApagar_Click);
            // 
            // btnMaisMenos
            // 
            this.btnMaisMenos.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMaisMenos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaisMenos.Location = new System.Drawing.Point(182, 88);
            this.btnMaisMenos.Name = "btnMaisMenos";
            this.btnMaisMenos.Size = new System.Drawing.Size(53, 49);
            this.btnMaisMenos.TabIndex = 11;
            this.btnMaisMenos.Text = "±";
            this.btnMaisMenos.UseVisualStyleBackColor = false;
            this.btnMaisMenos.Click += new System.EventHandler(this.btnMaisMenos_Click);
            // 
            // btnLimparTudo
            // 
            this.btnLimparTudo.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimparTudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparTudo.Location = new System.Drawing.Point(64, 88);
            this.btnLimparTudo.Name = "btnLimparTudo";
            this.btnLimparTudo.Size = new System.Drawing.Size(53, 49);
            this.btnLimparTudo.TabIndex = 11;
            this.btnLimparTudo.Text = "CE";
            this.btnLimparTudo.UseVisualStyleBackColor = false;
            this.btnLimparTudo.Click += new System.EventHandler(this.btnLimparTudo_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(123, 88);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(53, 49);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.SeaGreen;
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(182, 143);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(53, 49);
            this.btnDivisao.TabIndex = 13;
            this.btnDivisao.Tag = "/";
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.Operador);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.BackColor = System.Drawing.Color.SeaGreen;
            this.btnMultiplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicacao.Location = new System.Drawing.Point(182, 198);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(53, 49);
            this.btnMultiplicacao.TabIndex = 14;
            this.btnMultiplicacao.Tag = "*";
            this.btnMultiplicacao.Text = "*";
            this.btnMultiplicacao.UseVisualStyleBackColor = false;
            this.btnMultiplicacao.Click += new System.EventHandler(this.Operador);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSubtracao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtracao.Location = new System.Drawing.Point(182, 253);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(53, 49);
            this.btnSubtracao.TabIndex = 15;
            this.btnSubtracao.Tag = "-";
            this.btnSubtracao.Text = "-";
            this.btnSubtracao.UseVisualStyleBackColor = false;
            this.btnSubtracao.Click += new System.EventHandler(this.Operador);
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(5, 308);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(112, 49);
            this.btn0.TabIndex = 16;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            this.btn0.Click += new System.EventHandler(this.UsarNumero);
            // 
            // btnVirgula
            // 
            this.btnVirgula.BackColor = System.Drawing.Color.SeaGreen;
            this.btnVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVirgula.Location = new System.Drawing.Point(123, 308);
            this.btnVirgula.Name = "btnVirgula";
            this.btnVirgula.Size = new System.Drawing.Size(53, 49);
            this.btnVirgula.TabIndex = 17;
            this.btnVirgula.Text = ",";
            this.btnVirgula.UseVisualStyleBackColor = false;
            this.btnVirgula.Click += new System.EventHandler(this.btnVirgula_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoma.Location = new System.Drawing.Point(182, 308);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(53, 49);
            this.btnSoma.TabIndex = 18;
            this.btnSoma.Tag = "+";
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = false;
            this.btnSoma.Click += new System.EventHandler(this.Operador);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.IndianRed;
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(241, 253);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(53, 104);
            this.btnIgual.TabIndex = 19;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btn1x
            // 
            this.btn1x.BackColor = System.Drawing.Color.SeaGreen;
            this.btn1x.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1x.Location = new System.Drawing.Point(241, 198);
            this.btn1x.Name = "btn1x";
            this.btn1x.Size = new System.Drawing.Size(53, 49);
            this.btn1x.TabIndex = 20;
            this.btn1x.Tag = "²";
            this.btn1x.Text = "x²";
            this.btn1x.UseVisualStyleBackColor = false;
            this.btn1x.Click += new System.EventHandler(this.Operador);
            // 
            // btnPorcentagem
            // 
            this.btnPorcentagem.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPorcentagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPorcentagem.Location = new System.Drawing.Point(241, 143);
            this.btnPorcentagem.Name = "btnPorcentagem";
            this.btnPorcentagem.Size = new System.Drawing.Size(53, 49);
            this.btnPorcentagem.TabIndex = 21;
            this.btnPorcentagem.Tag = "%";
            this.btnPorcentagem.Text = "%";
            this.btnPorcentagem.UseVisualStyleBackColor = false;
            this.btnPorcentagem.Click += new System.EventHandler(this.btnPorcentagem_Click);
            // 
            // btnRaiz
            // 
            this.btnRaiz.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRaiz.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaiz.Location = new System.Drawing.Point(241, 88);
            this.btnRaiz.Name = "btnRaiz";
            this.btnRaiz.Size = new System.Drawing.Size(53, 49);
            this.btnRaiz.TabIndex = 22;
            this.btnRaiz.Tag = "√";
            this.btnRaiz.Text = "√";
            this.btnRaiz.UseVisualStyleBackColor = false;
            this.btnRaiz.Click += new System.EventHandler(this.Operador);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.ForeColor = System.Drawing.Color.Red;
            this.lblAviso.Location = new System.Drawing.Point(2, 61);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(33, 13);
            this.lblAviso.TabIndex = 23;
            this.lblAviso.Text = "Aviso";
            this.lblAviso.Visible = false;
            // 
            // lblCalculo
            // 
            this.lblCalculo.AutoSize = true;
            this.lblCalculo.Location = new System.Drawing.Point(182, 61);
            this.lblCalculo.Name = "lblCalculo";
            this.lblCalculo.Size = new System.Drawing.Size(42, 13);
            this.lblCalculo.TabIndex = 24;
            this.lblCalculo.Text = "Cálculo";
            this.lblCalculo.Visible = false;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(299, 361);
            this.Controls.Add(this.lblCalculo);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnRaiz);
            this.Controls.Add(this.btnPorcentagem);
            this.Controls.Add(this.btn1x);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnVirgula);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnLimparTudo);
            this.Controls.Add(this.btnMaisMenos);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtResultado);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmCalculadora";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Button btnMaisMenos;
        private System.Windows.Forms.Button btnLimparTudo;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnVirgula;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btn1x;
        private System.Windows.Forms.Button btnPorcentagem;
        private System.Windows.Forms.Button btnRaiz;
        private System.Windows.Forms.Label lblAviso;
        private System.Windows.Forms.Label lblCalculo;
    }
}

