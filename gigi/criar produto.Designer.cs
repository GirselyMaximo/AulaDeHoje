namespace gigi
{
    partial class criar_produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criar_produto));
            label1 = new Label();
            texboxFabricante = new TextBox();
            label2 = new Label();
            laa = new Label();
            label = new Label();
            texboxNome = new TextBox();
            inputPrecoCompra = new NumericUpDown();
            inputPrecoVenda = new NumericUpDown();
            ok = new Button();
            Cancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome do produto";
            // 
            // texboxFabricante
            // 
            texboxFabricante.Location = new Point(121, 45);
            texboxFabricante.Name = "texboxFabricante";
            texboxFabricante.Size = new Size(100, 23);
            texboxFabricante.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 0;
            label2.Text = "Fabricante";
            // 
            // laa
            // 
            laa.AutoSize = true;
            laa.Location = new Point(12, 79);
            laa.Name = "laa";
            laa.Size = new Size(97, 15);
            laa.TabIndex = 0;
            laa.Text = "Preço de compra";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(12, 115);
            label.Name = "label";
            label.Size = new Size(88, 15);
            label.TabIndex = 0;
            label.Text = "Preço de venda";
            // 
            // texboxNome
            // 
            texboxNome.Location = new Point(121, 17);
            texboxNome.Name = "texboxNome";
            texboxNome.Size = new Size(100, 23);
            texboxNome.TabIndex = 1;
            // 
            // inputPrecoCompra
            // 
            inputPrecoCompra.DecimalPlaces = 2;
            inputPrecoCompra.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoCompra.Location = new Point(121, 74);
            inputPrecoCompra.Name = "inputPrecoCompra";
            inputPrecoCompra.Size = new Size(102, 23);
            inputPrecoCompra.TabIndex = 3;
            inputPrecoCompra.TextAlign = HorizontalAlignment.Right;
            // 
            // inputPrecoVenda
            // 
            inputPrecoVenda.DecimalPlaces = 2;
            inputPrecoVenda.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            inputPrecoVenda.Location = new Point(121, 115);
            inputPrecoVenda.Name = "inputPrecoVenda";
            inputPrecoVenda.Size = new Size(102, 23);
            inputPrecoVenda.TabIndex = 4;
            inputPrecoVenda.TextAlign = HorizontalAlignment.Right;
            // 
            // ok
            // 
            ok.Location = new Point(12, 167);
            ok.Name = "ok";
            ok.Size = new Size(70, 23);
            ok.TabIndex = 5;
            ok.Text = "Ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += buttonOk;
            // 
            // Cancelar
            // 
            Cancelar.Location = new Point(142, 164);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(70, 26);
            Cancelar.TabIndex = 6;
            Cancelar.Text = "Cancelar";
            Cancelar.UseVisualStyleBackColor = true;
            // 
            // criar_produto
            // 
            AcceptButton = ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            CancelButton = Cancelar;
            ClientSize = new Size(1005, 455);
            Controls.Add(Cancelar);
            Controls.Add(ok);
            Controls.Add(inputPrecoVenda);
            Controls.Add(inputPrecoCompra);
            Controls.Add(texboxNome);
            Controls.Add(label);
            Controls.Add(texboxFabricante);
            Controls.Add(laa);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "criar_produto";
            Text = "criar_produto";
            ((System.ComponentModel.ISupportInitialize)inputPrecoCompra).EndInit();
            ((System.ComponentModel.ISupportInitialize)inputPrecoVenda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox texboxFabricante;
        private Label label2;
        private Label laa;
        private Label label;
        private TextBox texboxNome;
        private NumericUpDown inputPrecoCompra;
        private NumericUpDown inputPrecoVenda;
        private Button ok;
        private Button Cancelar;
    }
}