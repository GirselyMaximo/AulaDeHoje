namespace gigi
{
    partial class FormCliente
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
            labelNome = new Label();
            labelTelefone = new Label();
            labelEmail = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            groupBoxEndereço = new GroupBox();
            labelLogradouro = new Label();
            labelNumero = new Label();
            labelComplemento = new Label();
            labelCidade = new Label();
            labelUfEstado = new Label();
            labelCep = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            groupBoxEndereço.SuspendLayout();
            SuspendLayout();
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 18);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(43, 15);
            labelNome.TabIndex = 0;
            labelNome.Text = "Nome:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(11, 61);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(54, 15);
            labelTelefone.TabIndex = 0;
            labelTelefone.Text = "Telefone:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(12, 99);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(44, 15);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "E-mail:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(91, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(91, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(91, 96);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 1;
            // 
            // groupBoxEndereço
            // 
            groupBoxEndereço.Controls.Add(textBox9);
            groupBoxEndereço.Controls.Add(textBox8);
            groupBoxEndereço.Controls.Add(textBox7);
            groupBoxEndereço.Controls.Add(textBox6);
            groupBoxEndereço.Controls.Add(textBox5);
            groupBoxEndereço.Controls.Add(textBox4);
            groupBoxEndereço.Controls.Add(labelCep);
            groupBoxEndereço.Controls.Add(labelUfEstado);
            groupBoxEndereço.Controls.Add(labelCidade);
            groupBoxEndereço.Controls.Add(labelComplemento);
            groupBoxEndereço.Controls.Add(labelNumero);
            groupBoxEndereço.Controls.Add(labelLogradouro);
            groupBoxEndereço.Location = new Point(12, 133);
            groupBoxEndereço.Name = "groupBoxEndereço";
            groupBoxEndereço.Size = new Size(274, 211);
            groupBoxEndereço.TabIndex = 2;
            groupBoxEndereço.TabStop = false;
            groupBoxEndereço.Text = "Endereço";
            // 
            // labelLogradouro
            // 
            labelLogradouro.AutoSize = true;
            labelLogradouro.Location = new Point(6, 34);
            labelLogradouro.Name = "labelLogradouro";
            labelLogradouro.Size = new Size(97, 15);
            labelLogradouro.TabIndex = 3;
            labelLogradouro.Text = "Logradouro(rua):";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(6, 60);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(54, 15);
            labelNumero.TabIndex = 3;
            labelNumero.Text = "Numero:";
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Location = new Point(6, 88);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(87, 15);
            labelComplemento.TabIndex = 3;
            labelComplemento.Text = "Complemento:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Location = new Point(6, 117);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(47, 15);
            labelCidade.TabIndex = 3;
            labelCidade.Text = "Cidade:";
            // 
            // labelUfEstado
            // 
            labelUfEstado.AutoSize = true;
            labelUfEstado.Location = new Point(6, 147);
            labelUfEstado.Name = "labelUfEstado";
            labelUfEstado.Size = new Size(62, 15);
            labelUfEstado.TabIndex = 3;
            labelUfEstado.Text = "UF Estado:";
            // 
            // labelCep
            // 
            labelCep.AutoSize = true;
            labelCep.Location = new Point(6, 177);
            labelCep.Name = "labelCep";
            labelCep.Size = new Size(31, 15);
            labelCep.TabIndex = 3;
            labelCep.Text = "CEP:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(134, 31);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 4;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(134, 62);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(134, 91);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 4;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(134, 120);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(100, 23);
            textBox7.TabIndex = 4;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(134, 147);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(100, 23);
            textBox8.TabIndex = 4;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(134, 176);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(100, 23);
            textBox9.TabIndex = 4;
            // 
            // FormCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxEndereço);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Name = "FormCliente";
            Text = "FormCliente";
            groupBoxEndereço.ResumeLayout(false);
            groupBoxEndereço.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNome;
        private Label labelTelefone;
        private Label labelEmail;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private GroupBox groupBoxEndereço;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private Label labelCep;
        private Label labelUfEstado;
        private Label labelCidade;
        private Label labelComplemento;
        private Label labelNumero;
        private Label labelLogradouro;
    }
}