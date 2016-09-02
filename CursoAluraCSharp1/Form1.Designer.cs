namespace IAB.CaixaEletronico
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.textoTitular = new System.Windows.Forms.TextBox();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.textoNumero = new System.Windows.Forms.TextBox();
            this.textoSaldo = new System.Windows.Forms.TextBox();
            this.btnSacar = new System.Windows.Forms.Button();
            this.textoValorSaque = new System.Windows.Forms.TextBox();
            this.labelTotalContas = new System.Windows.Forms.Label();
            this.saldoConta = new System.Windows.Forms.TextBox();
            this.btnAbrirFormulario = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clique aqui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textoTitular
            // 
            this.textoTitular.Location = new System.Drawing.Point(12, 39);
            this.textoTitular.Name = "textoTitular";
            this.textoTitular.Size = new System.Drawing.Size(100, 20);
            this.textoTitular.TabIndex = 1;
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(12, 12);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 2;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // textoNumero
            // 
            this.textoNumero.Location = new System.Drawing.Point(12, 65);
            this.textoNumero.Name = "textoNumero";
            this.textoNumero.Size = new System.Drawing.Size(100, 20);
            this.textoNumero.TabIndex = 3;
            // 
            // textoSaldo
            // 
            this.textoSaldo.Location = new System.Drawing.Point(12, 91);
            this.textoSaldo.Name = "textoSaldo";
            this.textoSaldo.Size = new System.Drawing.Size(100, 20);
            this.textoSaldo.TabIndex = 4;
            // 
            // btnSacar
            // 
            this.btnSacar.Location = new System.Drawing.Point(239, 65);
            this.btnSacar.Name = "btnSacar";
            this.btnSacar.Size = new System.Drawing.Size(75, 23);
            this.btnSacar.TabIndex = 5;
            this.btnSacar.Text = "Sacar";
            this.btnSacar.UseVisualStyleBackColor = true;
            this.btnSacar.Click += new System.EventHandler(this.btnSacar_Click);
            // 
            // textoValorSaque
            // 
            this.textoValorSaque.Location = new System.Drawing.Point(239, 39);
            this.textoValorSaque.Name = "textoValorSaque";
            this.textoValorSaque.Size = new System.Drawing.Size(100, 20);
            this.textoValorSaque.TabIndex = 6;
            // 
            // labelTotalContas
            // 
            this.labelTotalContas.AutoSize = true;
            this.labelTotalContas.Location = new System.Drawing.Point(164, 97);
            this.labelTotalContas.Name = "labelTotalContas";
            this.labelTotalContas.Size = new System.Drawing.Size(0, 13);
            this.labelTotalContas.TabIndex = 7;
            // 
            // saldoConta
            // 
            this.saldoConta.Location = new System.Drawing.Point(239, 13);
            this.saldoConta.Name = "saldoConta";
            this.saldoConta.Size = new System.Drawing.Size(100, 20);
            this.saldoConta.TabIndex = 8;
            // 
            // btnAbrirFormulario
            // 
            this.btnAbrirFormulario.Location = new System.Drawing.Point(12, 148);
            this.btnAbrirFormulario.Name = "btnAbrirFormulario";
            this.btnAbrirFormulario.Size = new System.Drawing.Size(99, 23);
            this.btnAbrirFormulario.TabIndex = 9;
            this.btnAbrirFormulario.Text = "Abrir formulário";
            this.btnAbrirFormulario.UseVisualStyleBackColor = true;
            this.btnAbrirFormulario.Click += new System.EventHandler(this.btnAbrirFormulario_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 177);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Remover";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAbrirFormulario);
            this.Controls.Add(this.saldoConta);
            this.Controls.Add(this.labelTotalContas);
            this.Controls.Add(this.textoValorSaque);
            this.Controls.Add(this.btnSacar);
            this.Controls.Add(this.textoSaldo);
            this.Controls.Add(this.textoNumero);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.textoTitular);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textoTitular;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.TextBox textoNumero;
        private System.Windows.Forms.TextBox textoSaldo;
        private System.Windows.Forms.Button btnSacar;
        private System.Windows.Forms.TextBox textoValorSaque;
        private System.Windows.Forms.Label labelTotalContas;
        private System.Windows.Forms.TextBox saldoConta;
        private System.Windows.Forms.Button btnAbrirFormulario;
        private System.Windows.Forms.Button button2;
    }
}

